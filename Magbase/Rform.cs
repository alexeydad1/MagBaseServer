 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace MagbaseServer
{
    public partial class Rform : Form
    {
        sqldb _SQl = new sqldb();
        Source _SRC = new Source();
        public DataTable FindshkTableR = new DataTable();
        public DataTable FindKodTableR = new DataTable();
        public DataTable FifoTableR = new DataTable();
        public double cell_before = 0;
        public string exitfrm = "";
        public string pref_dok_rashod;
        public int number_dok_rashod;
        public string pref_kod;
        public int FlagRashodMinus=0;
        public int FlagImportError = 0;
        public Rform()
        {
            CallBackMy.callbackEventHandlerRform = new CallBackMy.callbackEventRform(this.LoadRashodkod);
            CallBackMy.callbackEventHandlerRformImport = new CallBackMy.callbackEventRformImport(this.ImportCount);
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(EnterKeyWait);
            this.KeyUp += new KeyEventHandler(F2KeyWait);
        }

        private void Rform_Load(object sender, EventArgs e)
        {
            dgvR.Columns.Add("Kod", "Код");
            dgvR.Columns.Add("Name", "Наименование");
            dgvR.Columns.Add("Zcena", "Цена закупки");
            dgvR.Columns.Add("Count", "Кол-во");
            dgvR.Columns.Add("Zsumm", "Сумма закупки");
            dgvR.Columns.Add("PrivyazkaR", "Привязка товара");//Колонка в которой код основного товара для списания
            dgvR.Columns.Add("SpisanieR", "Объем списания");//Колонка в которой код объема списания
            dgvR.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvR.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvR.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvR.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvR.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            dgvR.Columns[0].ReadOnly = true;
            dgvR.Columns[1].ReadOnly = true;
            //dgvR.Columns[2].ReadOnly = true;
            //dgvR.Columns[3].ReadOnly = true;
            dgvR.Columns[4].ReadOnly = true;
            dgvR.Columns[5].Visible = false;
            dgvR.Columns[6].Visible = false;

            pref_dok_rashod = _SRC.pref_dok_rashod();
            number_dok_rashod = _SRC.number_dok_rashod();
            lblRNumdokmag.Text = Convert.ToString(pref_dok_rashod + Convert.ToString(number_dok_rashod).PadLeft(6, '0'));

            
            load_cmb_sup();
            if (File.Exists(Application.StartupPath + "\\outcom.xml"))
            {
                serRload();
                summ_rashod();
            }

        }
        private void load_cmb_sup()
        {
            string SqlCmbLoad = "SELECT * FROM Suppliers order by name";
            DataTable CmbLoadTable = _SQl.ExecuteSQL(SqlCmbLoad);

            cmbSupR.DataSource = CmbLoadTable;
            cmbSupR.DisplayMember = "Name";
            cmbSupR.ValueMember = "id";
            cmbSupR.SelectedValue = 0;
        }

        private void btnDelP_Click(object sender, EventArgs e)
        {
            int l = dgvR.RowCount;
            if (l == 0)
            {
                MessageBox.Show("Накладная пустая!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRshtovar.Focus();
                return;
            }
            int i = dgvR.CurrentRow.Index;
            dgvR.Rows.RemoveAt(i);
            summ_rashod();
            serRsave();
        }
        private void summ_rashod()
        {
            lblSummRashod.Text = "0";
            for (int i = 0; i < dgvR.Rows.Count; i++)
            {
                dgvR.Rows[i].Cells["Zsumm"].Value = Math.Round(Convert.ToDouble(dgvR.Rows[i].Cells["Zcena"].Value) * Convert.ToDouble(dgvR.Rows[i].Cells["Count"].Value),2);
                lblSummRashod.Text = Convert.ToString(Math.Round(Convert.ToDouble(dgvR.Rows[i].Cells["Zsumm"].Value) + Convert.ToDouble(lblSummRashod.Text),2));

            }
            txtRshtovar.Focus();
        }

        private void EnterKeyWait(object sender, KeyEventArgs e)
        {
          // Если фокус в штрихкод то выполняе действия
            if (txtRshtovar.Focused == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtRshtovar.Text != "")
                    {
                        DataTable PrefPlutbl = _SQl.ExecuteSQL("select PrefVesEan,PLUcount,EAnCount,PLUkodnum from source");
                        string prefPlu = PrefPlutbl.Rows[0][0].ToString();
                        int PLUcount = Convert.ToInt32(PrefPlutbl.Rows[0][1].ToString());
                        int EAnCount = Convert.ToInt32(PrefPlutbl.Rows[0][2].ToString());
                        string EanWeight = txtRshtovar.Text;

                        if (EanWeight.Length == EAnCount)
                        {
                            if (EanWeight.IndexOf(prefPlu, 0, 2) >= 0)
                            {
                                weight_goods(PLUcount, EanWeight);
                                return;
                            }

                        }
                        Findshk();
                    }
                   
                    txtRshtovar.Text = "";
                    
                }
            }
        }
        private void F2KeyWait(object sender, KeyEventArgs e)
        {
             // Если фокус в штрихкод то выполняе действия
            if (txtRshtovar.Focused == true)
            {
                if (e.KeyCode == Keys.F2)
                {
                    int idrow = dgvR.Rows.Count;
                    if (idrow > 0)
                    {
                        dgvR.Focus();
                        dgvR.CurrentCell = dgvR.Rows[idrow - 1].Cells[3];
                    }

                }
            }
        }

        private void Findshk()
        {

            string SqlShkfind = "select Kod,Name,Zcena,kod_osnova,obem_spisanie,Quantity from Dbase where EAN like'%" + txtRshtovar.Text + "%'";
            FindshkTableR = _SQl.ExecuteSQL(SqlShkfind);

            if (FindshkTableR.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRshtovar.Focus();
                FlagImportError = 1;
                return;
            }
            if (FindshkTableR.Rows.Count > 1)
            {
                // проверяем не запущена ли форма 
                for (int x = 0; x < this.OwnedForms.Length; x++)
                {
                    if (this.OwnedForms[x].Name == "Viborform")
                    {
                        this.OwnedForms[x].Focus();
                        return;
                    }
                }

                // Запускаем форму если она не запущена

                Data.Tovartbl = FindshkTableR;
                // сделать форму с выводом позиций на одном штрихкоде
                Sform.ownerFormName = "Rform";
                Form Viborform = new Viborform();
                Viborform.StartPosition = FormStartPosition.CenterScreen;
                //указываем владельца для формы
                // Viborform.MdiParent = this.MdiParent; // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Viborform.Owner = this;
                Viborform.Show();
                txtRshtovar.Text = "";

                return;
            }
            string kod = FindshkTableR.Rows[0][0].ToString();
            string name = FindshkTableR.Rows[0][1].ToString();
            double zcena = Convert.ToDouble(FindshkTableR.Rows[0][2].ToString());
            double count = 1;
            double zsumm = Convert.ToDouble(FindshkTableR.Rows[0][2].ToString());
            string kodosnova =FindshkTableR.Rows[0][3].ToString();
            double obem_spisanie = Convert.ToDouble(FindshkTableR.Rows[0][4].ToString());
            double qty = Convert.ToDouble(FindshkTableR.Rows[0][5].ToString());

            dgvR.Rows.Add(kod, name, zcena, count, zsumm, kodosnova, obem_spisanie);
            int resultfind = 0;
            if (dgvR.Rows.Count > 0)
            {
                for (int i = 0; i < dgvR.Rows.Count - 1; i++)
                {
                    if (dgvR.Rows[i].Cells[0].Value.ToString() == kod)
                    {
                        dgvR.Rows[i].Cells[3].Value = Convert.ToDouble(dgvR.Rows[i].Cells[3].Value.ToString()) + Convert.ToDouble(count);
                        dgvR.Rows.RemoveAt(dgvR.Rows.Count - 1);
                        dgvR.ClearSelection();
                        dgvR.Rows[i].Selected = true;
                        dgvR.CurrentCell = dgvR.Rows[i].Cells[3];
                        resultfind = 1;
                        if (qty <= 0)
                        {
                            dgvR.Rows[i].DefaultCellStyle.ForeColor = Color.Coral;
                            dgvR.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Coral;

                        }

                    }

                }
                if (resultfind == 0)
                {
                    dgvR.ClearSelection();
                    dgvR.Rows[dgvR.Rows.Count - 1].Selected = true;
                    dgvR.CurrentCell = dgvR.Rows[dgvR.RowCount - 1].Cells[3];
                    if (qty <= 0)
                    {
                        dgvR.Rows[dgvR.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Coral;
                        dgvR.Rows[dgvR.Rows.Count - 1].DefaultCellStyle.SelectionForeColor = Color.Coral;

                    }

                }

            }

            lbllinedokR.Text = dgvR.RowCount.ToString();
            summ_rashod();
            serRsave();
        }

        private void LoadRashodkod(string kodtovara)
        {
            string SqlKodfind = "select Kod,Name,Zcena,kod_osnova,obem_spisanie,Quantity from Dbase where kod='" + kodtovara + "'";
            FindKodTableR = _SQl.ExecuteSQL(SqlKodfind);

            if (FindKodTableR.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRkodtovar.Focus();
                return;
            }
            if (FindKodTableR.Rows.Count > 1)
            {
                // сделать форму с выводом позиций на одном штрихкоде
                for (int i = 0; i < FindKodTableR.Rows.Count; i++)
                {
                    MessageBox.Show(FindKodTableR.Rows[i][0].ToString() + " " + FindKodTableR.Rows[i][1].ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return;
            }
            string kod = FindKodTableR.Rows[0][0].ToString();
            string name = FindKodTableR.Rows[0][1].ToString();
            double zcena = Convert.ToDouble(FindKodTableR.Rows[0][2].ToString());
            double count = 1;
            double zsumm = Convert.ToDouble(FindKodTableR.Rows[0][2].ToString());
            string kodosnova = FindKodTableR.Rows[0][3].ToString();
            double obem_spisanie = Convert.ToDouble(FindKodTableR.Rows[0][4].ToString());
            double qty = Convert.ToDouble(FindKodTableR.Rows[0][5].ToString());

            dgvR.Rows.Add(kod, name, zcena, count, zsumm, kodosnova, obem_spisanie);
            int resultfind = 0;
            if (dgvR.Rows.Count > 0)
            {
                for (int i = 0; i < dgvR.Rows.Count - 1; i++)
                {
                    if (dgvR.Rows[i].Cells[0].Value.ToString() == kod)
                    {
                        dgvR.Rows[i].Cells[3].Value = Convert.ToDouble(dgvR.Rows[i].Cells[3].Value.ToString()) + Convert.ToDouble(count);
                        dgvR.Rows.RemoveAt(dgvR.Rows.Count - 1);
                        dgvR.ClearSelection();
                        dgvR.Rows[i].Selected = true;
                        dgvR.CurrentCell = dgvR.Rows[i].Cells[3];
                        resultfind = 1;
                        if (qty <= 0)
                        {
                            dgvR.Rows[i].DefaultCellStyle.ForeColor = Color.Coral;
                            dgvR.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Coral;

                        }

                    }

                }
                if (resultfind == 0)
                {
                    dgvR.ClearSelection();
                    dgvR.Rows[dgvR.Rows.Count - 1].Selected = true;
                    dgvR.CurrentCell = dgvR.Rows[dgvR.RowCount - 1].Cells[3];
                    if (qty <= 0)
                    {
                        dgvR.Rows[dgvR.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Coral;
                        dgvR.Rows[dgvR.Rows.Count - 1].DefaultCellStyle.SelectionForeColor = Color.Coral;

                    }

                }

            }
            lbllinedokR.Text = dgvR.RowCount.ToString();
            summ_rashod();
            serRsave();
        }


        private void dgvR_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            chek_num();
            serRsave();
        }
        private void chek_num()
        {
            int irow = dgvR.CurrentRow.Index;
            int icell = dgvR.CurrentCell.ColumnIndex;
            string chek_cell = "";
            if (dgvR.Rows[irow].Cells[icell].Value == null)
            {
                dgvR.Rows[irow].Cells[icell].Value = cell_before;
            }
            else
            {
                chek_cell = dgvR.Rows[irow].Cells[icell].Value.ToString();
            }

            if (chek_cell == "")
            {
                dgvR.Rows[irow].Cells[icell].Value = cell_before;
                return;
            }

            double num;
            if (double.TryParse(chek_cell, out num))
            {
                dgvR.Rows[irow].Cells[icell].Value = Convert.ToDouble(chek_cell);
                summ_rashod();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvR.Rows[irow].Cells[icell].Value = cell_before;
                return;

            }
            
        }

        private void dgvR_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int irow = dgvR.CurrentRow.Index;
            int icell = dgvR.CurrentCell.ColumnIndex;
            cell_before=Convert.ToDouble(dgvR.Rows[irow].Cells[icell].Value);

        }

        private void txtRkodtovar_TextChanged(object sender, EventArgs e)
        {
            txtRkodtovar.Text = Regex.Replace(txtRkodtovar.Text, "[^0-9]", string.Empty);
            if (txtRkodtovar.TextLength == 6)
            {
                pref_kod = _SRC.pref_kod();
                string kodtovara = pref_kod + txtRkodtovar.Text;
                LoadRashodkod(kodtovara);
                txtRkodtovar.Text = "";
                txtRshtovar.Focus();
            }
        }

        private void bntSaveP_Click(object sender, EventArgs e)
        {

            int l = dgvR.RowCount;
            if (l == 0)
            {
                MessageBox.Show("Накладная пустая!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRshtovar.Focus();
                return;
            }
            if (cmbSupR.Text == "")
            {
                MessageBox.Show("Выберите Поставщика!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSupR.Focus();
                return;
            }

            if (txtDokSup.Text == "")
            {
                MessageBox.Show("Заполните поле № Документа поставщика!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDokSup.Focus();
                return;
            }

            if (msktxtDateDok.Text.Length < 8)
            {
                MessageBox.Show("Заполните поле № Дату документа поставщика!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msktxtDateDok.Focus();
                return;
            }

            DialogResult saverashod= MessageBox.Show("Сохранить накладную?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (saverashod == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                string numberdock_magR = lblRNumdokmag.Text;
                int id_supR = Convert.ToInt32(cmbSupR.SelectedValue);
                string numdock_sup = txtDokSup.Text;
                string date_dock_sup = msktxtDateDok.Text;
                DateTime date1 = DateTime.Now;
                string dateR = date1.ToString("u").Remove(19);

                string[] ArrMinus = new string[dgvR.Rows.Count];
                int iArr = 0;
                for (int i = 0; i < dgvR.Rows.Count; i++)
                {
                    string kod = dgvR.Rows[i].Cells[0].Value.ToString();
                    double count = Convert.ToDouble(dgvR.Rows[i].Cells[3].Value.ToString());
                    double zcena = Convert.ToDouble(dgvR.Rows[i].Cells[2].Value.ToString());
                    string kod_osn = dgvR.Rows[i].Cells[5].Value.ToString();
                    double obem_sps = Convert.ToDouble(dgvR.Rows[i].Cells[6].Value.ToString());
                    string name = dgvR.Rows[i].Cells[1].Value.ToString();

                    rashod_save(kod, zcena, count, numberdock_magR, id_supR, numdock_sup, date_dock_sup, dateR, kod_osn, obem_sps,name);
                    if (FlagRashodMinus == 1)
                    {
                        FlagRashodMinus = 0;
                        ArrMinus[iArr] = kod + " - " + name;
                        iArr++;
                    }
                }
                if (ArrMinus[0] != null)
                {
                    string messminus = "Внимание расход в минус: " + Environment.NewLine;
                    for (int k = 0; k < iArr; k++)
                    {
                        messminus += ArrMinus[k] + Environment.NewLine;
                    }
                    MessageBox.Show(messminus, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                while (dgvR.Rows.Count != 0)
                {
                    dgvR.Rows.Remove(dgvR.Rows[dgvR.Rows.Count - 1]);
                }

                txtDokSup.Text = "";
                msktxtDateDok.Text = "";
                cmbSupR.Text = "";
                lblSummRashod.Text = "0";
                
                exitfrm = "func";
                List<Rashod> ProfileList = new List<Rashod>();
                serializeTable.Save<List<Rashod>>(ProfileList, "outcom.xml");
                this.Cursor = Cursors.Default;
                this.Close();

               
            }
        }
        private void rashod_save(string kod, double zcena, double count, string numdok_magR, int id_supR, string numdock_sup, string date_dock_sup, string dateR,string kod_osnova,double obem_spisania,string Name)
        { 
            //Дописать списание по виртуальному коду;
//////////////Дописать функию списания расходной накладной, чере FIFO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //Проверка есть ли привязка на списание к основному товару

            string KODFIFO = "";
            if (obem_spisania > 0)
            {
                KODFIFO = kod_osnova;
                count =  Math.Round((count * obem_spisania),3);
            }
            else
            {
                KODFIFO = kod;
            }
            //Блокируем код товара всем потокам для работы с ним по всем запросам 
            while (true)
            {
                _SQl.SQL_Query("INSERT INTO BlockT (kod_dbase) Values('" + KODFIFO + "')");
                if (_SQl.uniqBlockT == 0 && _SQl.sql_con.State.ToString() == "Closed")
                {
                    break;
                }
                Thread.Sleep(500);
            }
            //Проверка есть ли привязка на списание к основному товару
            double QTYDBASE = 0;//количество из dbase
            DataTable QuantityKodTable = new DataTable();
            
           
            FifoTableR = _SQl.ExecuteSQL("SELECT numberdock_mag,count,count_s,id FROM incoming WHERE kod_dbase = '" + KODFIFO + "' AND status = '0' order by date");
            
            QuantityKodTable = _SQl.ExecuteSQL("select quantity from dbase where kod='" + KODFIFO + "'");
            QTYDBASE = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString())), 3);//количество товара 
          

            
            for (int idrow = 0; idrow < FifoTableR.Rows.Count; idrow++)
            {

                string numberdock_mag_incoming = FifoTableR.Rows[idrow][0].ToString();
                double count_incoming = Convert.ToDouble(FifoTableR.Rows[idrow][1].ToString());
                double count_s_incoming = Convert.ToDouble(FifoTableR.Rows[idrow][2].ToString());
                double ostatok_incoming = Math.Round((count_incoming - count_s_incoming),3);
                int id_incoming = Convert.ToInt32(FifoTableR.Rows[idrow][3].ToString());
                // Количество товара больше или равно свободному остатку в таблице прихода
                double CountFIFO = 0;
                if (count >= ostatok_incoming)
                {
                    CountFIFO=Math.Round(ostatok_incoming + count_s_incoming,3);
                    string txtSQLQueryUpdateIncomingR = "update incoming set count_s =" + Convert.ToString((CountFIFO)).Replace(',', '.') + ", status='1' where id =" + id_incoming + "";
                    //выполнение запроса внизу

                    string txtSQLQueryUpdateOutgoingR = "";
                    if (obem_spisania > 0)
                    {
                        CountFIFO = Math.Round(ostatok_incoming / obem_spisania, 3);
                    }
                    else
                    {
                        CountFIFO =ostatok_incoming;
                    }

                    txtSQLQueryUpdateOutgoingR = "insert into  Outgoing (kod_dbase,count,zcena,numberdock_mag,id_suppliers,date,id_incoming,numberdock_sup,date_dock_sup,users_bd) values ('" + kod + "'," + Convert.ToString(CountFIFO).Replace(',', '.') + "," + Convert.ToString(zcena).Replace(',', '.') + ",'" + numdok_magR + "'," + id_supR + ",'" + dateR + "'," + id_incoming + ",'" + numdock_sup + "','" + date_dock_sup + "'," + Sform.id_users + ")";
                    //выполнение запроса внизу

                  
                    
                    double Quantity=0;
                    string txtSQLQueryUpdateDbaseR= "";
                                         
                    Quantity = Math.Round((QTYDBASE - ostatok_incoming),3);
                    QTYDBASE = Quantity;
                    txtSQLQueryUpdateDbaseR = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + KODFIFO + "'";
                    //выполнение запроса внизу

                    _SQl.SQL_Query(txtSQLQueryUpdateIncomingR + ";" + txtSQLQueryUpdateOutgoingR + ";" + txtSQLQueryUpdateDbaseR + ";");
                    //_SQl.SQL_Query(txtSQLQueryUpdateOutgoingR);
                    //_SQl.SQL_Query(txtSQLQueryUpdateDbaseR);

                    count = Math.Round((count - ostatok_incoming),3);
                    if (count <= 0)
                    {
                        _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + KODFIFO + "'");
                        Thread.Sleep(200);
                        return;
                    }

                }
                else
                {
                    // Количество товара меньше свободного остатка в таблице прихода
                    CountFIFO = Math.Round((count + count_s_incoming), 3);
                    string txtSQLQueryUpdateIncomingR = "update  incoming set  count_s ='" + Convert.ToString(CountFIFO).Replace(',', '.') + "' where id =" + id_incoming + "";
                    //выполнение запроса внизу

                    string txtSQLQueryUpdateOutgoingR = "";
                    if (obem_spisania > 0)
                    {
                        CountFIFO = Math.Round(count / obem_spisania, 3);
                        
                    }
                    else
                    {
                        CountFIFO = count;
                    }
                    txtSQLQueryUpdateOutgoingR = "insert into  Outgoing (kod_dbase,count,zcena,numberdock_mag,id_suppliers,date,id_incoming,numberdock_sup,date_dock_sup,users_bd) values ('" + kod + "'," + Convert.ToString(CountFIFO).Replace(',', '.') + "," + Convert.ToString(zcena).Replace(',', '.') + ",'" + numdok_magR + "'," + id_supR + ",'" + dateR + "'," + id_incoming + ",'" + numdock_sup + "','" + date_dock_sup + "'," + Sform.id_users + ")";
                    //выполнение запроса внизу

                   
                    double Quantity = 0;
                    string txtSQLQueryUpdateDbaseR = "";
                    Quantity = Math.Round((QTYDBASE - count), 3);
                    QTYDBASE = Quantity;
                   
                    txtSQLQueryUpdateDbaseR = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + KODFIFO + "'";
                    //выполнение запроса внизу

                    _SQl.SQL_Query(txtSQLQueryUpdateIncomingR + ";" + txtSQLQueryUpdateOutgoingR + ";" + txtSQLQueryUpdateDbaseR + ";");
                    //_SQl.SQL_Query(txtSQLQueryUpdateOutgoingR);
                    //_SQl.SQL_Query(txtSQLQueryUpdateDbaseR);

                    count = Math.Round((count - ostatok_incoming),3);
                    if (count <= 0)
                    {
                        _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + KODFIFO + "'");
                        Thread.Sleep(200);
                        return;
                    }
                }
            }

            // Если нет свободного остатка (расход в минус!!!!!!!!!!!!!!!), а количество товара больше 0!!!!!
            if (count > 0)
            {

                string txtSQLQueryUpdateOutgoingR = "";
                double CountFIFOMinusR = 0;
                if (obem_spisania > 0)
                {
                    CountFIFOMinusR = Math.Round((count / obem_spisania), 3);
                }
                else
                {
                    CountFIFOMinusR = count;
                }
                txtSQLQueryUpdateOutgoingR = "insert into  Outgoing (kod_dbase,count,zcena,numberdock_mag,id_suppliers,date,id_incoming,numberdock_sup,date_dock_sup,users_bd) values ('" + kod + "'," + Convert.ToString(CountFIFOMinusR).Replace(',', '.') + "," + Convert.ToString(zcena).Replace(',', '.') + ",'" + numdok_magR + "'," + id_supR + ",'" + dateR + "',0,'" + numdock_sup + "','" + date_dock_sup + "'," + Sform.id_users + ")";
                //выполнение запроса внизу
               
                double Quantity = 0;
                string txtSQLQueryUpdateDbaseR = "";
                Quantity = Math.Round((QTYDBASE - count), 3);
                QTYDBASE = Quantity;

                txtSQLQueryUpdateDbaseR = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + KODFIFO + "'";

                _SQl.SQL_Query(txtSQLQueryUpdateOutgoingR + ";" + txtSQLQueryUpdateDbaseR + ";");
                
                //_SQl.SQL_Query(txtSQLQueryUpdateDbaseR);

                count = 0;
                FlagRashodMinus = 1;
                _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + KODFIFO + "'");
                Thread.Sleep(200);
           
            }
        
        
        }

        private void Rform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvR.RowCount > 0)
            {
                MessageBox.Show("В Расходной накладной, есть не сохраненные позиции, сохраните накладную!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                this.Focus();
                return;
            }

            if (e.CloseReason.ToString() == "UserClosing")
            {
                if (exitfrm != "func")
                {
                    DialogResult Close_form = MessageBox.Show("Вы действительно хотите закрыть окно ''Расходная накладная'' ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Close_form == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                    //else
                    //{
                    //    pref_dok_rashod = _SRC.pref_dok_rashod();
                    //    number_dok_rashod = _SRC.number_dok_rashod();
                    //    number_dok_rashod = number_dok_rashod-1;
                    //    int oldnumber_dok_rashod=Convert.ToInt32(lblRNumdokmag.Text.Remove(lblRNumdokmag.Text.IndexOf(pref_dok_rashod),pref_dok_rashod.Length));
                    //    if (number_dok_rashod == oldnumber_dok_rashod)
                    //    {
                    //        string Sqlnumber_dok_rashod = "update source set number_dok_rashod=" + number_dok_rashod + "";
                    //        _SQl.SQL_Query(Sqlnumber_dok_rashod);
                    //    }
                    //}

                }
            }
        }

        private void Rform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "FindTovarform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена

            // Запускаем форму если она не запущена
            Sform.ownerFormName = "Rform";
            Form FindTovarform = new FindTovarform();
            FindTovarform.StartPosition = FormStartPosition.CenterScreen;
            //FindTovarform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            FindTovarform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            FindTovarform.Show();
        }

        private void btnRefreshSup_Click(object sender, EventArgs e)
        {
            load_cmb_sup();
        }

        [Serializable]
        public class Rashod
        {
            public string Kod;
            public string NameT;
            public double Zcena;
            public double Count;
            public double Zsumm;
            public string PrivyazkaR;
            public double SpisanieR;
        }

      
        public void serRsave()
        {
            List<Rashod> ProfileList = new List<Rashod>();

                for (int i = 0; i < dgvR.Rows.Count; i++)
                {
                    DataGridViewRow _row = dgvR.Rows[i];

                    Rashod R = new Rashod();
                    if (_row.Cells[0].Value != null)
                        R.Kod = (string)_row.Cells[0].Value;

                    if (_row.Cells[1].Value != null)
                        R.NameT = (string)_row.Cells[1].Value;

                    if (_row.Cells[2].Value != null)
                        R.Zcena = (double)_row.Cells[2].Value;

                    if (_row.Cells[3].Value != null)
                        R.Count = (double)_row.Cells[3].Value;

                    if (_row.Cells[4].Value != null)
                        R.Zsumm = (double)_row.Cells[4].Value;

                    if (_row.Cells[5].Value != null)
                        R.PrivyazkaR = (string)_row.Cells[5].Value;

                    if (_row.Cells[6].Value != null)
                        R.SpisanieR = (double)_row.Cells[6].Value;

                    ProfileList.Add(R);
                }

                serializeTable.Save<List<Rashod>>(ProfileList, Application.StartupPath + "\\outcom.xml");
        }
        public void serRload()
        {
            List<Rashod> ProfileList = new List<Rashod>();
            ProfileList = serializeTable.Load<List<Rashod>>(Application.StartupPath + "\\outcom.xml");

            dgvR.Rows.Clear();

            foreach (Rashod R in ProfileList)
            {

                dgvR.Rows.Add(new object[] { R.Kod, R.NameT, R.Zcena, R.Count, R.Zsumm, R.PrivyazkaR, R.SpisanieR });
            }
        }

        private void tSMenuSelectAll_Click(object sender, EventArgs e)
        {
            dgvR.SelectAll();
        }

        private void tSMenuCopy_Click(object sender, EventArgs e)
        {
            DataObject dataObj = dgvR.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
        }

       

        private void txtRshtovar_TextChanged(object sender, EventArgs e)
        {
            txtRshtovar.Text = Regex.Replace(txtRshtovar.Text, "[^0-9]", string.Empty);
        }

        private void btnPrintCennik_Click(object sender, EventArgs e)
        {
            DataTable dtPrintVN = new DataTable();
            dtPrintVN.Clear();
            if (dtPrintVN.Columns.Count == 0)
            {
                dtPrintVN.Columns.Add("kod");
                dtPrintVN.Columns.Add("name");
                dtPrintVN.Columns.Add("zcena");
                dtPrintVN.Columns.Add("qty");

            }

            for (int i = 0; i < dgvR.Rows.Count; i++)
            {
                dtPrintVN.Rows.Add(dgvR.Rows[i].Cells[0].Value, dgvR.Rows[i].Cells[1].Value, dgvR.Rows[i].Cells[2].Value, dgvR.Rows[i].Cells[3].Value);
                
            }
            var pHelper = new PrintHelper(dtPrintVN);


            pHelper.PrintVN(lblRNumdokmag.Text, DateTime.Now.ToShortDateString());
        }
        private void ImportCount(string kod,double qty)
        {
            if (FlagImportError == 0)
            {
                int resultfind = 0;
                if (dgvR.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvR.Rows.Count - 1; i++)
                    {
                        if (dgvR.Rows[i].Cells[0].Value.ToString() == kod)
                        {
                            dgvR.Rows[i].Cells["Count"].Value = (Convert.ToDouble(dgvR.Rows[i].Cells["Count"].Value) - 1) + qty;
                            lbllinedokR.Text = dgvR.RowCount.ToString();
                            summ_rashod();
                            serRsave();
                            resultfind = 1;
                        }

                    }

                    if (resultfind == 0)
                    {
                        dgvR.Rows[dgvR.Rows.Count - 1].Cells["Count"].Value = (Convert.ToDouble(dgvR.Rows[dgvR.Rows.Count - 1].Cells["Count"].Value) - 1) + qty;
                        lbllinedokR.Text = dgvR.RowCount.ToString();
                        summ_rashod();
                        serRsave();
                    }
                }

            }
            FlagImportError = 0;
             
         
        

        }


        private void weight_goods(int PluCount, string EanWeight)
        {
            string PluKod = EanWeight.Substring(2, PluCount);
            string GoodsWeight = EanWeight.Substring(2 + PluCount, 5).Insert(2, ",");
            if (GoodsWeight.Remove(1) == "0")
            {
                GoodsWeight = GoodsWeight.Substring(1, 5);
            }
            DataTable PluKodtbl = _SQl.ExecuteSQL("select Kod,Name,Zcena,kod_osnova,obem_spisanie from dbase where plukod=" + PluKod + "");

            if (PluKodtbl.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string kod = PluKodtbl.Rows[0][0].ToString();
            string name = PluKodtbl.Rows[0][1].ToString();
            double zcena = Convert.ToDouble(PluKodtbl.Rows[0][2].ToString());
            double count = Convert.ToDouble(GoodsWeight);
            double zsumm = count * zcena;
            string kodosnova = PluKodtbl.Rows[0][3].ToString();
            double obem_spisanie = Convert.ToDouble(PluKodtbl.Rows[0][4].ToString());

            dgvR.Rows.Add(kod, name, zcena, count, zsumm, kodosnova, obem_spisanie);
           

            int resultfindkod = 0;
            if (dgvR.Rows.Count > 0)
            {
                for (int i = 0; i < dgvR.Rows.Count - 1; i++)
                {
                    if (dgvR.Rows[i].Cells[0].Value.ToString() == kod)
                    {
                        dgvR.Rows[i].Cells[3].Value = Convert.ToDouble(dgvR.Rows[i].Cells[3].Value.ToString()) + Convert.ToDouble(count);
                        dgvR.Rows.RemoveAt(dgvR.Rows.Count - 1);
                        dgvR.ClearSelection();
                        dgvR.Rows[i].Selected = true;
                        resultfindkod = 1;

                    }

                }
                if (resultfindkod == 0)
                {
                    dgvR.ClearSelection();
                    dgvR.Rows[Convert.ToInt32(dgvR.Rows.Count - 1)].Selected = true;

                }
            }
            txtRshtovar.Text = "";
            summ_rashod();
            serRsave();
        }
      
    }
}

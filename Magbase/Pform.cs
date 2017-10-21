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
    public partial class Pform : Form
    {
        sqldb _SQl = new sqldb();
        Source _SRC = new Source();
        public DataTable FindshkTable = new DataTable();
        public DataTable FindKodTable = new DataTable();
        public double margin_class;
        public double min_margin;
        public string exitfrm = "";
        
        private void Findshk()
        {

            string SqlShkfind = "select Kod,Name,Rcena,Zcena,(select margin_class from classt where id=id_class) as margin_class,(select min_margin from source) as min_margin,Quantity from Dbase where EAN like'%" + txtPshtovar.Text + "%'";
            FindshkTable = _SQl.ExecuteSQL(SqlShkfind);

            if (FindshkTable.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPshtovar.Focus();
                return;
            }
            if (FindshkTable.Rows.Count > 1)
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

                Data.Tovartbl = FindshkTable;
                // сделать форму с выводом позиций на одном штрихкоде
                Sform.ownerFormName="Pform";
                Form Viborform = new Viborform();
                Viborform.StartPosition = FormStartPosition.CenterScreen;
                //указываем владельца для формы
                // Viborform.MdiParent = this.MdiParent; // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Viborform.Owner = this;
                Viborform.Show();
                txtPshtovar.Text = "";

                return;


                // сделать форму с выводом позиций на одном штрихкоде
                //for (int i = 0; i < FindshkTable.Rows.Count; i++)
                //{
                //    MessageBox.Show(FindshkTable.Rows[i][0].ToString() + " " + FindshkTable.Rows[i][1].ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //} 

                //return;
            }

            lblKodtovara.Text = FindshkTable.Rows[0][0].ToString();
            lblnametovar.Text = FindshkTable.Rows[0][1].ToString();
            lblPoldzakup.Text = FindshkTable.Rows[0][3].ToString();
            txtProzn.Text = FindshkTable.Rows[0][2].ToString();
            margin_class = Convert.ToDouble(FindshkTable.Rows[0][4].ToString());
            min_margin = Convert.ToDouble(FindshkTable.Rows[0][5].ToString());
            txtPkol.Focus();

        }

        public void LoadPrihodkod(string kodtovara)
        {
            string SqlKodfind = "select Kod,Name,Rcena,Zcena,(select margin_class from classt where id=id_class) as margin_class,(select min_margin from source) as min_margin,Quantity from Dbase where kod='" + kodtovara + "'";
            FindKodTable = _SQl.ExecuteSQL(SqlKodfind);

            if (FindKodTable.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPshtovar.Focus();
                return;
            }
            if (FindKodTable.Rows.Count > 1)
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


                // сделать форму с выводом позиций на одном штрихкоде
                Form Viborform = new Viborform();
                Viborform.StartPosition = FormStartPosition.CenterScreen;
                //указываем владельца для формы
                // Viborform.MdiParent = this.MdiParent; // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Viborform.Owner = this;
                Viborform.Show();
                txtPshtovar.Text = "";
                //// сделать форму с выводом позиций на одном штрихкоде
                //for (int i = 0; i < FindKodTable.Rows.Count; i++)
                //{
                //    MessageBox.Show(FindKodTable.Rows[i][0].ToString() + " " + FindKodTable.Rows[i][1].ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

                return;
            }
            lblKodtovara.Text = FindKodTable.Rows[0][0].ToString();
            lblnametovar.Text = FindKodTable.Rows[0][1].ToString();
            lblPoldzakup.Text = FindKodTable.Rows[0][3].ToString();
            txtProzn.Text = FindKodTable.Rows[0][2].ToString();
            margin_class = Convert.ToDouble(FindKodTable.Rows[0][4].ToString());
            min_margin = Convert.ToDouble(FindKodTable.Rows[0][5].ToString());
            txtPkol.Focus();
        }

        public Pform()
        {
            CallBackMy.callbackEventHandlerPform = new CallBackMy.callbackEventPform(this.LoadPrihodkod);
            InitializeComponent();
            
            this.KeyUp += new KeyEventHandler(EnterKeyWait);
        }

        private void Pform_Load(object sender, EventArgs e)
        {

            dgvP.Columns.Add("Kod", "Код");
            dgvP.Columns.Add("Name", "Наименование");
            dgvP.Columns.Add("Zcena", "Цена закупки");
            dgvP.Columns.Add("Count", "Кол-во");
            dgvP.Columns.Add("Zsumm", "Сумма закупки");
            dgvP.Columns.Add("Rcena", "Розн. Цена");
            dgvP.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvP.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvP.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvP.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvP.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvP.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvP.Columns[0].ReadOnly = true;
            dgvP.Columns[1].ReadOnly = true;
            dgvP.Columns[2].ReadOnly = true;
            dgvP.Columns[3].ReadOnly = true;
            dgvP.Columns[4].ReadOnly = true;
            dgvP.Columns[5].ReadOnly = true;
            if (Sform.id_access == 1)
            {
                txtProzn.Enabled = false;
            }

            string pref_dok_prihod = _SRC.pref_dok_prihod();
            int number_dok_prihod = _SRC.number_dok_prihod();
            lblNumdokmag.Text = Convert.ToString(pref_dok_prihod + Convert.ToString(number_dok_prihod).PadLeft(6, '0'));

                       

            load_cmb_sup();
            if (File.Exists(Application.StartupPath + "\\incom.xml"))
            {
                serPload();
                summ_prihod();
            }

        }
        
        private void load_cmb_sup()
        {
            string SqlCmbLoad = "SELECT * FROM Suppliers order by name";
            DataTable CmbLoadTable = _SQl.ExecuteSQL(SqlCmbLoad);

            cmbSup.DataSource = CmbLoadTable;
            cmbSup.DisplayMember = "Name";
            cmbSup.ValueMember = "id";
            cmbSup.SelectedValue = 0;
        }

        private void EnterKeyWait(object sender, KeyEventArgs e)
        {
            // Если фокус в штрихкод то выполняе действия
            if (txtPshtovar.Focused == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPshtovar.Text == "")
                    {
                        txtPshtovar.Focus();
                        return;
                    }
                    Findshk();
                    txtPshtovar.Text = "";
                    
                }
            }
        }
        /// <summary>
        /// Блок отвечающий за наценку
        /// </summary>
        
        private void txtProzn_TextChanged(object sender, EventArgs e)
        {
            if (txtProzn.Text == "")
            {
                return;
            }

            double num;
            if (double.TryParse(txtProzn.Text, out num))
            {
                if (txtPsumm.Text != "")
                {
                    ///Процент наценки от новой закупочной цены
                    double newMargin = Math.Round(((Convert.ToDouble(txtProzn.Text) / Convert.ToDouble(lblPNewzakup.Text)) - 1) * 100, 2);
                    lblmargin.Text = newMargin.ToString();

                   

                    if (newMargin<margin_class)
                    {
                        lblmargin.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblmargin.ForeColor = Color.Green;
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProzn.Text = "";
            }
        }
        
        private void txtPkol_TextChanged(object sender, EventArgs e)
        {
            if (txtPkol.Text == "")
            {
                return;
            }

            double num;
            if (double.TryParse(txtPkol.Text, out num))
            {
                txtPsumm.Text = Convert.ToString(Convert.ToDouble(txtPkol.Text) * Convert.ToDouble(lblPoldzakup.Text));
            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPkol.Text = "";
            }


        }
            
        private void txtPsumm_TextChanged(object sender, EventArgs e)
        {

            if (txtPsumm.Text == "")
            {
                return;
            }
            if (txtPkol.Text == "")
            {
                return;
            }

            double num;
            if (double.TryParse(txtPsumm.Text, out num))
            {
              
                lblPNewzakup.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtPsumm.Text) / Convert.ToDouble(txtPkol.Text), 2));
                //// Проверка минимальной наценки для новых товаров
                //для штрихкода для кода товара
                if (FindKodTable.Rows.Count != 0)
                {
                    if (FindKodTable.Rows[0][2].ToString() == "0")
                    {
                        txtProzn.Text = Convert.ToString(Math.Ceiling(((Convert.ToDouble(lblPNewzakup.Text) * min_margin) / 100) + Convert.ToDouble(lblPNewzakup.Text)));
                    }

                }

                //для штрихкода
                if (FindshkTable.Rows.Count != 0)
                {
                    if (FindshkTable.Rows[0][2].ToString() == "0")
                    {
                        txtProzn.Text = Convert.ToString(Math.Ceiling(((Convert.ToDouble(lblPNewzakup.Text) * min_margin) / 100) + Convert.ToDouble(lblPNewzakup.Text)));
                    }
                }
                ///Процент наценки от новой закупочной цены
                if (txtProzn.Text != "")
                {
                    //double oldMargin = Math.Round(((Convert.ToDouble(txtProzn.Text) / Convert.ToDouble(lblPoldzakup.Text)) - 1) * 100, 2);
                    double newMargin = Math.Round(((Convert.ToDouble(txtProzn.Text) / Convert.ToDouble(lblPNewzakup.Text)) - 1) * 100, 2);
                                      
                    lblmargin.Text = newMargin.ToString();

                    if (newMargin < margin_class)
                    {
                        lblmargin.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblmargin.ForeColor = Color.Green;
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error );
                txtPsumm.Text = "";
            }


        }

        private void lblPNewzakup_TextChanged(object sender, EventArgs e)
        {

            ////проверка изменения закупочной цены
            double newZakup = Convert.ToDouble(lblPNewzakup.Text);
            double oldZakup = Convert.ToDouble(lblPoldzakup.Text);
            

            if (newZakup != oldZakup)
            {
                timerZakup.Enabled = true;
                timerZakup.Interval = 1000;
                //lblPNewzakup.ForeColor = Color.Red;
            }
            else
            {
                timerZakup.Enabled = false;
                lblPNewzakup.ForeColor = Color.Green;
            }
     
            
            ////проверка минимальной наценки
            //double newZakup = Convert.ToDouble(lblPNewzakup.Text);
            //double Prozn = Convert.ToDouble(txtProzn.Text);
            //double PnewRozn=Math.Ceiling(((newZakup * Sform.min_margin) / 100) + newZakup);

            //if (PnewRozn > Prozn)
            //{
            //    DialogResult changeProzn = MessageBox.Show("Наценка меньше минимальной, изменить розничную цену на ''" + PnewRozn.ToString() + "'' ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (changeProzn == DialogResult.No)
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        txtProzn.Text = PnewRozn.ToString();
            //    }
            //}

        }
           
       
        private void btnaddtovar_Click(object sender, EventArgs e)
        {
            if (lblnametovar.Text == "")
            {
                MessageBox.Show("Товар не выбран!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPshtovar.Focus();
                return;
            }
            if (txtPkol.Text == "")
            {
                MessageBox.Show("Заполните поле количество!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPkol.Focus();
                return;
            }
            if (txtPsumm.Text == "")
            {
                MessageBox.Show("Заполните поле сумма!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPsumm.Focus();
                return;
            }
            if (txtProzn.Text == "")
            {
                MessageBox.Show("Заполните поле Розничная цена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProzn.Focus();
                return;
            }

            //проверка наценки на классах товара
            
            double ProznNew=0;
            if (margin_class > 0)
            {
                if (margin_class > Convert.ToDouble(lblmargin.Text))
                {
                    ProznNew = Math.Ceiling(((Convert.ToDouble(lblPNewzakup.Text) * margin_class) / 100) + Convert.ToDouble(lblPNewzakup.Text));
                    DialogResult changeProzn = MessageBox.Show("Наценка меньше минимальной" + Environment.NewLine + "установленной в ''Классификаторе'' товара," + Environment.NewLine + "изменить розничную цену с" + Environment.NewLine + "''"+ txtProzn.Text+ "''" + Environment.NewLine + "на" + Environment.NewLine + "''" + ProznNew + "'' ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (changeProzn == DialogResult.Yes)
                    {
                        txtProzn.Text = ProznNew.ToString();
                    }
                }
            }
            else
            {
                
                ProznNew = Math.Ceiling(((Convert.ToDouble(lblPNewzakup.Text) * min_margin) / 100) + Convert.ToDouble(lblPNewzakup.Text));
                DialogResult changeProzn = MessageBox.Show("В ''Классификаторе'' товара не установлена минимальная наценка!" + Environment.NewLine + "Изменить Розничную цену с" + Environment.NewLine + "''" + txtProzn.Text + "''" + Environment.NewLine + "на" + Environment.NewLine + "''" + ProznNew + "''", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (changeProzn == DialogResult.Yes)
                {
                      txtProzn.Text = ProznNew.ToString();
                }
                
                  
            }
            //---------------------------------
            timerZakup.Enabled = false;
            dgvP.Rows.Add(lblKodtovara.Text, lblnametovar.Text, Convert.ToDouble(lblPNewzakup.Text), Convert.ToDouble(txtPkol.Text), Convert.ToDouble(txtPsumm.Text), Convert.ToDouble(txtProzn.Text));
            lbllinedok.Text = dgvP.Rows.Count.ToString();

            lblKodtovara.Text = "";
            lblnametovar.Text = "";
            lblPoldzakup.Text = "0";
            lblPNewzakup.Text = "0";
            lblmargin.Text = "0";
            txtPkol.Text = "";
            txtPsumm.Text = "";
            txtProzn.Text = "";
            
            summ_prihod();
            serPsave();
            txtPshtovar.Focus();

        }
        
        private void btnDelP_Click(object sender, EventArgs e)
        {
            int l = dgvP.RowCount;
            if (l == 0)
            {
                MessageBox.Show("Накладная пустая!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPshtovar.Focus();
                return;
            }
            int i = dgvP.CurrentRow.Index;
            dgvP.Rows.RemoveAt(i);
            lbllinedok.Text = dgvP.Rows.Count.ToString();
            summ_prihod();
            serPsave();

        }

        private void bntSaveP_Click(object sender, EventArgs e)
        {
            int l = dgvP.RowCount;
            if (l == 0)
            {
                MessageBox.Show("Накладная пустая!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPshtovar.Focus();
                return;
            }

            if (cmbSup.Text == "")
            {
                MessageBox.Show("Выберите Поставщика!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSup.Focus();
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



            DialogResult saveprih = MessageBox.Show("Сохранить накладную?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (saveprih == DialogResult.No)
            {
                return;
            }
            else
            {
                // Проверка на уникальность номера документа
                string SqlqueryNumberDock = "Select numberdock_mag From Incoming Where numberdock_mag='"+lblNumdokmag.Text+"'";
                DataTable NumDock=_SQl.ExecuteSQL(SqlqueryNumberDock);


                for (int i = 0; i < dgvP.Rows.Count; i++)
                {
                    //набор данных с датагрида
                    string Kod = dgvP.Rows[i].Cells[0].Value.ToString();
                    string Name = dgvP.Rows[i].Cells[1].Value.ToString();
                    double Rcena = Convert.ToDouble(dgvP.Rows[i].Cells[5].Value.ToString());
                    double Count = Convert.ToDouble(dgvP.Rows[i].Cells[3].Value.ToString());
                    double Summ = Convert.ToDouble(dgvP.Rows[i].Cells[4].Value.ToString());
                    double Zcena = Convert.ToDouble(dgvP.Rows[i].Cells[2].Value.ToString());
                    DateTime date1 = DateTime.Now;
                    string datedok = date1.ToString("u").Remove(19);
                    //функция сохранения прихода

                    saveprihod(Kod, Count, Rcena, Zcena, datedok);

                }


                while (dgvP.Rows.Count != 0)
                {
                    dgvP.Rows.Remove(dgvP.Rows[dgvP.Rows.Count - 1]);
                }

                txtDokSup.Text = "";
                msktxtDateDok.Text = "";
                txtPkol.Text = "";
                txtPsumm.Text = "";
                txtProzn.Text = "";
                lblSummPrihod.Text = "0";
                
                exitfrm = "func";
                List<Prihod> ProfileList = new List<Prihod>();
                serializeTable.Save<List<Prihod>>(ProfileList, "incom.xml");
                this.Close();

                //txtPshtovar.Focus();
            }

        }
        //private void saveprihod(string Kod, double Count, double Rcena, double Zcena, string datedok)
        //{
        //    this.Cursor = Cursors.WaitCursor;

        //    double count_s = 0;
        //    int status_dock = 0;

        //    string SqlSelectQuantity = "select Quantity from Dbase where Kod='" + Kod + "'";
        //    DataTable saveprihodTable = _SQl.ExecuteSQL(SqlSelectQuantity);

        //    double Quantity = Convert.ToDouble(saveprihodTable.Rows[0][0].ToString());
        //    if (Quantity < 0)
        //    {
        //        if (Math.Round((Quantity + Count), 3) >= 0)
        //        {
        //            count_s = Math.Round((Count - (Quantity + Count)), 3);

        //            if (count_s == Count)
        //            {
        //                status_dock = 1;
        //            }
        //        }
        //        else
        //        {
        //            count_s = Count;
        //            status_dock = 1;
        //        }
        //    }
        //    Quantity = Math.Round((Quantity + Count), 3);

        //    string txtStxtSQLQuerySaveprihodBase = "update  Dbase set  Quantity =" + Convert.ToString(Quantity).Replace(',', '.') + ",Zcena =" + Convert.ToString(Zcena).Replace(',', '.') + ",Rcena =" + Convert.ToString(Rcena).Replace(',', '.') + " where Kod ='" + Kod + "'";
        //    _SQl.SQL_Query(txtStxtSQLQuerySaveprihodBase);

        //    string SQLQuerySaveprihod = "insert into  Incoming (kod_dbase,count,count_s,zcena,numberdock_mag,id_suppliers,status,datedok,date,numberdock_sup,rcena,users_bd) values ('" + Kod + "'," + Convert.ToString(Count).Replace(',', '.') + "," + count_s.ToString().Replace(',', '.') + "," + Convert.ToString(Zcena).Replace(',', '.') + ",'" + lblNumdokmag.Text + "'," + cmbSup.SelectedValue + "," + status_dock + ",'" + msktxtDateDok.Text + "','" + datedok + "','" + txtDokSup.Text + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Sform.id_users + ")";
        //    _SQl.SQL_Query(SQLQuerySaveprihod);

        //    this.Cursor = Cursors.Default;
        //}
        private void saveprihod(string Kod, double Count, double Rcena, double Zcena, string datedok)
        {
            this.Cursor = Cursors.WaitCursor;
            //Блокируем код товара всем потокам для работы с ним по всем запросам 
            while (true)
            {
                _SQl.SQL_Query("INSERT INTO BlockT (kod_dbase) Values('" + Kod + "')");
                if (_SQl.uniqBlockT == 0 && _SQl.sql_con.State.ToString() == "Closed")
                {
                    break;
                }
                Thread.Sleep(500);
            }

            double count_s = 0;
            int status_dock = 0;

            string SqlSelectQuantity = "select Quantity from Dbase where Kod='" + Kod + "'";
            DataTable saveprihodTable = _SQl.ExecuteSQL(SqlSelectQuantity);

            double Quantity =  Math.Round(Convert.ToDouble(saveprihodTable.Rows[0][0].ToString()),3);
            if (Quantity < 0)
            {
                if (Math.Round((Quantity + Count), 3) >= 0)
                {
                    count_s = Math.Round((Count - (Quantity + Count)), 3);

                    if (count_s == Count)
                    {
                        status_dock = 1;
                    }
                }
                else
                {
                    count_s = Count;
                    status_dock = 1;
                }
            }
            Quantity = Math.Round((Quantity + Count), 3);

            string txtStxtSQLQuerySaveprihodBase = "update  Dbase set  Quantity =" + Convert.ToString(Quantity).Replace(',', '.') + ",Zcena =" + Convert.ToString(Zcena).Replace(',', '.') + ",Rcena =" + Convert.ToString(Rcena).Replace(',', '.') + " where Kod ='" + Kod + "'";
            

            string SQLQuerySaveprihod = "insert into  Incoming (kod_dbase,count,count_s,zcena,numberdock_mag,id_suppliers,status,datedok,date,numberdock_sup,rcena,users_bd) values ('" + Kod + "'," + Convert.ToString(Count).Replace(',', '.') + "," + count_s.ToString().Replace(',', '.') + "," + Convert.ToString(Zcena).Replace(',', '.') + ",'" + lblNumdokmag.Text + "'," + cmbSup.SelectedValue + "," + status_dock + ",'" + msktxtDateDok.Text + "','" + datedok + "','" + txtDokSup.Text + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Sform.id_users + ")";
            //_SQl.SQL_Query(txtStxtSQLQuerySaveprihodBase);
            _SQl.SQL_Query(SQLQuerySaveprihod + ";" + txtStxtSQLQuerySaveprihodBase+";");
            _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + Kod + "'");
            Thread.Sleep(200);
            this.Cursor = Cursors.Default;
        }
        
        private void summ_prihod()
        {
            lblSummPrihod.Text = "0";
            for (int i = 0; i < dgvP.Rows.Count; i++)
            {
                //dgvP.Rows[i].Cells["Zsumm"].Value = Convert.ToDouble(dgvP.Rows[i].Cells["Zcena"].Value) * Convert.ToDouble(dgvP.Rows[i].Cells["Count"].Value);
                lblSummPrihod.Text = Convert.ToString(Convert.ToDouble(dgvP.Rows[i].Cells["Zsumm"].Value) + Convert.ToDouble(lblSummPrihod.Text));

            }
            txtPshtovar.Focus();
        }

        private void txtPkodtovar_TextChanged(object sender, EventArgs e)
        {
            txtPkodtovar.Text = Regex.Replace(txtPkodtovar.Text, "[^0-9]", string.Empty);
            if (txtPkodtovar.TextLength == 6)
            {

                string pref_kod = _SRC.pref_kod();
                string kodtovara = pref_kod + txtPkodtovar.Text;

                LoadPrihodkod(kodtovara);
                txtPkodtovar.Text = "";
                txtPkol.Focus();
            }
        }

        private void Pform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvP.RowCount > 0)
            {
                MessageBox.Show("В Приходной накладной, есть не сохраненные позиции, сохраните накладную!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                this.Focus();
                return;
            }


            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (exitfrm != "func")
                {
                    DialogResult Close_form = MessageBox.Show("Вы действительно хотите закрыть окно ''Приходная накладная'' ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Close_form == DialogResult.No)
                    {
                        e.Cancel = true;

                        return;
                    }
                    //else
                    //{

                    //    string pref_dok_prihod = _SRC.pref_dok_prihod();
                    //    int number_dok_prihod = _SRC.number_dok_prihod();
                    //    number_dok_prihod = number_dok_prihod - 1;
                    //    int oldnumber_dok_prihod = Convert.ToInt32(lblNumdokmag.Text.Remove(lblNumdokmag.Text.IndexOf(pref_dok_prihod), pref_dok_prihod.Length));
                    //    if (number_dok_prihod == oldnumber_dok_prihod)
                    //    {
                    //        string Sqlnumber_dok_rashod = "update source set number_dok_prihod=" + number_dok_prihod + "";
                    //        _SQl.SQL_Query(Sqlnumber_dok_rashod);
                    //    }
                    //}
                }
            }
        }

        private void Pform_KeyDown(object sender, KeyEventArgs e)
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
            Sform.ownerFormName = "Pform";
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

        private void timerZakup_Tick(object sender, EventArgs e)
        {
            if (lblPNewzakup.ForeColor == Color.Red)
            {
                lblPNewzakup.ForeColor = Color.Green;
            }
            else
            {
                lblPNewzakup.ForeColor = Color.Red;
            }
        }
        [Serializable]
        public class Prihod
        {
            public string Kod;
            public string NameT;
            public double Zcena;
            public double Count;
            public double Zsumm;
            public double Rcena;
            
        }
        
        public void serPsave()
        {
            List<Prihod> ProfileList = new List<Prihod>();

            for (int i = 0; i < dgvP.Rows.Count; i++)
            {
                DataGridViewRow _row = dgvP.Rows[i];

                Prihod P = new Prihod();
                if (_row.Cells[0].Value != null)
                    P.Kod = (string)_row.Cells[0].Value;

                if (_row.Cells[1].Value != null)
                    P.NameT = (string)_row.Cells[1].Value;

                if (_row.Cells[2].Value != null)
                    P.Zcena = (double)_row.Cells[2].Value;

                if (_row.Cells[3].Value != null)
                    P.Count = (double)_row.Cells[3].Value;

                if (_row.Cells[4].Value != null)
                    P.Zsumm = (double)_row.Cells[4].Value;

                if (_row.Cells[5].Value != null)
                    P.Rcena = (double)_row.Cells[5].Value;

                ProfileList.Add(P);
            }

            serializeTable.Save<List<Prihod>>(ProfileList, Application.StartupPath + "\\incom.xml");
        }
        
        public void serPload()
        {
            List<Prihod> ProfileList = new List<Prihod>();
            ProfileList = serializeTable.Load<List<Prihod>>(Application.StartupPath + "\\incom.xml");

            dgvP.Rows.Clear();

            foreach (Prihod P in ProfileList)
            {

                dgvP.Rows.Add(new object[] { P.Kod, P.NameT, P.Zcena, P.Count, P.Zsumm, P.Rcena });
            }
        }

        private void tSMenuSelectAll_Click(object sender, EventArgs e)
        {
            dgvP.SelectAll();
        }

        private void tSMenuCopy_Click(object sender, EventArgs e)
        {
            DataObject dataObj = dgvP.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
        }

       

        private void txtPshtovar_TextChanged(object sender, EventArgs e)
        {
            txtPshtovar.Text = Regex.Replace(txtPshtovar.Text, "[^0-9]", string.Empty);
        }

        

    }
}

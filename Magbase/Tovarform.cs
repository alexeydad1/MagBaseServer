using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MagbaseServer
{
    public partial class Tovarform : Form
    {
        sqldb _SQl = new sqldb();
        Source _SRC = new Source();
        public int countRepl = 0;
        public DataTable TovarSHKprint = new DataTable("TableSHK");
        public int i12=0;
        public string pref_kod = "";
        public int kod_mag;
        public int FlagNewTovar=0;

        public Tovarform()
        {
            InitializeComponent();

        }
        private void load_cmb()
        {
            DataTable DTtcmbclass=_SQl.ExecuteSQL("SELECT * FROM Classt order by name");
            cmbclass.DisplayMember = "name";
            cmbclass.ValueMember = "id";
            cmbclass.DataSource = DTtcmbclass;
            cmbclass.Text = "";


            DataTable DTtcmbbrand = _SQl.ExecuteSQL("SELECT * FROM Brand order by name");
            cmbbrand.DisplayMember = "name";
            cmbbrand.ValueMember = "id";
            cmbbrand.DataSource = DTtcmbbrand;
            cmbbrand.Text = "";

            DataTable DTtcmbgroup = _SQl.ExecuteSQL("SELECT * FROM Groupt order by name");
            cmbgroup.DisplayMember = "name";
            cmbgroup.ValueMember = "id";
            cmbgroup.DataSource = DTtcmbgroup;
            cmbgroup.Text = "";

            DataTable DTtcmbsup = _SQl.ExecuteSQL("SELECT * FROM Suppliers order by name"); 
            cmbsuppliers.DisplayMember = "name";
            cmbsuppliers.ValueMember = "id";
            cmbsuppliers.DataSource = DTtcmbsup;
            cmbsuppliers.Text = "";

            this.cmbclass.SelectedValue = 0;
            this.cmbbrand.SelectedValue = 0;
            this.cmbgroup.SelectedValue = 0;
            this.cmbsuppliers.SelectedValue = 0;
 
        }

        private void Tovarform_Load(object sender, EventArgs e)
        {
            load_spravochnik_tovaarov();

            TovarSHKprint.Columns.Add("Код");
            TovarSHKprint.Columns.Add("Наименование");
            TovarSHKprint.Columns.Add("Цена");
            TovarSHKprint.Columns.Add("Штрихкод");

        }
        public void load_spravochnik_tovaarov()
        {
            
            cmbsuppliers.Enabled = false;
            cmbgroup.Enabled = false;
            cmbbrand.Enabled = false;
            cmbclass.Enabled = false;

            this.Cursor = Cursors.WaitCursor;
            trvgroup.Nodes.Clear();
            DataTable DTctovar = _SQl.ExecuteSQL("SELECT * FROM Groupt order by name"); 
            
            trvgroup.BeginUpdate();
            trvgroup.Nodes.Add("Товары");

            for (int i = 0; i < DTctovar.Rows.Count; i++)
            {
                trvgroup.Nodes[0].Nodes.Add(DTctovar.Rows[i][0].ToString(), DTctovar.Rows[i][1].ToString(), 0,1);
                
               //trvgroup.Nodes[0].Nodes.Add(new TreeNode(DTctovar.Rows[i][1].ToString()));

            }

            DataTable DTctovar1 = _SQl.ExecuteSQL("SELECT name,id_group,kod FROM dbase");
            
            for (int l = 0; l < DTctovar1.Rows.Count; l++)
            {
                //int id = Convert.ToInt16(DTctovar1.Rows[l][1].ToString());
                //if (id == 0)
                //{
                //    id = 1;
                //}
                //else
                //{
                //    id = Convert.ToInt16(DTctovar1.Rows[l][1].ToString()) - 1;
                //}
                int id=0;
                string keynode = DTctovar1.Rows[l][1].ToString();
                foreach (TreeNode tn in trvgroup.Nodes)
                {
                    id = tn.Nodes.IndexOfKey(keynode);
                    if (id > 0)
                    {
                        break;
                    }
                }



                
                 
                trvgroup.Nodes[0].Nodes[id].Nodes.Add(DTctovar1.Rows[l][2].ToString(), DTctovar1.Rows[l][2].ToString() + " -- " + DTctovar1.Rows[l][0].ToString(), 2, 2);
                //trvgroup.Nodes[0].Nodes[id].Nodes.Add(new TreeNode(DTctovar1.Rows[l][2].ToString() + " -- " + DTctovar1.Rows[l][0].ToString()));
                
            }
            
            for (int id_groupt = 0; id_groupt < DTctovar.Rows.Count; id_groupt++)
            {
                string countTgrp = trvgroup.Nodes[0].Nodes[id_groupt].GetNodeCount(true).ToString();
                trvgroup.Nodes[0].Nodes[id_groupt].Text = trvgroup.Nodes[0].Nodes[id_groupt].Text + " (" + countTgrp + ")";
            }
           
            //trvgroup.Nodes[0].Text =trvgroup.Nodes[0].Text+"(" + Convert.ToString(trvgroup.GetNodeCount(true)) + ")";
            trvgroup.EndUpdate();

            load_cmb();
            txtname.Enabled = false;
            txtrcena.Enabled = false;
            txtzcena.Enabled = false;
            txtKodOsnova.Enabled = false;
            txtObemSpisania.Enabled = false;
            txtPLUkod.Enabled = false;
            txtLifeGoods.Enabled = false;

            this.Cursor = Cursors.Default;
        }

        private void trvgroup_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.cmbclass.Enabled = false;
            this.cmbbrand.Enabled = false;
            this.cmbgroup.Enabled = false;
            this.cmbsuppliers.Enabled = false;
            this.txtname.Enabled = false;
            this.txtzcena.Enabled = false;
            this.txtrcena.Enabled = false;
            this.lstboxean.Enabled = false;
            this.btnaddean.Enabled = false;
            this.btncancel.Enabled = false;
            this.btndelean.Enabled = false;
            this.btnsavetovar.Enabled = false;
            this.btndelean.Enabled = false;
            this.btnAddPlu.Enabled = false;
            this.txtObemSpisania.Enabled = false;
            this.txtPLUkod.Enabled = false;
            this.txtLifeGoods.Enabled = false;
            
            
            
            this.lblkod.Text = "";
            this.lblname.Text = "";
            this.cmbclass.SelectedValue = 0;
            this.cmbbrand.SelectedValue = 0;
            this.cmbgroup.SelectedValue = 0;
            this.cmbsuppliers.SelectedValue = 0;
            this.txtname.Text = "";
            this.txtzcena.Text = "";
            this.txtrcena.Text = "";
            this.lblquanity.Text = "";
            this.lstboxean.Items.Clear();
            this.txtKodOsnova.Text = "";
            this.txtObemSpisania.Text = "";
            this.txtPLUkod.Text = "";
            this.txtLifeGoods.Text = "";

            int findSep= e.Node.Text.IndexOf('-');
            if (findSep > 0)
            {
                string kodNode = e.Node.Text.Remove((e.Node.Text.IndexOf('-') - 1), e.Node.Text.Length - (e.Node.Text.IndexOf('-') - 1));
                DataTable DTcltovar = _SQl.ExecuteSQL("SELECT * FROM dbase Where kod='" + kodNode + "'");

                if (DTcltovar.Rows.Count > 0) //проверка на пустой запрос
                {
                    lblkod.Text = DTcltovar.Rows[0][0].ToString();
                    lblname.Text = DTcltovar.Rows[0][1].ToString();
                    txtKodOsnova.Text = DTcltovar.Rows[0][10].ToString();
                    txtObemSpisania.Text = DTcltovar.Rows[0][11].ToString();
                    txtPLUkod.Text = DTcltovar.Rows[0][12].ToString();
                    txtLifeGoods.Text = DTcltovar.Rows[0][13].ToString();
                    if (txtPLUkod.Text == "")
                    {
                        txtPLUkod.Text = "0";
                    }
                    if (txtLifeGoods.Text == "")
                    {
                        txtLifeGoods.Text = "0";
                    }

                    int ind_class = Convert.ToInt32(DTcltovar.Rows[0][6].ToString());
                    this.cmbclass.SelectedValue = ind_class;

                    int ind_brand = Convert.ToInt32(DTcltovar.Rows[0][7].ToString());
                    this.cmbbrand.SelectedValue = ind_brand;

                    int ind_group = Convert.ToInt32(DTcltovar.Rows[0][5].ToString());
                    this.cmbgroup.SelectedValue = ind_group;

                    int ind_sup = Convert.ToInt32(DTcltovar.Rows[0][8].ToString());
                    this.cmbsuppliers.SelectedValue = ind_sup;

                    txtname.Text = lblname.Text.Remove(0, (lblname.Text.IndexOf(cmbbrand.Text) + cmbbrand.Text.Length + 1));
                    txtzcena.Text = DTcltovar.Rows[0][3].ToString();
                    txtrcena.Text = DTcltovar.Rows[0][4].ToString();
                    lblquanity.Text = DTcltovar.Rows[0][2].ToString();

                    string ean = DTcltovar.Rows[0][9].ToString();
                    if (ean.Length <= 13 & ean != " ")
                    {
                        lstboxean.Items.Add(ean);
                    }
                    else
                    {
                        while (ean != "")
                        {
                            int posEan = ean.IndexOf(" ");
                            if (posEan > -1)
                            {
                                string ean13 = ean.Remove(posEan, (ean.Length - posEan));
                                lstboxean.Items.Add(ean13);
                                ean = ean.Remove(0, (posEan + 1));
                                int posEanlast = ean.IndexOf(" ");

                                if (posEanlast < 0)
                                {
                                    if (posEanlast == -1 & ean.Trim() == "")
                                    {
                                        ean = "";
                                    }
                                    else
                                    {
                                        lstboxean.Items.Add(ean.Trim());
                                        ean = "";
                                    }
                                }


                            }
                        }
                    }

                }
            }
        }

        private void tsbtnchange_Click(object sender, EventArgs e)
        {
            if (lblkod.Text != "")
            {
                this.cmbclass.Enabled = true;
                this.cmbbrand.Enabled = true;
                this.cmbgroup.Enabled = true;
                this.cmbsuppliers.Enabled = true;
                this.txtname.Enabled = true;
                if (Sform.id_access == 1)
                {
                    this.txtzcena.Enabled = false;
                    this.txtrcena.Enabled = false;
                }
                else
                {
                    this.txtzcena.Enabled = true;
                    this.txtrcena.Enabled = true;
                }
                
                this.lstboxean.Enabled = true;
                this.btnaddean.Enabled = true;
                this.btncancel.Enabled = true;
                this.btndelean.Enabled = true;
                this.btnsavetovar.Enabled = true;
                this.btnAddPlu.Enabled = true;
                this.txtKodOsnova.Enabled = true;
                this.txtObemSpisania.Enabled = true;
                this.txtPLUkod.Enabled = true;
                this.txtLifeGoods.Enabled = true;
                FlagNewTovar = 0;
                this.cmbclass.Focus();
                
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //int oldKod_mag = _SRC.kod_mag();
            //oldKod_mag = oldKod_mag - 1;
            //pref_kod = _SRC.pref_kod();
            //string kodNow = lblkod.Text;
            //kodNow = kodNow.Remove(kodNow.IndexOf(pref_kod), pref_kod.Length);
            //if (kodNow == oldKod_mag.ToString().PadLeft(6,'0'))
            //{
            //    string SqlUpdateKodmag = "Update  Source Set  kod_mag =" + oldKod_mag + "";
            //    _SQl.SQL_Query(SqlUpdateKodmag);
            //}

            this.cmbclass.Enabled = false;
            this.cmbbrand.Enabled = false;
            this.cmbgroup.Enabled = false;
            this.cmbsuppliers.Enabled = false;
            this.txtname.Enabled = false;
            this.txtzcena.Enabled = false;
            this.txtrcena.Enabled = false;
            this.lstboxean.Enabled = false;
            this.btnaddean.Enabled = false;
            this.btncancel.Enabled = false;
            this.btndelean.Enabled = false;
            this.btnsavetovar.Enabled = false;
            this.btnAddPlu.Enabled = false;
            this.txtKodOsnova.Enabled = false;
            this.txtObemSpisania.Enabled = false;
            this.txtPLUkod.Enabled = false;
            this.txtLifeGoods.Enabled = false;

            this.lblkod.Text = "";
            this.lblname.Text = "";
            this.cmbclass.SelectedValue = 0;
            this.cmbbrand.SelectedValue = 0;
            this.cmbgroup.SelectedValue = 0;
            this.cmbsuppliers.SelectedValue = 0;
            this.txtname.Text = "";
            this.txtzcena.Text = "";
            this.txtrcena.Text = "";
            this.lblquanity.Text = "";
            this.txtKodOsnova.Text = "";
            this.txtObemSpisania.Text = "";
            this.txtPLUkod.Text = "";
            this.txtLifeGoods.Text = "";
            this.lstboxean.Items.Clear();

           
            FlagNewTovar = 0;
        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbclass.Enabled == true)
            {
                lblname.Text = cmbclass.Text + " " + cmbbrand.Text + " " + txtname.Text;
            }
        }

        private void cmbbrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbrand.Enabled == true)
            {
                lblname.Text = cmbclass.Text + " " + cmbbrand.Text + " " + txtname.Text;
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (txtname.Enabled == true)
            {
                lblname.Text = cmbclass.Text + " " + cmbbrand.Text + " " + txtname.Text;
            }
        }

        private void btnsavetovar_Click(object sender, EventArgs e)
        {
 //проверка заполненности полей--------------------------
            foreach (Control ctrl in this.Controls)
            {
              TextBox tb = ctrl as TextBox;
              if ( tb != null )
              {
                  if (string.IsNullOrEmpty(tb.Text))
                  {
                      MessageBox.Show("Не заполненно поле " + tb.Tag.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      tb.Focus();
                      return;
                  }
              }
              ComboBox cmb = ctrl as ComboBox;
              if (cmb != null)
              {
                  if (string.IsNullOrEmpty(cmb.Text))
                  {
                      MessageBox.Show("Не заполненно поле " + cmb.Tag.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      cmb.Focus();
                      return;
                  }
              }
             
            }
            
            if (lstboxean.Items.Count >= 1)
            {
                if (lstboxean.Items[0].ToString() == "")
                {
                    MessageBox.Show("Не заполненно поле " + lstboxean.Tag.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstboxean.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не заполненно поле " + lstboxean.Tag.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstboxean.Focus();
                return;

            }

//проверка закончена-----------------                       
            cmbclass.Enabled = false;
            cmbbrand.Enabled = false;
            txtname.Enabled = false;
            cmbgroup.Enabled = false;
            cmbsuppliers.Enabled = false;
            txtzcena.Enabled = false;
            txtrcena.Enabled = false;
            lstboxean.Enabled = false;
            btnaddean.Enabled = false;
            btncancel.Enabled = false;
            btndelean.Enabled = false;
            btnsavetovar.Enabled = false;
            btnAddPlu.Enabled = false;
            txtKodOsnova.Enabled = false;
            txtObemSpisania.Enabled = false;
            txtPLUkod.Enabled = false;
            txtLifeGoods.Enabled = false;

            
            if (FlagNewTovar==1)
            {
                save_new_tovar();
                FlagNewTovar = 0;
            }
            else
            {
                save_tovar();
            }

            this.lblkod.Text = "";
            this.lblname.Text = "";
            this.cmbclass.SelectedValue = 0;
            this.cmbbrand.SelectedValue = 0;
            this.cmbgroup.SelectedValue = 0;
            this.cmbsuppliers.SelectedValue = 0;
            this.txtname.Text = "";
            this.txtzcena.Text = "";
            this.txtrcena.Text = "";
            this.lblquanity.Text = "";
            this.lstboxean.Items.Clear();
            this.txtKodOsnova.Text = "";
            this.txtObemSpisania.Text = "";
            this.txtPLUkod.Text = "";
            this.txtLifeGoods.Text = "";
                        
            load_spravochnik_tovaarov();
        }

        private void save_new_tovar()
        {
            string eansave = "";
            for (int i = 0; i < lstboxean.Items.Count; i++)
            {
                if (i == lstboxean.Items.Count - 1)
                {
                    eansave = eansave + lstboxean.Items[i].ToString();
                    string ean_mag = _SRC.ean_mag();
                    if (eansave == ean_mag)
                    {

                        ean_mag = eansave.Remove(10, 3) + Convert.ToString((Convert.ToInt32(eansave.Remove(0, 10)) + 1)).PadLeft(3, '0');
                        string QueryUpdateEanMag = "update  source set  ean_mag ='" + ean_mag + "'";
                        _SQl.SQL_Query(QueryUpdateEanMag);
                    }
                    break;
                }
                eansave = eansave + lstboxean.Items[i].ToString() + " ";
            }

           
            string txtSQLsaveNewTovar = "Insert Into  dbase (kod,name,quantity,zcena,rcena,id_group,id_class,id_brand,id_suppliers,ean,kod_osnova,obem_spisanie,plukod,life_goods) Values('" + lblkod.Text + "','" + lblname.Text + "',0," + txtzcena.Text.Replace(',', '.') + "," + txtrcena.Text.Replace(',', '.') + "," + cmbgroup.SelectedValue + "," + cmbclass.SelectedValue + "," + cmbbrand.SelectedValue + "," + cmbsuppliers.SelectedValue + ",'" + eansave + "','" + txtKodOsnova.Text + "'," + txtObemSpisania.Text.Replace(',', '.') + "," + txtPLUkod.Text + "," + txtLifeGoods.Text + ")";
            _SQl.SQL_Query(txtSQLsaveNewTovar);

            
        }


        private void save_tovar()
        {
            //Обработка штрихкодов
            string eansave = "";
            string ean_mag = _SRC.ean_mag();
            for (int i = 0; i < lstboxean.Items.Count; i++)
            {
                if (i == lstboxean.Items.Count - 1)
                {
                    eansave = eansave + lstboxean.Items[i].ToString();
                    int posEan_mag=eansave.IndexOf(ean_mag);
                    if (posEan_mag >= 0)
                    {
                        string ean1 = eansave.Substring(posEan_mag, 13);
                        ean_mag = ean1.Remove(10, 3) + Convert.ToString((Convert.ToInt32(ean1.Remove(0, 10)) + 1)).PadLeft(3, '0');
                        string QueryUpdateEanMag = "update  source set  ean_mag ='" + ean_mag + "'";
                        _SQl.SQL_Query(QueryUpdateEanMag);
                    }
                 
                    break;
                }
                eansave = eansave + lstboxean.Items[i].ToString() + " ";
            }

       
            string txtSQLsaveTovar = "update  dbase set  name ='" + lblname.Text + "',id_class =" + cmbclass.SelectedValue + ",id_brand =" + cmbbrand.SelectedValue + ",id_group =" + cmbgroup.SelectedValue + ",id_suppliers=" + cmbsuppliers.SelectedValue + ",quantity =" + lblquanity.Text.Replace(',', '.') + ",zcena =" + txtzcena.Text.Replace(',', '.') + ",rcena =" + txtrcena.Text.Replace(',', '.') + ",ean='" + eansave + "',kod_osnova='" + txtKodOsnova.Text + "',obem_spisanie =" + txtObemSpisania.Text.Replace(',', '.') + ",plukod =" + txtPLUkod.Text + ",life_goods =" + txtLifeGoods.Text + " where kod='" + lblkod.Text + "'";
            _SQl.SQL_Query(txtSQLsaveTovar);
        
        }
        
        private void btnprint_Click(object sender, EventArgs e)
        {
            DataTable CennikPrint = new DataTable();
            CennikPrint.Columns.Add("0");
            CennikPrint.Columns.Add("1");
            CennikPrint.Columns.Add("2");



            CennikPrint.Rows.Add(lblkod.Text,lblname.Text,txtrcena.Text);

            if (CennikPrint != null)
            {
                var pHelper = new PrintHelper(CennikPrint);
                pHelper.Print(this.Text);

            }
        }

        private void btnaddean_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "NewEanform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form NewEanform = new NewEanform();
            NewEanform.StartPosition = FormStartPosition.CenterScreen;
            //указываем владельца для формы
            NewEanform.Owner = this;// где containerInstance - это экземпляр контейнера или указатель на MainForm
            NewEanform.Show();

        }

        private void btndelean_Click(object sender, EventArgs e)
        {
            int delean = lstboxean.SelectedIndex;
            if(delean>=0)
            {
                lstboxean.Items.RemoveAt(delean);
            }
        }

        private void tsbtnadd_Click(object sender, EventArgs e)
        {
            cmbclass.Enabled = true;
            cmbbrand.Enabled = true;
            txtname.Enabled = true;
            cmbgroup.Enabled = true;
            cmbsuppliers.Enabled = true;
            if (Sform.id_access == 1)
            {
                this.txtzcena.Enabled = false;
                this.txtrcena.Enabled = false;
            }
            else
            {
                this.txtzcena.Enabled = true;
                this.txtrcena.Enabled = true;
            }
           
            lstboxean.Enabled = true;
            btnaddean.Enabled = true;
            btncancel.Enabled = true;
            btndelean.Enabled = true;
            btnsavetovar.Enabled = true;
            btnAddPlu.Enabled = true;
            txtKodOsnova.Enabled = true;
            txtObemSpisania.Enabled = true;
            txtPLUkod.Enabled = true;
            txtLifeGoods.Enabled = true;

            this.lblkod.Text = "";
            this.lblname.Text = "";
            this.cmbclass.SelectedValue = 0;
            this.cmbbrand.SelectedValue = 0;
            this.cmbgroup.SelectedValue = 0;
            this.cmbsuppliers.SelectedValue = 0;
            this.txtname.Text = "";
            this.txtzcena.Text = "0";
            this.txtrcena.Text = "0";
            this.lblquanity.Text = "0";
            this.txtKodOsnova.Text = "0";
            this.txtObemSpisania.Text = "0";
            this.txtPLUkod.Text = "0";
            this.txtLifeGoods.Text = "0";
            this.lstboxean.Items.Clear();

            kod_mag = _SRC.kod_mag();
            pref_kod = _SRC.pref_kod();
            string kod_new = Convert.ToString(kod_mag);
            if (kod_new.Length < 6)
            {
                kod_new = kod_new.PadLeft(6, '0');
            }
            lblkod.Text = pref_kod + kod_new;
                                    
            FlagNewTovar = 1;
            this.cmbclass.Focus();
        }

        private void txtzcena_TextChanged(object sender, EventArgs e)
        {
            if (txtzcena.Text == "")
            {
                return;
            }

            double num;
            if (double.TryParse(txtzcena.Text, out num))
            {
                
            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtzcena.Text = "";
                txtzcena.Focus();
            }
        }

        private void txtrcena_TextChanged(object sender, EventArgs e)
        {
            if (txtrcena.Text == "")
            {
                return;
            }

            double num;
            if (double.TryParse(txtrcena.Text, out num))
            {

            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtrcena.Text = "";
                txtrcena.Focus();
            }
        }

        private void txtObemSpisania_TextChanged(object sender, EventArgs e)
        {
            if (txtObemSpisania.Text == "")
            {
                return;
            }

            double num;
            if (double.TryParse(txtObemSpisania.Text, out num))
            {

            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtObemSpisania.Text = "0";
                txtObemSpisania.Focus();
            }

        }

      
        //рекурсивный обход дерева, поиск и выделение нужного узла по его тексту
        void Find(TreeNodeCollection Nodes, string str)
        {
            
            trvgroup.BeginUpdate();
            foreach (TreeNode tn in Nodes)
            {
                string findnode=tn.Text.ToLower();
                if (findnode.IndexOf(str.ToLower()) > 0)
                {
                   
                    tn.BackColor = Color.LightGray;//SystemColors.Highlight;
                    trvgroup.Focus();
                    trvgroup.SelectedNode = tn;//выделение нужного узла
                    int i= tn.Index;
                    
                }
                else
                {
                    tn.BackColor = Color.White;
                }
                Find(tn.Nodes, str);
            }
            trvgroup.EndUpdate();
        }

        private void tspBtnFind_Click(object sender, EventArgs e)
        {
            Find(trvgroup.Nodes, tspTxtFind.Text);
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "ReplaceGroupform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена

            Form ReplaceGroupform = new ReplaceGroupform();
            ReplaceGroupform.StartPosition = FormStartPosition.CenterScreen;
            //calcform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            ReplaceGroupform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            ReplaceGroupform.Show();

        }
        //рекурсивный обход дерева, поиск и выделение нужного узла по его тексту
        public void chekedfind(TreeNodeCollection Nodes,int id_group)
        {
           
            string kodT = "";
            string QueryUpdateGroupT = "";
            foreach (TreeNode tn in Nodes)
            {
                int levelN = tn.Level;
                if (levelN > 1)
                {
                    if (tn.Checked == true)
                    {
                        kodT = tn.Text.Remove((tn.Text.IndexOf('-')-1));
                        QueryUpdateGroupT = "update dbase set id_group=" + id_group + " where kod='" + kodT + "'";
                        _SQl.SQL_Query(QueryUpdateGroupT);
                        countRepl++;
                    }
                }
                chekedfind(tn.Nodes, id_group);
            }
            
        }
        public void printSHK(TreeNodeCollection Nodes)
        {
            
            DataTable TovarSHKprintTEMP = new DataTable();
            string kodT = "";
            string QuerySelectTovar = "";
            foreach (TreeNode tn in Nodes)
            {
                int levelN = tn.Level;
                if (levelN > 1)
                {
                    if (tn.Checked == true)
                    {
                        kodT = tn.Text.Remove((tn.Text.IndexOf('-') - 1));
                        QuerySelectTovar = "Select Name,rcena,ean from dbase where kod='" + kodT + "'";
                        TovarSHKprintTEMP = _SQl.ExecuteSQL(QuerySelectTovar);
                        TovarSHKprint.Rows.Add(kodT,TovarSHKprintTEMP.Rows[0][0].ToString(), TovarSHKprintTEMP.Rows[0][1].ToString(), TovarSHKprintTEMP.Rows[0][2].ToString());
                        
                    }
                }
                printSHK(tn.Nodes);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            printSHK(trvgroup.Nodes);

            if (TovarSHKprint != null)
            {
                var pHelper = new PrintHelper(TovarSHKprint);
                pHelper.Print(this.Text);

            }
            TovarSHKprint.Clear();

        }

       

        private void btnAddPlu_Click(object sender, EventArgs e)
        {
            DataTable PLUkod= _SQl.ExecuteSQL("select plukodnum from source");
            txtPLUkod.Text = PLUkod.Rows[0][0].ToString();
            int plukodNew = Convert.ToInt32(txtPLUkod.Text) + 1;
            _SQl.SQL_Query("update source set plukodnum=" + plukodNew + "");
        }

        private void Tovarform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            printSHK(trvgroup.Nodes);

            if (TovarSHKprint != null)
            {
                var pHelper = new PrintHelper(TovarSHKprint);
                pHelper.PrintEan(this.Text);

            }
            TovarSHKprint.Clear();

        }

        private void tsbRefrashCMB_Click(object sender, EventArgs e)
        {
            load_cmb();
        }

        private void tSMIprice_Click(object sender, EventArgs e)
        {
            int level= trvgroup.SelectedNode.Level;

            if (level > 1)
            {
                string FullName = trvgroup.SelectedNode.Text;
                string kod = trvgroup.SelectedNode.Text.Remove((trvgroup.SelectedNode.Text.IndexOf('-') - 1));
                for (int x = 0; x < this.OwnedForms.Length; x++)
                {
                    if (this.OwnedForms[x].Name == "InfoPriceform")
                    {
                        this.OwnedForms[x].Close();

                    }
                }

                // Запускаем форму если она не запущена
                Sform.ownerFormName = "InfoPriceform";
                Form InfoPriceform = new InfoPriceform(tSMIprice.Text, kod, FullName);
                InfoPriceform.StartPosition = FormStartPosition.CenterScreen;
                //FindTovarform.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                InfoPriceform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                InfoPriceform.Show();
            }
        }

        private void tSMIcopy_Click(object sender, EventArgs e)
        {
            string kod= trvgroup.SelectedNode.Text;
            Clipboard.SetText(kod);
        }

        private void tSMIzakup_Click(object sender, EventArgs e)
        {
            int level = trvgroup.SelectedNode.Level;

            if (level > 1)
            {
                string FullName = trvgroup.SelectedNode.Text;
                string kod = trvgroup.SelectedNode.Text.Remove((trvgroup.SelectedNode.Text.IndexOf('-') - 1));
                for (int x = 0; x < this.OwnedForms.Length; x++)
                {
                    if (this.OwnedForms[x].Name == "InfoPriceform")
                    {
                        this.OwnedForms[x].Close();

                    }
                }

                // Запускаем форму если она не запущена
                Sform.ownerFormName = "InfoPriceform";
                Form InfoPriceform = new InfoPriceform(tSMIzakup.Text, kod, FullName);
                InfoPriceform.StartPosition = FormStartPosition.CenterScreen;
                //FindTovarform.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                InfoPriceform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                InfoPriceform.Show();
            }
        }

       
      
       

        
    }
}

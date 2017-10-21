using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Drawing.Printing;



namespace MagbaseServer
{
    public partial class Osnovasetform : Form
    {
        #region Settings action
        XMLFileSettings.Props props = new XMLFileSettings.Props(); //экземпляр класса с настройками 
        //Запись настроек
        private void writeSetting()
        {
           
            props.Fields.basename = txtNamebase.Text;
            props.Fields.basepath = AESEncryption.XSecurityAES.Encrypt(txtpathbase.Text,"Magbase","Alexey","SHA1",2,"1234567890Qwerty",256) ;
            props.Fields.password = AESEncryption.XSecurityAES.Encrypt(txtPassBase.Text, "Magbase", "Alexey", "SHA1", 2, "1234567890Qwerty", 256);
            props.WriteXml();
            
        }

        //Чтение настроек
        private void readSetting()
        {
 
            props.ReadXml();

            txtNamebase.Text = props.Fields.basename;
            txtpathbase.Text = AESEncryption.XSecurityAES.Decrypt(props.Fields.basepath, "Magbase", "Alexey", "SHA1", 2, "1324567890Qwerty", 256);
            txtPassBase.Text = AESEncryption.XSecurityAES.Decrypt(props.Fields.password, "Magbase", "Alexey", "SHA1", 2, "1234567890Qwerty", 256);
        }
        #endregion

        sqldb _SQl = new sqldb();
        
        public Osnovasetform()
        {
            InitializeComponent();
            
        }

        private void btnSaveRecvizite_Click(object sender, EventArgs e)
        {
/// ДОписать запрос на изменение______________________________________________________________________________  
            string SQlqueryRek = "update source set urliconame='" + txtNameCompany.Text + "'," +
                                              "inn='" + txtINN.Text + "'," +
                                              "ogrn='" + txtOGRN.Text + "'," +
                                              "index_city='" + txtInd.Text + "'," +
                                              "city='" + txtcity.Text + "'," +
                                              "street='" + txtstreet.Text + "'," +
                                              "dom='" + txtDom.Text + "'," +
                                              "stroenie='" + txtStroenie.Text + "'," +
                                              "litera='" + txtLitera.Text + "'";
            _SQl.SQL_Query(SQlqueryRek);
            Sform.urliconame = txtNameCompany.Text;
            Sform.inn = txtINN.Text;
            Sform.ogrn = txtOGRN.Text;
            Sform.city = txtcity.Text;
            Sform.indexcity = txtInd.Text;
            Sform.street = txtstreet.Text;
            Sform.dom = txtDom.Text;
            Sform.stroenie = txtStroenie.Text;
            Sform.litera = txtLitera.Text;
            
            txtNameCompany.Enabled = false;
            txtINN.Enabled = false;
            txtOGRN.Enabled = false;
            txtcity.Enabled = false;
            txtInd.Enabled = false;
            txtstreet.Enabled = false;
            txtDom.Enabled = false;
            txtStroenie.Enabled = false;
            txtLitera.Enabled = false;

            MessageBox.Show("Настройки Реквизитов успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveSetDock_Click(object sender, EventArgs e)
        {
            string SqlUpdateDock = "update source set chek=" + txtchek.Text + "," +
                                               "pref_kod='" + txtPrefKod.Text + "'," +
                                               "pref_dok_prihod='" + txtPrefPrihod.Text + "'," +
                                               "pref_dok_rashod='" + txtPrefRaschod.Text + "'," +
                                               "ean_mag='" + txtEanMag.Text + "'," +
                                               "number_dok_prihod=" + txtNumberPrihod.Text + "," +
                                               "number_dok_rashod=" + txtNumberRashod.Text + "," +
                                               "kod_mag=" + txtKodTovara.Text + "";
            _SQl.SQL_Query(SqlUpdateDock);


            
            //Sform.pref_kod = txtPrefKod.Text;
            //Sform.pref_dok_prihod = txtPrefPrihod.Text;
            //Sform.pref_dok_rashod = txtPrefRaschod.Text;
            //Sform.ean_mag = txtEanMag.Text;
            //Sform.number_dok_prihod = Convert.ToInt32(txtNumberPrihod.Text);
            //Sform.number_dok_rashod = Convert.ToInt32(txtNumberRashod.Text);
            //Sform.kod_mag = Convert.ToInt32(txtKodTovara.Text);

            txtchek.Enabled = false;
            txtPrefKod.Enabled = false;
            txtPrefPrihod.Enabled = false;
            txtPrefRaschod.Enabled = false;
            txtEanMag.Enabled = false;
            txtNumberPrihod.Enabled = false;
            txtNumberRashod.Enabled = false;
            txtKodTovara.Enabled = false;

            
            
            MessageBox.Show("Настройки Документов успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Osnovasetform_Load(object sender, EventArgs e)
        {
            txtNameCompany.Enabled = false;
            txtOGRN.Enabled = false;
            txtINN.Enabled = false;
            txtcity.Enabled = false;
            txtInd.Enabled = false;
            txtDom.Enabled = false;
            txtstreet.Enabled = false;
            txtStroenie.Enabled = false;
            txtLitera.Enabled = false;
            
            txtchek.Enabled = false;
            txtPrefKod.Enabled = false;
            txtPrefPrihod.Enabled = false;
            txtPrefRaschod.Enabled = false;
            txtEanMag.Enabled = false;
            txtNumberPrihod.Enabled = false;
            txtNumberRashod.Enabled = false;
            txtKodTovara.Enabled = false;

            txtMargin.Enabled = false;

            txtSMTP.Enabled = false;
            txtFrom.Enabled = false;
            txtPassMail.Enabled = false;
            txtTo.Enabled = false;
            txtSubj.Enabled = false;
            txtBodyMail.Enabled = false;
            txtAttach.Enabled = false;
            txtTimetimer.Enabled = false;


            DataTable Docktable = _SQl.ExecuteSQL("select chek,pref_kod,pref_dok_prihod,pref_dok_rashod,ean_mag,number_dok_prihod,number_dok_rashod,kod_mag,min_margin from source");
            if (Docktable.Rows.Count > 0)
            {
                txtchek.Text = Docktable.Rows[0][0].ToString();
                txtPrefKod.Text = Docktable.Rows[0][1].ToString();
                txtPrefPrihod.Text = Docktable.Rows[0][2].ToString();
                txtPrefRaschod.Text = Docktable.Rows[0][3].ToString();
                txtEanMag.Text = Docktable.Rows[0][4].ToString();
                txtNumberPrihod.Text = Docktable.Rows[0][5].ToString();
                txtNumberRashod.Text = Docktable.Rows[0][6].ToString();
                txtKodTovara.Text = Docktable.Rows[0][7].ToString();
                txtpathbase.Text = Sform.pathDB;
                txtPassBase.Text = Sform.passwordDB;
                txtNamebase.Text = Sform.basename;
                txtMargin.Text = Docktable.Rows[0][8].ToString();
            }
            DataTable Rektable = _SQl.ExecuteSQL("select inn,ogrn,index_city,street,dom,stroenie,litera,city,urliconame from source");
            if (Rektable.Rows.Count>0)
            {

                txtINN.Text = Rektable.Rows[0][0].ToString();
                txtOGRN.Text = Rektable.Rows[0][1].ToString();
                txtInd.Text = Rektable.Rows[0][2].ToString();
                txtstreet.Text = Rektable.Rows[0][3].ToString();
                txtDom.Text = Rektable.Rows[0][4].ToString();
                txtStroenie.Text = Rektable.Rows[0][5].ToString();
                txtLitera.Text = Rektable.Rows[0][6].ToString();
                txtcity.Text = Rektable.Rows[0][7].ToString();
                txtNameCompany.Text = Rektable.Rows[0][8].ToString(); 
            }

            DataTable PLUtablesource = _SQl.ExecuteSQL("select PrefVesEan, PLUcount, EAnCount,PLUkodnum from source");
            if (PLUtablesource.Rows.Count > 0)
            {
                txtPrefVesEan.Text = PLUtablesource.Rows[0][0].ToString();
                txtPLUCount.Text = PLUtablesource.Rows[0][1].ToString();
                txtVesEanCount.Text = PLUtablesource.Rows[0][2].ToString();
                txtPLUkod.Text = PLUtablesource.Rows[0][3].ToString();
                String[] printers = PrinterSettings.InstalledPrinters.Cast<string>().ToArray();
                String[] printers2 = PrinterSettings.InstalledPrinters.Cast<string>().ToArray();
                cmbPrintchek.DataSource = printers;
                cmbPrintDoc.DataSource = printers2;
                cmbPrintchek.Text = Sform.NamePrinterChek;
                cmbPrintDoc.Text = Sform.NamePrinterDok;
            }

            DataTable Mailtablesource = _SQl.ExecuteSQL("select SMTP,LoginMail,PassMail,ToMail,SubMail,BodyMail,AttachMail,TimerTime from source");
            if (Mailtablesource.Rows.Count > 0)
            {
                txtSMTP.Text = Mailtablesource.Rows[0][0].ToString();
                txtFrom.Text = Mailtablesource.Rows[0][1].ToString();
                txtPassMail.Text = Mailtablesource.Rows[0][2].ToString();
                txtTo.Text = Mailtablesource.Rows[0][3].ToString();
                txtSubj.Text = Mailtablesource.Rows[0][4].ToString();
                txtBodyMail.Text = Mailtablesource.Rows[0][5].ToString();
                txtAttach.Text = Mailtablesource.Rows[0][6].ToString();
                txtTimetimer.Text = Mailtablesource.Rows[0][7].ToString();
            }

            DataTable Servertablesource = _SQl.ExecuteSQL("select ServerIP,ServerPort from source");
            if (Servertablesource.Rows.Count > 0)
            {
                txtServerIP.Text = Servertablesource.Rows[0][0].ToString();
                txtServerPort.Text = Servertablesource.Rows[0][1].ToString();
            }

        }

        private void btnSaveSetBase_Click(object sender, EventArgs e)
        {
            
            writeSetting();
           

            _SQl.Connect_db();
            _SQl.sql_con.Open();

            Sform.passwordDB = txtPassBase.Text;
            Sform.pathDB = txtpathbase.Text;
            Sform.basename = txtNamebase.Text;

            _SQl.sql_con.ChangePassword(Sform.passwordDB);
            _SQl.sql_con.Close();
            MessageBox.Show("Настройки базы данных успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OFDBasepath.ShowDialog();
     
        }

        private void OFDBasepath_FileOk(object sender, CancelEventArgs e)
        {
            txtNamebase.Text = OFDBasepath.SafeFileName; 
            txtpathbase.Text = OFDBasepath.FileName;
        }



        private void btnSaveNacenka_Click(object sender, EventArgs e)
        {
            if (txtMargin.Text == "")
            {
                return;
            }

            double num;
            if (double.TryParse(txtMargin.Text, out num))
            {
                string QueryUpdateNacenka = "update source set min_margin=" + txtMargin.Text.Replace(',', '.') + "";
                _SQl.SQL_Query(QueryUpdateNacenka);
                MessageBox.Show("Настройки Наценки успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMargin.Text = "";
                txtMargin.Focus();
                return;
            }
            txtMargin.Enabled = false;
            

        }

        private void bntchangeMargin_Click(object sender, EventArgs e)
        {
            txtMargin.Enabled = true;
        }

        private void btnchangeDok_Click(object sender, EventArgs e)
        {
            txtchek.Enabled = true;
            txtPrefKod.Enabled = true;
            txtPrefPrihod.Enabled = true;
            txtPrefRaschod.Enabled = true;
            txtEanMag.Enabled = true;
            txtNumberPrihod.Enabled = true;
            txtNumberRashod.Enabled = true;
            txtKodTovara.Enabled = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void msktxtTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnchangeRek_Click(object sender, EventArgs e)
        {
            txtNameCompany.Enabled = true;
            txtINN.Enabled = true;
            txtOGRN.Enabled = true;
            txtcity.Enabled = true;
            txtInd.Enabled = true;
            txtstreet.Enabled = true;
            txtDom.Enabled = true;
            txtStroenie.Enabled = true;
            txtLitera.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnchangeVesEAN_Click(object sender, EventArgs e)
        {
            txtPrefVesEan.Enabled = true;
            txtPLUCount.Enabled = true;
            txtVesEanCount.Enabled = true;
            txtPLUkod.Enabled = true;
            
        }

        private void btnSaveVesEan_Click(object sender, EventArgs e)
        {

            string QueryUpdatePLU = "update source set PrefVesEan='" + txtPrefVesEan.Text + "',PLUcount='" + txtPLUCount.Text + "',EAnCount='" + txtVesEanCount.Text + "',PLUkodnum=" + txtPLUkod.Text + "";
            _SQl.SQL_Query(QueryUpdatePLU);
            
            MessageBox.Show("Настройки PLU кода успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtPrefVesEan.Enabled = false;
            txtPLUCount.Enabled = false;
            txtVesEanCount.Enabled = false;
            txtPLUkod.Enabled = false;
        }

        private void Osnovasetform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSavePrinterChek_Click(object sender, EventArgs e)
        {
            _SQl.SQL_Query("update source set PrinterChek='"+cmbPrintchek.Text+"'");
            Sform.NamePrinterChek = cmbPrintchek.Text;
        }

        private void btnSavePrinterDoc_Click(object sender, EventArgs e)
        {
            _SQl.SQL_Query("update source set PrinterDok='" + cmbPrintDoc.Text + "'");
            Sform.NamePrinterDok = cmbPrintDoc.Text;
        }

    
        private void btnchangeMailset_Click(object sender, EventArgs e)
        {
            txtSMTP.Enabled = true;
            txtFrom.Enabled = true;
            txtPassMail.Enabled = true;
            txtTo.Enabled = true;
            txtSubj.Enabled = true;
            txtBodyMail.Enabled = true;
            txtAttach.Enabled = true;
            txtTimetimer.Enabled = true;
        }

        private void btnSaveMailset_Click(object sender, EventArgs e)
        {
            string MailSetQuery = "update source set SMTP='" + txtSMTP.Text + "'," +
                                                "LoginMail='" + txtFrom.Text + "'," +
                                                "PassMail='" + txtPassMail.Text + "'," +
                                                "ToMail='" + txtTo.Text + "'," +
                                                "SubMail='" + txtSubj.Text + "'," +
                                                "BodyMail='" + txtBodyMail.Text + "'," +
                                                "AttachMail='" + txtAttach.Text + "'," +
                                                "TimerTime='" + txtTimetimer.Text + "'";
            _SQl.SQL_Query(MailSetQuery);

            Sform.SMTPMail = txtSMTP.Text;
            Sform.LoginMail = txtFrom.Text;
            Sform.PassMail = txtPassMail.Text;
            Sform.ToMail = txtTo.Text;
            Sform.SubMail = txtSubj.Text;
            Sform.BodyMail = txtBodyMail.Text;
            Sform.Attach = txtAttach.Text;
            Sform.TimerMail = Convert.ToInt16(txtTimetimer.Text);
            
            txtSMTP.Enabled = false;
            txtFrom.Enabled = false;
            txtPassMail.Enabled = false;
            txtTo.Enabled = false;
            txtSubj.Enabled = false;
            txtBodyMail.Enabled = false;
            txtAttach.Enabled = false;
            txtTimetimer.Enabled = false;
            MessageBox.Show("Настройки Отправки базы успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChangeServerSet_Click(object sender, EventArgs e)
        {
            txtServerIP.Enabled = true;
            txtServerPort.Enabled = true;

        }

        private void btnSaveSetServer_Click(object sender, EventArgs e)
        {
            string ServerSetQuery = "update source set ServerIP='" + txtServerIP.Text + "'," +
                                                        "ServerPort='" + txtServerPort.Text + "'";
            _SQl.SQL_Query(ServerSetQuery);

            Sform.ServerIP = txtServerIP.Text;
            Sform.ServerPort = txtServerPort.Text;

            txtServerIP.Enabled = false;
            txtServerPort.Enabled = false;
            MessageBox.Show("Настройки Сервера успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
      


    }
}

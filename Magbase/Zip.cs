using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Basezip= Ionic.Zip;
using System.Windows.Forms;

namespace MagbaseServer
{
    class Zip
    {
        public static string ZipFileToCreate = "";

        public static void sentzip(string filename)
        {
            if (!(Directory.Exists(Application.StartupPath + "\\Backup\\")))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Backup\\");
            }
            string BackaupPath = Application.StartupPath + "\\Backup\\" + filename;
            File.Copy(Sform.Attach, BackaupPath);
            zipbase(BackaupPath);
            File.Delete(BackaupPath);
            MailSent.SendMail(Sform.SMTPMail, Sform.LoginMail, Sform.PassMail, Sform.ToMail, Sform.SubMail, Sform.BodyMail, ZipFileToCreate);
            Application.DoEvents();
            try
            {
                File.Delete(ZipFileToCreate);
            }
            catch (Exception e)//вроде это исключение
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void zipbase(string pathFile)
        {
            ZipFileToCreate = Application.StartupPath + @"\Backup\Magbase.zip";
            
            using (Basezip.ZipFile zip = new Basezip.ZipFile())
            {
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                Basezip.ZipEntry ze = zip.AddFile(pathFile);
                zip.Save(ZipFileToCreate);
                
            }
            
        }
    }
}

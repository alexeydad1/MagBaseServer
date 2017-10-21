using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace MagbaseServer
{
    class MailSent
    {

       static logger _Log = new logger();
        /// <summary>
        /// Отправка письма на почтовый ящик C# mail send
        /// </summary>
        /// <param name="smtpServer">Имя SMTP-сервера</param>
        /// <param name="from">Адрес отправителя</param>
        /// <param name="password">пароль к почтовому ящику отправителя</param>
        /// <param name="mailto">Адрес получателя</param>
        /// <param name="caption">Тема письма</param>
        /// <param name="message">Сообщение</param>
        /// <param name="attachFile">Присоединенный файл</param>
        public static void SendMail(string smtpServer, string from, string password,
                                    string mailto, string caption, string message, string attachFile = null)
        {
            MailMessage mail = new MailMessage();
            try
            {
                DateTime timemail = DateTime.Now;
                
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption + " - " + timemail;
                mail.Body = message;
                if (!string.IsNullOrEmpty(attachFile))
                {

                    mail.Attachments.Add(new Attachment(attachFile));
                }
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {

                _Log.logwrite("Ошибка отправки письма: " + Environment.NewLine + e.Message, e);

                //throw new Exception("Mail.Send: " + e.Message);
            }
            finally
            {
                mail.Dispose();
            }
        }
    }
}

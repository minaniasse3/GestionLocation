using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GestionLocation.Utils
{
    public class GMailer
    {
        public static string GmailUsername { get; set; }
        public static string GmailPassword { get; set; }
        public static string GmailHost { get; set; }
        public static int GmailPort { get; set; }
        public static bool GmailSSL { get; set; }

        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }

        public GMailer()
        {
            GmailHost = "smtp.gmail.com";
            GmailPort = 25;
            GmailSSL = true;
        }

        public void Send()
        {
            SmtpClient client = new SmtpClient();
            client.Host = GmailHost;
            client.Port = GmailPort;
            client.EnableSsl = GmailSSL;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(GmailUsername, GmailPassword);

            try
            {
                using (var message = new MailMessage(GmailUsername, ToEmail))
                {
                    message.Subject = Subject;
                    message.Body = Body;
                    message.IsBodyHtml = IsHtml;
                    client.Send(message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de l'envoi du mail: " + ex.Message);
            }
        }

        public static void sendMail(string destinataire, string subject, string body)
        {
            try
            {
                GMailer.GmailUsername = "yacineniass00@gmail.com";//System.Configuration.ConfigurationManager.AppSettings["Email"];
                GMailer.GmailPassword = "fhgf lvis wzvg ldoy";//System.Configuration.ConfigurationManager.AppSettings["PasswordEmail"];

                GMailer mailer = new GMailer();
                mailer.ToEmail = destinataire;
                mailer.Subject = subject;
                mailer.Body = body;
                mailer.IsHtml = true;
                mailer.Send();
            }
            catch (Exception ex)
            {
                Helper.WriteLogSystem(ex.ToString(), "GMailer-sendMail");
            }
        }
    }

}

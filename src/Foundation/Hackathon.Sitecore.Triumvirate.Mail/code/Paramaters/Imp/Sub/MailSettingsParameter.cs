using System.Net.Mail;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp.Sub
{
    /// <summary>
    /// MailSettingsParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class MailSettingsParameter : IMailSettingsParameter
    {
        public string MailServer { get; set; }

        public string SenderMail { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Port { get; set; }

        public bool EnableSsl { get; set; }
        public SmtpClient CreateSmtpClient()
        {
            return new SmtpClient(this.MailServer, this.Port)
            {
                Credentials = new System.Net.NetworkCredential(this.Username, this.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = this.EnableSsl
            };
        }
    }
}
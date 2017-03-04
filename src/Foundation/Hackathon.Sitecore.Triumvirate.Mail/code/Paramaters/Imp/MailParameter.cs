using System;
using System.Net.Mail;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp
{
    /// <summary>
    /// MailParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class MailParameter : Base.MailParameter, IMailParameter
    {
        public string Body { get; set; }

        public MailMessage CreateMailMessage()
        {
            try
            {
                return new MailMessage(
                    this.MailSettings.SenderMail,
                    this.MailInformation.Receiver,
                    this.MailInformation.Subject,
                    this.Body);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
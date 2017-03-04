using System;
using System.Collections.Generic;
using System.Linq;
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
            MailMessage mailMessage = new MailMessage()
            {
                From = MailParameter.ToMailAddress(this.MailSettings.SenderMail),
                Subject = this.MailInformation.Subject,
                Body = this.Body,
                IsBodyHtml = true
            };

            IEnumerable<MailAddress> toMailAddresses = this.MailInformation.Receiver.Split(Labels.Delimiter).Select(MailParameter.ToMailAddress).Where(m => m != null);

            foreach (MailAddress toMailAddress in toMailAddresses)
            {
                mailMessage.To.Add(toMailAddress);
            }

            return mailMessage;

        }

        protected static class Labels
        {
            public const char Delimiter = '|';
        }

        protected static MailAddress ToMailAddress(string address)
        {
            try
            {
                return new MailAddress(address);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
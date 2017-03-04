using System.Net.Mail;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results.Imp;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Services.Imp
{
    /// <summary>
    /// MailSendService
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class MailSendService : IMailSendService
    {
        public IResult Execute(IMailParameter parameter)
        {
            bool successful = true;

            try
            {
                parameter.MailSettings.CreateSmtpClient().Send(parameter.CreateMailMessage());
            }
            catch
            {
                successful = false;
            }

            return new Result() { Successful = successful };
        }
    }
}
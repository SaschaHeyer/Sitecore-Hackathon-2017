using System.Net.Mail;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Models;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp.Sub;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Repositories;
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
        protected IMailConfigurationRepository MailConfigurationRepository { get; private set; }

        public MailSendService(IMailConfigurationRepository mailConfigurationRepository)
        {
            this.MailConfigurationRepository = mailConfigurationRepository;
        }

        public IResult Execute(IMailParameter parameter)
        {
            bool successful = true;

            try
            {
                IMailParameter mailParameter = new MailParameter()
                {
                    MailInformation = parameter.MailInformation,
                    MailSettings = parameter.MailSettings ?? this.DefaultMailSettings,
                    Body = parameter.Body
                };

                if (mailParameter.MailSettings != null)
                {
                    mailParameter.MailSettings.CreateSmtpClient().Send(mailParameter.CreateMailMessage());
                }
            }
            catch
            {
                successful = false;
            }

            return new Result() { Successful = successful };
        }

        protected IMailSettingsParameter DefaultMailSettings
        {
            get
            {
                return new MailSettingsParameter(this.MailConfigurationRepository.GetModel());
            }
        }
    }
}
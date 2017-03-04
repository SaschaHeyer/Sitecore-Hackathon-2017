using System.Net.Mail;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Models;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters;
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
                IMailSettingsParameter mailSettings = parameter.MailSettings ?? this.DefaultMailSettings;

                if (mailSettings != null)
                {
                    mailSettings.CreateSmtpClient().Send(parameter.CreateMailMessage());
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
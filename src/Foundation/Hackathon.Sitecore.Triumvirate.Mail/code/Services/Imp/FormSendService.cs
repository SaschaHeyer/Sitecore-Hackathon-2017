using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Services.Imp
{
    /// <summary>
    /// FormSendService
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class FormSendService : IFormSendService
    {
        protected IMailSendService MailSendService { get; private set; }

        public FormSendService(IMailSendService mailSendService)
        {
            this.MailSendService = mailSendService;
        }

        public IResult Execute(IFormParameter parameter)
        {
            return this.MailSendService.Execute(parameter.ToMailParameter());
        }
    }
}
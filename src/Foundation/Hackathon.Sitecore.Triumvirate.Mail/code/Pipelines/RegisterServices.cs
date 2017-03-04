using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Services;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Services.Imp;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.XA.Foundation.IOC.Pipelines.IOC;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Pipelines
{
    /// <summary>
    /// RegisterServices
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class RegisterServices : IocProcessor
    {
        /// <summary>
        /// Process
        /// </summary>
        /// <param name="args">args</param>
        public override void Process(IocArgs args)
        {
            args.ServiceCollection.AddTransient<IMailSendService, MailSendService>();
            args.ServiceCollection.AddTransient<IFormSendService, FormSendService>();
        }
    }
}
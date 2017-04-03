using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Fields;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Fields.Implementation;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Repositories.Fields;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Repositories.Fields.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.XA.Foundation.IOC.Pipelines.IOC;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Pipelines
{
    /// <summary>
    /// RegisterServices
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class RegisterServices : IocProcessor
    {
        /// <summary>
        /// Process
        /// </summary>
        /// <param name="args">args</param>
        public override void Process(IocArgs args)
        {
            args.ServiceCollection.AddTransient<IRadioListInputRepository, RadioListInputRepository>();
            args.ServiceCollection.AddTransient<IRadioListInputModel, RadioListInputModel>();
        }
    }
}
﻿using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Fields;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Fields.Implementation;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Form;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Form.Implementation;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Repositories.Fields;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Repositories.Fields.Implementation;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Response;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Response.Implementation;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Submit;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Submit.Implementation;
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
            args.ServiceCollection.AddTransient<IFormResponseService, FormResponseService>();
            args.ServiceCollection.AddTransient<IFormResponseModel, FormResponseModel>();
            args.ServiceCollection.AddTransient<IFormSubmitService, FormSubmitService>();
            args.ServiceCollection.AddTransient<IFormSubmitMailService, FormSubmitMailService>();
            args.ServiceCollection.AddTransient<IFormSubmitDatabaseService, FormSubmitDatabaseService>();
        }
    }
}
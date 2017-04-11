using System.Collections.Generic;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Base.Implementation;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp.Sub;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results.Imp;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Services;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.SitecoreExtensions.Repositories;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Submit.Implementation
{
    /// <summary>
    /// Service to handle Form Submit mail sendings
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class FormSubmitMailService : ActionService, IFormSubmitMailService
    {
        #region Properties

        /// <summary>
        /// Form Send Service
        /// </summary>
        public IFormSendService FormSendService { get; }

        #endregion

        #region c'tor

        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="formSendService">Reference to the form send service</param>
        /// <param name="contentRepository">reference to content repository</param>
        public FormSubmitMailService(
            IFormSendService formSendService,
            IContentRepository contentRepository) : base(contentRepository)
        {
            this.FormSendService = formSendService;
        }

        #endregion

        #region Interface

        /// <summary>
        /// Executes the Service
        /// </summary>
        /// <param name="contextSiteItem">Context Item</param>
        /// <param name="datasourceItem">Datasource Item</param>
        /// <param name="formElements">Form Elements</param>
        /// <returns>true if the execution was succesfull</returns>
        public bool Execute(Item contextSiteItem, Item datasourceItem, IEnumerable<IFormElementParameter> formElements)
        {
            IResult result = new Result()
            {
                Successful = false
            };

            if (contextSiteItem == null || datasourceItem == null || formElements == null)
            {
                return result.Successful;
            }

            using (new ContextItemSwitcher(contextSiteItem))
            {
                result = this.FormSendService.Execute(new FormParameter()
                {
                    FormElements = formElements,
                    MailInformation = new MailInformationParameter()
                    {
                        Subject = datasourceItem[Templates.Action.Submit.SubmitMailAction.Fields.Subject],
                        Receiver = datasourceItem[Templates.Action.Submit.SubmitMailAction.Fields.To]
                    },
                    FormFormatParameter = new FormFormatParameter(
                        datasourceItem[Templates.Action.Submit.SubmitMailAction.Fields.Opening],
                        datasourceItem[Templates.Action.Submit.SubmitMailAction.Fields.Closing],
                        datasourceItem[Templates.Action.Submit.SubmitMailAction.Fields.FieldFormat])
                });
            }

            return result.Successful;
        }

        #endregion
    }
}
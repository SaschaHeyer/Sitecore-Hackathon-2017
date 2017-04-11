using System.Collections.Generic;
using System.Linq;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Base.Implementation;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.SitecoreExtensions.Repositories;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Submit.Implementation
{
    /// <summary>
    /// Service to handle Form Submits in general
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class FormSubmitService : ActionService, IFormSubmitService
    {
        #region Properties

        /// <summary>
        /// Form Submit Mail Service
        /// </summary>
        public IFormSubmitMailService FormSubmitMailService { get; }

        /// <summary>
        /// Form Submit Database Service
        /// </summary>
        public IFormSubmitDatabaseService FormSubmitDatabaseService { get; }

        #endregion

        #region c'tor

        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="formSubmitMailSerice">Reference to form submit mail service</param>
        /// <param name="formSubmitDatabaseService">Reference to form submit database service</param>
        /// <param name="contentRepository">reference to content repository</param>
        public FormSubmitService(
            IFormSubmitMailService formSubmitMailSerice,
            IFormSubmitDatabaseService formSubmitDatabaseService,
            IContentRepository contentRepository) : base(contentRepository)
        {
            this.FormSubmitDatabaseService = formSubmitDatabaseService;
            this.FormSubmitMailService = formSubmitMailSerice;
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
            IEnumerable<Item> submitActionItems = base.GetReferenceItems(datasourceItem, Templates.Form.Fields.SubmitAction);           

            if (submitActionItems == null || !submitActionItems.Any())
            {
                return false;
            }

            bool success = true;

            foreach (Item submitActionItem in submitActionItems)
            {
                bool innerSuccess = false;
                if (submitActionItem.TemplateID.ToString() == Templates.Action.Submit.SubmitMailAction.Id.ToString())
                {
                    innerSuccess = this.FormSubmitMailService.Execute(contextSiteItem, submitActionItem, formElements);
                }

                if (submitActionItem.TemplateID.ToString() == Templates.Action.Submit.SubmitMailAction.Id.ToString())
                {
                    innerSuccess = this.FormSubmitDatabaseService.Execute(contextSiteItem, submitActionItem, formElements);
                }

                // If a single submit action fails the user shall get a notification of the fail
                if (!innerSuccess)
                {
                    success = false;
                }
            }    

            return success;
        }

        #endregion
    }
}
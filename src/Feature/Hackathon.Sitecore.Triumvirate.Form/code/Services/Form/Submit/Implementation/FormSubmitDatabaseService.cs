using System;
using System.Collections.Generic;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Base.Implementation;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.SitecoreExtensions.Repositories;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Submit.Implementation
{
    /// <summary>
    /// Service to handle Form Submit database savings
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class FormSubmitDatabaseService : ActionService, IFormSubmitDatabaseService
    {
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
            throw new NotImplementedException();
        }

        #endregion

        #region c'tor

        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="contentRepository">reference to content repository</param>
        public FormSubmitDatabaseService(
            IContentRepository contentRepository) : base(contentRepository)
        {
        }

        #endregion
    }
}
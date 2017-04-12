using System.Collections.Generic;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Base;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
using Sitecore.Data.Items;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Submit
{
    /// <summary>
    /// Service to handle Form Submits in general
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public interface IFormSubmitService : IActionService
    {
        #region Properties

        /// <summary>
        /// Form Submit Mail Service
        /// </summary>
        IFormSubmitMailService FormSubmitMailService { get; }

        /// <summary>
        /// Form Submit Database Service
        /// </summary>
        IFormSubmitDatabaseService FormSubmitDatabaseService { get; }

        #endregion

        #region Interface

        /// <summary>
        /// Executes the Service
        /// </summary>
        /// <param name="contextSiteItem">Context Item</param>
        /// <param name="datasourceItem">Datasource Item</param>
        /// <param name="formElements">Form Elements</param>
        /// <returns>true if the execution was succesfull</returns>
        bool Execute(Item contextSiteItem, Item datasourceItem, IEnumerable<IFormElementParameter> formElements);

        #endregion
    }
}

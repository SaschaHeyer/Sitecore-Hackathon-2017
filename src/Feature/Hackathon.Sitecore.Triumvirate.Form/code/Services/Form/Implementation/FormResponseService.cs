using Hackathon.Sitecore.Triumvirate.Feature.Form.Extensions;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Form;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Form.Implementation;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.SitecoreExtensions.Repositories;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Implementation
{
    /// <summary>
    /// Form Response Service to Return a build form response depending on the given Context
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class FormResponseService : IFormResponseService
    {
        /// <summary>
        /// Sitecore Foundation Content Repository
        /// </summary>
        private IContentRepository ContentRepository { get; }

        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="contentRepository">reference to content repository</param>
        public FormResponseService(IContentRepository contentRepository)
        {
            this.ContentRepository = contentRepository;
        }

        /// <summary>
        /// Method to build the form response model based on the given form item
        /// </summary>
        /// <param name="formItem">given form item</param>
        /// <param name="success">flag to determine if the response is success or not</param>
        /// <returns>form response model</returns>
        public IFormResponseModel BuildFormResponseModel(Item formItem, bool success = false)
        {
            Item responseActionItem = GetResponseActionItem(
                formItem,
                success
                    ? Templates.Form.Fields.SuccessAction
                    : Templates.Form.Fields.ErrorAction);

            IFormResponseModel returnModel = new FormResponseModel()
            {
                OutputText = string.Empty,
                RedirectUrl = string.Empty,
                Success = success
            };

            if (responseActionItem == null)
            {
                return returnModel;
            }

            if (responseActionItem.TemplateID.ToString() == Templates.Action.RedirectAction.Id.ToString())
            {                
                returnModel.RedirectUrl = ((LinkField)responseActionItem.Fields[Templates.Action.RedirectAction.Fields.RedirectUrl]).GetLinkFieldUrl();
            }

            if (responseActionItem.TemplateID.ToString() == Templates.Action.TextAction.Id.ToString())
            {
                returnModel.OutputText = responseActionItem[Templates.Action.TextAction.Fields.Text];
            }

            return returnModel;
        }

        /// <summary>
        /// Helper to get the response Action Item
        /// </summary>
        /// <param name="formItem">form item</param>
        /// <param name="contextItemField">field to retrieve</param>
        /// <returns>Response Action Item</returns>
        private Item GetResponseActionItem(Item formItem, ID contextItemField)
        {
            string actionFieldValue = formItem[contextItemField];
            return string.IsNullOrEmpty(actionFieldValue) 
                ? null 
                : this.ContentRepository.GetItem(new ID(actionFieldValue));
        }  
    }
}
using System.Collections.Generic;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.SitecoreExtensions.Repositories;
using System.Linq;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Base.Implementation
{
    /// <summary>
    /// Base Action Service
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class ActionService : IActionService
    {
        #region Properties

        /// <summary>
        /// Sitecore Foundation Content Repository
        /// </summary>
        public IContentRepository ContentRepository { get; }

        #endregion

        #region c'tor

        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="contentRepository">reference to content repository</param>
        public ActionService(IContentRepository contentRepository)
        {
            this.ContentRepository = contentRepository;
        }

        #endregion

        #region Base Functions

        /// <summary>
        /// Helper to get the response Action Item
        /// </summary>
        /// <param name="formItem">form item</param>
        /// <param name="contextItemField">field to retrieve</param>
        /// <returns>Response Action Item</returns>
        protected Item GetReferenceItem(Item formItem, ID contextItemField)
        {
            string actionFieldValue = formItem[contextItemField];
            return string.IsNullOrEmpty(actionFieldValue)
                ? null
                : this.ContentRepository.GetItem(new ID(actionFieldValue));
        }

        /// <summary>
        /// Helper to get the response Action Item
        /// </summary>
        /// <param name="formItem">form item</param>
        /// <param name="contextItemField">field to retrieve</param>
        /// <returns>Response Action Item</returns>
        protected IEnumerable<Item> GetReferenceItems(Item formItem, ID contextItemField)
        {
            string actionFieldValue = formItem[contextItemField];
            return string.IsNullOrEmpty(actionFieldValue)
                ? new List<Item>()
                : actionFieldValue.Split('|')
                    .Select(element => this.ContentRepository.GetItem(new ID(element)))
                    .Where(element => element != null)
                    .AsEnumerable();
        }

        #endregion
    }
}
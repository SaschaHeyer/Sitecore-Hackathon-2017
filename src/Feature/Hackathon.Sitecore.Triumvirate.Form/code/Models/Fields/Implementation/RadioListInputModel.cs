using System.Collections.Generic;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.Mvc.Models;
using Sitecore.XA.Foundation.RenderingVariants.Models;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Fields.Implementation
{
    /// <summary>
    /// Radio List Model
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class RadioListInputModel : VariantsRenderingModel, IRadioListInputModel
    {
        #region Properties

        /// <summary>
        /// Elements
        /// </summary>
        public IEnumerable<Item> Elements { get; set; }

        #endregion

        #region c'tor

        /// <summary>
        /// c'tor
        /// </summary>
        public RadioListInputModel()
        {
            Elements = new List<Item>();
        }

        #endregion
    }
}

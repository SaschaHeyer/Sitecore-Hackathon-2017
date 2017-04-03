using System.Collections.Generic;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Fields
{
    /// <summary>
    /// Radio List Model
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public interface IRadioListInputModel : IRenderingModelBase
    {
        /// <summary>
        /// Elements
        /// </summary>
        IEnumerable<Item> Elements { get; set; }
    }
}

using Sitecore.XA.Foundation.SitecoreExtensions.Repositories;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Base
{
    /// <summary>
    /// Base Action Service
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public interface IActionService
    {
        /// <summary>
        /// Sitecore Foundation Content Repository
        /// </summary>
        IContentRepository ContentRepository { get; }
    }
}

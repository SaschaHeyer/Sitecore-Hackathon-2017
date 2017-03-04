using System.Web.Mvc;
using Sitecore.XA.Foundation.RenderingVariants.Controllers;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Fields.Base
{
    /// <summary>
    /// Field Base Controller
    /// </summary>
    /// <author>
    /// Christian Hahn, Mrz-2017
    /// </author>
    public abstract class FieldBaseController : VariantsController
    {
        /// <summary>
        /// Index Method
        /// </summary>
        /// <returns>Index View</returns>
        public override ActionResult Index()
        {
            return View("Index", this.GetModel());
        }
    }
}
using System.Web.Mvc;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Fields.Base;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Fields
{
    /// <summary>
    /// Text Input Controller
    /// </summary>
    /// <author>
    /// Christian Hahn, Mrz-2017
    /// </author>
    public class TextInputController : FieldBaseController
    {
        /// <summary>
        /// Index Method
        /// </summary>
        /// <returns>Index View</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}
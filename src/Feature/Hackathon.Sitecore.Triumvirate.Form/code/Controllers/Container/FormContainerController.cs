using System.Web.Mvc;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Container
{
    /// <summary>
    /// Form Container Controller
    /// </summary>
    /// <author>
    /// Christian Hahn, Mrz-2017
    /// </author>
    public class FormContainerController : StandardController
    {
        /// <summary>
        /// Index Method
        /// </summary>
        /// <returns>Index View</returns>
        public override ActionResult Index()
        {
            return View("Index", this.GetModel());
        }

        /// <summary>
        /// Submit Action to handle the form submit
        /// </summary>
        /// <param name="parameter">parameters as json</param>
        [HttpPost]
        public void Submit(string parameter)
        {
            
        }
    }
}
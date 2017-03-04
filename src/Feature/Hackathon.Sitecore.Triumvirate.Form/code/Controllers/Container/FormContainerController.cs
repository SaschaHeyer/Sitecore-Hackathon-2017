using System.Web.Mvc;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Container
{
    public class FormContainerController : StandardController
    {
        // GET: FormContainer
        public override ActionResult Index()
        {
            return View();
        }
    }
}
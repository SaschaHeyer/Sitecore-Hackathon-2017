using System.Web.Mvc;
using Sitecore.XA.Foundation.Mvc.Controllers;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Container
{
    public class FormContainerController : StandardController
    {
        /// <summary>
        /// Standard Sxa Model Repository
        /// </summary>
        public IModelRepository _repository;

        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="modelRepository">Reference to Model Repository</param>
        protected FormContainerController(IModelRepository modelRepository)
        {
            _repository = modelRepository;
        }

        // GET: FormContainer
        public override ActionResult Index()
        {
            return View("Index", this.GetModel());
        }

        [HttpPost]
        public void Submit(string parameter)
        {
            
        }
    }
}
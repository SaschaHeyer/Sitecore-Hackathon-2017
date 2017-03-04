using System.Web.Mvc;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Controllers;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

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
        /// Standard Sxa Model Repository
        /// </summary>
        public IVariantsRepository _repository;

        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="variantsRepository">Reference to Model Repository</param>
        protected FieldBaseController(IVariantsRepository variantsRepository)
        {
            _repository = variantsRepository;
        }

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
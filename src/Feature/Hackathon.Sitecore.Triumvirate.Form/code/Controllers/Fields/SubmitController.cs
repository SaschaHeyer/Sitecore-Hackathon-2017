using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Fields.Base;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Fields
{
    public class SubmitController : FieldBaseController
    {
        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="variantsRepository">Reference to Model Repository</param>
        public SubmitController(IVariantsRepository variantsRepository) : base(variantsRepository)
        {
        }
    }
}
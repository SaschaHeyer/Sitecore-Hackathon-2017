using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Response;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form.Submit;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp.Sub;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results.Imp;
using Sitecore.XA.Foundation.Mvc.Controllers;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Services;
using Newtonsoft.Json;
using Sitecore.Data;
using Sitecore.Data.Items;

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
        /// Form Send Service
        /// </summary>
        public IFormSendService FormSendService { get; }

        /// <summary>
        /// Form Submit Service
        /// </summary>
        public IFormSubmitService FormSubmitService { get; }

        /// <summary>
        /// Form response service
        /// </summary>
        public IFormResponseService FormResponseService { get; }

        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="formSendService">Reference to form send service</param>
        /// <param name="formResponseService">reference to the form response service</param>
        /// <param name="formSubmitService">Reference to the form submit service</param>
        public FormContainerController(
            IFormSendService formSendService,
            IFormResponseService formResponseService,
            IFormSubmitService formSubmitService)
        {
            this.FormSendService = formSendService;
            this.FormResponseService = formResponseService;
            this.FormSubmitService = formSubmitService;
        }

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
        /// <param name="id">id of the datasource item</param>
        /// <param name="contextSite">id of the context site</param>
        [HttpPost]
        public ActionResult Submit(string parameter, string id, string contextSite)
        {
            Item datasourceItem = this.ContentRepository.GetItem(new ID(id));
            Item conetxtSiteItem = this.ContentRepository.GetItem(new ID(contextSite));

            if (datasourceItem == null || conetxtSiteItem == null || parameter == null)
            {
                return Json(this.FormResponseService.BuildFormResponseModel(datasourceItem));
            }

            bool result = this.FormSubmitService.Execute(conetxtSiteItem, datasourceItem, MapInputToParameter(parameter));           
            return Json(this.FormResponseService.BuildFormResponseModel(datasourceItem, result));
        }

        /// <summary>
        /// Maps the input string in json format into the mail input format
        /// </summary>
        /// <param name="input">json string</param>
        /// <returns>Result Mail format</returns>
        private static IEnumerable<IFormElementParameter> MapInputToParameter(string input)
        {
            Dictionary<string, string> mappedResults = JsonConvert.DeserializeObject<Dictionary<string, string>>(input);
            return mappedResults.Select(entry => new FormElementParameter()
            {
                Label = entry.Key,
                Value = entry.Value
            }).Cast<IFormElementParameter>().ToList();
        }
    }
}
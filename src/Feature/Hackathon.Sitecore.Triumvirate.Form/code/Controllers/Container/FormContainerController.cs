using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
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
        public IFormSendService FormSendService { get; set; }

        /// <summary>
        /// c'tor
        /// </summary>
        /// <param name="formSendService">Reference to form send service</param>
        public FormContainerController(IFormSendService formSendService)
        {
            FormSendService = formSendService;
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
        public void Submit(string parameter, string id, string contextSite)
        {
            Item datasourceItem = this.ContentRepository.GetItem(new ID(id));
            Item conetxtSiteItem = this.ContentRepository.GetItem(new ID(contextSite));
           
            IResult result = new Result();

            if (datasourceItem != null && conetxtSiteItem != null)
            {
                using (new ContextItemSwitcher(conetxtSiteItem))
                {
                    result = this.FormSendService.Execute(new FormParameter()
                    {
                        FormElements = FormContainerController.MapInputToParameter(parameter),
                        MailInformation = new MailInformationParameter()
                        {
                            Subject = datasourceItem[Templates.Form.Fields.Subject],
                            Receiver = datasourceItem[Templates.Form.Fields.To]
                        }
                    });
                }
                        FormElements = FormContainerController.MapInputToParameter(parameter),
                        MailInformation = new MailInformationParameter()
                        {
                            Subject = datasourceItem[Templates.Form.Fields.Subject],
                            Receiver = datasourceItem[Templates.Form.Fields.To]
                        },
                        FormFormatParameter = new FormFormatParameter(
                            datasourceItem[Templates.Form.Fields.Opening],
                            datasourceItem[Templates.Form.Fields.Closing],
                            datasourceItem[Templates.Form.Fields.FieldFormat])
                    });
                }
            }

            bool isSuccessful = result.Successful; //// TODO: for future use: feedabck?
        }

        /// <summary>
        /// Maps the input string in json format into the mail input format
        /// </summary>
        /// <param name="input">json string</param>
        /// <returns>Result Mail format</returns>
        private static IEnumerable<IFormElementParameter> MapInputToParameter(string input)
        {
            Dictionary<string,string> mappedResults = JsonConvert.DeserializeObject<Dictionary<string, string>>(input);
            return mappedResults.Select(entry => new FormElementParameter()
            {
                Label = entry.Key,
                Value = entry.Value
            }).Cast<IFormElementParameter>().ToList();
        }
    }
}
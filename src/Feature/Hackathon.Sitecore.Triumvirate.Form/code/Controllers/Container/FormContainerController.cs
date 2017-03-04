using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp.Sub;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
using Sitecore.XA.Foundation.Mvc.Controllers;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Services;

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
        [HttpPost]
        public void Submit(string parameter)
        {
            string subject = this.Rendering.DataSourceItem[Templates.Form.Fields.Subject];
            string to = this.Rendering.DataSourceItem[Templates.Form.Fields.To];

            IMailInformationParameter mailInformation = new MailInformationParameter()
            {
                Subject = subject,
                Receiver = to
            };

            IEnumerable<IFormElementParameter> formElements = new List<IFormElementParameter>();

            this.FormSendService.Execute(new FormParameter()
            {
                FormElements = formElements,
                MailInformation = mailInformation
            });
        }
    }
}
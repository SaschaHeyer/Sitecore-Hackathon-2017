using System.Web.Mvc;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Fields.Base;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Repositories.Fields;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Fields
{
    /// <summary>
    /// Radio List Input
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class RadioListInputController : FieldBaseController
    {
        private readonly IRadioListInputRepository _repository;

        public RadioListInputController(IRadioListInputRepository repository)
        {
            _repository = repository;
        }

        protected override object GetModel()
        {
            return _repository.GetModel();
        }
    }
}
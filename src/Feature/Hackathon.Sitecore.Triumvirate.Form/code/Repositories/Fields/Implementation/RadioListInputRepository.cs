using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Fields;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Fields.Implementation;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Repositories.Fields.Implementation
{
    /// <summary>
    /// Radio List Repsoitory
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class RadioListInputRepository : VariantsRepository, IRadioListInputRepository
    {
        public override IRenderingModelBase GetModel()
        {
            IRadioListInputModel model = new RadioListInputModel();
            FillBaseProperties(model);
            model.Elements = model.Item.Children;
            return model;
        }
    }
}

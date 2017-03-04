using System;
using System.Linq;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Models;
using Sitecore.Data.Items;
using Sitecore.Data.Managers;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.Multisite;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Repositories.Imp
{
    /// <summary>
    /// MailConfigurationRepository
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class MailConfigurationRepository : ModelRepository, IMailConfigurationRepository, IModelRepository, IAbstractRepository<MailConfigurationModel>
    {
        protected IMultisiteContext MultisiteContext { get; private set; }

        public MailConfigurationRepository(IMultisiteContext multisiteContext)
        {
            this.MultisiteContext = multisiteContext;
        }
        private Item _mailConfiguration;

        protected Item MailConfiguration
        {
            get
            {
                if (this._mailConfiguration == null)
                {
                    Item siteItem = this.MultisiteContext.GetSiteItem(this.PageContext.Current);

                    if (siteItem == null)
                    {
                        return null;
                    }
                
                    Item mailConfigurationsItem = siteItem.Children["Settings"].Children.SingleOrDefault<Item>((Func<Item, bool>)(i => TemplateManager.GetTemplate(i).InheritsFrom(Templates.MailConfigurations.ID)));

                    if (mailConfigurationsItem == null)
                    {
                        return null;
                    }

                    // TODO
                }
                return this._mailConfiguration;
            }
        }

        public MailConfigurationModel GetModel()
        {
            throw new NotImplementedException();
        }
    }
}
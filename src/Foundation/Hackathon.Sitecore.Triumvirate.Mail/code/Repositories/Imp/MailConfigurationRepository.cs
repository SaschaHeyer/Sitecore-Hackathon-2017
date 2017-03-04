using System;
using System.Linq;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.IDTables;
using Sitecore.Data.Items;
using Sitecore.Data.Managers;
using Sitecore.XA.Foundation.IoC;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.Multisite;
using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Repositories.Imp
{
    /// <summary>
    /// MailConfigurationRepository
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class MailConfigurationRepository :  IMailConfigurationRepository
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
                    Item siteItem = this.MultisiteContext.GetSiteItem(ServiceLocator.Current.Resolve<IPageContext>().Current);

                    if (siteItem == null)
                    {
                        return null;
                    }
                
                    Item mailConfigurationsItem = siteItem.Children["Settings"].Children.SingleOrDefault<Item>((Func<Item, bool>)(i => TemplateManager.GetTemplate(i).InheritsFrom(Templates.MailConfigurations.ID)));

                    if (mailConfigurationsItem == null)
                    {
                        return null;
                    }

                    ReferenceField defaultConfiguration = mailConfigurationsItem.Fields[Templates.MailConfigurations.Fields.Default];

                    if (defaultConfiguration == null)
                    {
                        return null;
                    }

                    this._mailConfiguration = mailConfigurationsItem.Children.SingleOrDefault(i => i.ID.Equals(defaultConfiguration.TargetID));
                }

                return this._mailConfiguration;
            }
        }

        public MailConfigurationModel GetModel()
        {
            if (this.MailConfiguration == null)
            {
                return null;
            }

            int port = 0;
            int.TryParse(this.MailConfiguration[Templates.MailConfiguration.Fields.Port] ?? string.Empty, out port);

            return new MailConfigurationModel()
            {
                Sender = this.MailConfiguration[Templates.MailConfiguration.Fields.From],
                MailServer = this.MailConfiguration[Templates.MailConfiguration.Fields.MailServer],
                Password = this.MailConfiguration[Templates.MailConfiguration.Fields.Password],
                Port = port,
                UseSsl = "1".Equals(this.MailConfiguration[Templates.MailConfiguration.Fields.UseSsl]),
                Username = this.MailConfiguration[Templates.MailConfiguration.Fields.UserName]
            };
        }
    }
}
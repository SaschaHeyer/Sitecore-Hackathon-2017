using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp
{
    /// <summary>
    /// MailParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class FormParameter : Base.MailParameter, IFormParameter
    {
        public IEnumerable<IFormElementParameter> FormElements { get; set; }
        public IMailParameter ToMailParameter()
        {
            return new MailParameter()
            {
                MailSettings = this.MailSettings,
                MailInformation = this.MailInformation,
                Body = this.FormElements.Aggregate(new StringBuilder(), (b, e) => b.AppendLine(string.Format("{0}: {1}", e.Label, e.Value))).ToString()
            };
        }
    }
}
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

        public IFormFormatParameter FormFormatParameter { get; set; }

        public IMailParameter ToMailParameter()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(this.FormFormatParameter.Opening);
            this.FormElements.Aggregate(stringBuilder, (b, e) => b.AppendLine(string.Format(this.FormFormatParameter.Field, e.Label, e.Value)));
            stringBuilder.AppendLine(this.FormFormatParameter.Closing);

            return new MailParameter()
            {
                MailSettings = this.MailSettings,
                MailInformation = this.MailInformation,
                Body = stringBuilder.ToString()
            };
        }
    }
}
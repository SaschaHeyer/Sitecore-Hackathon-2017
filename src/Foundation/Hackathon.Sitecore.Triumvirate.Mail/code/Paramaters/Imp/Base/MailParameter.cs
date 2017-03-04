using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp.Base
{
    /// <summary>
    /// MailParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public abstract class MailParameter
    {
        public IMailInformationParameter MailInformation { get; set; }

        public IMailSettingsParameter MailSettings { get; set; }
    }
}
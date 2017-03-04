using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Base
{
    /// <summary>
    /// IMailParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public interface IMailParameter
    {
        IMailInformationParameter MailInformation { get; }

        IMailSettingsParameter MailSettings { get; }
    }
}

using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp.Sub
{
    /// <summary>
    /// MailInformationParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class MailInformationParameter : IMailInformationParameter
    {
        public string Subject { get; set; }

        public string Receiver { get; set;  }
    }
}
using System.Net.Mail;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters
{
    /// <summary>
    /// IMailParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public interface IMailParameter : Base.IMailParameter
    {
        string Body { get; }

        MailMessage CreateMailMessage();
    }
}

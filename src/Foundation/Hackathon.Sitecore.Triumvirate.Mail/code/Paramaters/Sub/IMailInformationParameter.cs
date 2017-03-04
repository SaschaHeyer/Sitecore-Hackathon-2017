namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub
{
    /// <summary>
    /// IMailInformationParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public interface IMailInformationParameter
    {
        string Subject { get; }

        string Receiver { get; }
    }
}

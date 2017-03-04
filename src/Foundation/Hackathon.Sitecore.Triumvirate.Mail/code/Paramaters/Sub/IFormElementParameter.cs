namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub
{
    /// <summary>
    /// IFormElementParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public interface IFormElementParameter
    {
        string Label { get; }

        string Value { get; }
    }
}

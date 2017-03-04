

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub
{
    /// <summary>
    /// IFormFormatParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public interface IFormFormatParameter
    {
        string Opening { get; }

        string Closing { get; }

        string Field { get; }
    }
}

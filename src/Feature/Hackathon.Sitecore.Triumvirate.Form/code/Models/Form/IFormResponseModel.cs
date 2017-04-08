namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Form
{
    /// <summary>
    /// Form Response Model
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public interface IFormResponseModel
    {
        /// <summary>
        /// The Outputtext to be printed on the page
        /// </summary>
        string OutputText { get; set; }

        /// <summary>
        /// The Redirect url in case a redirect shall be performaned
        /// </summary>
        string RedirectUrl { get; set; }

        /// <summary>
        /// success flag
        /// </summary>
        bool Success { get; set; }
    }
}

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Form.Implementation
{
    /// <summary>
    /// Form Response Model
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public class FormResponseModel : IFormResponseModel
    {
        /// <summary>
        /// The Outputtext to be printed on the page
        /// </summary>
        public string OutputText { get; set; }

        /// <summary>
        /// The Redirect url in case a redirect shall be performaned
        /// </summary>
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Success Flag
        /// </summary>
        public bool Success { get; set; }
    }
}
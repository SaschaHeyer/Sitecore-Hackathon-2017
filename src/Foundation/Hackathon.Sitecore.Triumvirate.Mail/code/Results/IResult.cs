namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results
{
    /// <summary>
    /// IResult
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public interface IResult
    {
        /// <summary>
        /// True is succesful 
        /// </summary>
        bool Successful { get; }
    }
}

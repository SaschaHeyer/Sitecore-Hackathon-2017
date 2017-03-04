namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Services.Base
{
    /// <summary>
    /// IService
    /// </summary>
    /// <typeparam name="P">Parameter</typeparam>
    /// <typeparam name="R">Results</typeparam>
    public interface IService<P, R>
    {
        /// <summary>
        /// Execute service
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>Result</returns>
        R Execute(P parameter);
    }
}

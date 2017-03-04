namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results.Imp
{
    /// <summary>
    /// Result
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class Result : IResult
    {
        public Result()
        {
            this.Successful = false;
        }

        public bool Successful { get; set; }
    }
}
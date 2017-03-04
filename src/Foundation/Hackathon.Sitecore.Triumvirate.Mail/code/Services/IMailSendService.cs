using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Results;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Services
{
    /// <summary>
    /// IMailSendService
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public interface IMailSendService : Base.IService<IMailParameter, IResult>
    {
    }
}
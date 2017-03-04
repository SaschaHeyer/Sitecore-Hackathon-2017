using System.Collections.Generic;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters
{ 
    /// <summary>
    /// IFormParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public interface IFormParameter : Base.IMailParameter
    {
        IEnumerable<IFormElementParameter> FormElements { get; }

        IMailParameter ToMailParameter();
    }
}

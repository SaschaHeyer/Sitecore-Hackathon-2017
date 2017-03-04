using System;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp.Sub
{
    /// <summary>
    /// FormElementParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class FormElementParameter : IFormElementParameter
    {
        public string Label { get; set; }

        public string Value { get; set; }
    }
}
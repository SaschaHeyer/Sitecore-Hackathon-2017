using System.Linq;
using Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub;
using Sitecore.StringExtensions;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Imp.Sub
{
    /// <summary>
    /// FormFormatParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class FormFormatParameter : IFormFormatParameter
    {
        public FormFormatParameter()
        {
            this.InitializeWithDefaults();
        }

        public FormFormatParameter(string opening, string closing, string field)
        {
            if (new string[] {opening, closing, field}.Any(m => m.IsNullOrEmpty()))
            {
                this.InitializeWithDefaults();
            }
            else
            {
                this.Opening = opening;
                this.Closing = closing;
                this.Field = field;
            }
        }

        public string Opening { get; private set; }

        public string Closing { get; private set; }

        public string Field { get; private set; }

        protected void InitializeWithDefaults()
        {
            this.Opening = Defaults.Opening;
            this.Closing = Defaults.Closing;
            this.Field = Defaults.Field;
        }

        protected static class Defaults
        {
            public const string Opening = "<table>";

            public const string Closing = "</table>";

            public const string Field = "<tr><td>{0}</td><td>{1}</td></tr>";
        }
    }
}
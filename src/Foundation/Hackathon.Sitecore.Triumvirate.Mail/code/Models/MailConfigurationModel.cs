using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Models
{
    /// <summary>
    /// MailConfigurationModel
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public class MailConfigurationModel
    {
        public string MailServer { get; set; }

        public string Sender { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Port { get; set; }

        public bool UseSsl { get; set; }
    }
}
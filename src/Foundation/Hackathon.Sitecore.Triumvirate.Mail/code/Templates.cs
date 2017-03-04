using System.Runtime.InteropServices;
using Sitecore.Data;

namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail
{
    public class Templates
    {
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct MailConfigurations
        {
            public static ID ID = ID.Parse("{9A118067-9F15-46A8-9279-765AB8BFE237}");

            [StructLayout(LayoutKind.Sequential, Size = 1)]
            public struct Fields
            {
                public static readonly ID Default = new ID("{D76BE5DA-A433-46E6-9CB6-E4729FC82F89}");
            }
        }

        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct MailConfiguration
        {
            public static ID ID = ID.Parse("{AE7C3527-3D04-4B7E-8A79-57991DDC80F3}");

            [StructLayout(LayoutKind.Sequential, Size = 1)]
            public struct Fields
            {
                public static readonly ID MailServer = new ID("{19E677AE-4AE9-4820-8DBB-2F689D7C71A3}");
                public static readonly ID From = new ID("{8436FEAF-740E-475E-8541-E44B9142AA7C}");
                public static readonly ID UserName = new ID("{9CEB60B3-D9D4-40B2-BDE8-69DC7126B285}");
                public static readonly ID Password = new ID("{55A809A3-3F6A-4BC9-A7E5-403A3BE7AE70}");
                public static readonly ID Port = new ID("{4991853D-DDD7-4150-925A-CF1F79251F2D}");
                public static readonly ID UseSsl = new ID("{D46B869D-670B-4430-8EB1-D43FEF99F4D2}");
            }
        }
    }
}
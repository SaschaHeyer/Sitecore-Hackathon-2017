using Sitecore.Data;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form
{
    /// <summary>
    /// Form Templates
    /// </summary>
    /// <author>
    /// Sascha Heyer, Mrz-2017
    /// </author>
    public struct Templates
    {
        public struct Form
        {
            public static ID Id = new ID("{44DF22F0-8703-4380-9F37-42FA12116346}");

            public struct Fields
            {
                public static readonly ID Subject = new ID("{818B2889-C207-44B7-9AEF-300DBB4FB6AE}");
                public static readonly ID To = new ID("{96F214C6-9A65-4696-B622-206CB7A96165}");
            }
        }
    }
}
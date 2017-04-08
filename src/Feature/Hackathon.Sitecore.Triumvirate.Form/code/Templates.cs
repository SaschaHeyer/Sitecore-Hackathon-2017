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
        /// <summary>
        /// Form Item
        /// </summary>
        public struct Form
        {
            /// <summary>
            /// ID
            /// </summary>
            public static ID Id = new ID("{44DF22F0-8703-4380-9F37-42FA12116346}");

            /// <summary>
            /// Fields
            /// </summary>
            public struct Fields
            {
                public static readonly ID Subject = new ID("{818B2889-C207-44B7-9AEF-300DBB4FB6AE}");
                public static readonly ID To = new ID("{96F214C6-9A65-4696-B622-206CB7A96165}");
                public static readonly ID Opening = new ID("{0F9AA4BE-71F1-45AE-9C5B-C278A5B149BF}");
                public static readonly ID Closing = new ID("{96C358C1-0518-409D-87C0-40AA28AE7A38}");
                public static readonly ID FieldFormat = new ID("{7EB383B9-7798-48C3-9588-BC1D7C7925CA}");
                public static readonly ID SuccessAction = new ID("{86037AB4-E883-424F-A53E-E071BCC945E9}");
                public static readonly ID ErrorAction = new ID("{BF3961D8-BE47-4413-B3CE-40F5AB4E3607}");
            }
        }

        /// <summary>
        /// Action Items
        /// </summary>
        public struct Action
        {
            /// <summary>
            /// Redirect Action
            /// </summary>
            public struct RedirectAction
            {
                /// <summary>
                /// Redirect Action Item
                /// </summary>
                public static readonly ID Id = new ID("{2436196C-CAA1-4B02-A7F7-8C1893A41E97}");

                /// <summary>
                /// Fields
                /// </summary>
                public struct Fields
                {
                    /// <summary>
                    /// Redirect Url
                    /// </summary>
                    public static readonly ID RedirectUrl = new ID("{5BECBB59-BA48-4B2B-B939-1F379431F75B}");
                }
            }

            /// <summary>
            /// Text Action
            /// </summary>
            public struct TextAction
            {
                /// <summary>
                /// Redirect Action Item
                /// </summary>
                public static readonly ID Id = new ID("{F6CF40D5-CEAE-4A91-AA6D-C6C565F024D8}");

                /// <summary>
                /// Fields
                /// </summary>
                public struct Fields
                {
                    /// <summary>
                    /// Text Field
                    /// </summary>
                    public static readonly ID Text = new ID("{D7971E98-2042-4D43-9E4D-43B711B8C0D5}");
                }
            }
        }
    }
}
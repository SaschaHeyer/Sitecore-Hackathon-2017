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
                public static readonly ID SuccessAction = new ID("{86037AB4-E883-424F-A53E-E071BCC945E9}");
                public static readonly ID ErrorAction = new ID("{BF3961D8-BE47-4413-B3CE-40F5AB4E3607}");
                public static readonly ID SubmitAction = new ID("{908E5BA1-091F-4746-9E80-B2FDEC18A9A8}");
            }
        }

        /// <summary>
        /// Action Items
        /// </summary>
        public struct Action
        {
            /// <summary>
            /// Submit Actions
            /// </summary>
            public struct Submit
            {
                public struct SubmitMailAction
                {
                    /// <summary>
                    /// Submit Mail ACtion ID
                    /// </summary>
                    public static readonly ID Id = new ID("{879E6CB9-C657-4E6C-9CE9-CB50FAB16453}");

                    /// <summary>
                    /// Fields
                    /// </summary>
                    public struct Fields
                    {
                        /// <summary>
                        /// Subject
                        /// </summary>
                        public static readonly ID Subject = new ID("{A2DE70BA-DA13-4B15-B11E-2F81B2D98A77}");

                        /// <summary>
                        /// To
                        /// </summary>
                        public static readonly ID To = new ID("{CCE8BFA5-EC10-4DCA-B2AA-1284F6BF9DA9}");

                        /// <summary>
                        /// Opening
                        /// </summary>
                        public static readonly ID Opening = new ID("{07772539-EDFE-4707-8B7F-799690B5708C}");

                        /// <summary>
                        /// Closing
                        /// </summary>
                        public static readonly ID Closing = new ID("{E36BA9C4-3A7B-4007-ACDB-3F6C37FED7BF}");

                        /// <summary>
                        /// FieldFormat
                        /// </summary>
                        public static readonly ID FieldFormat = new ID("{ABC49A70-87C1-41A4-99E1-A4F6958894BD}");
                    }
                }

                public struct SubmitDatabaseAction
                {
                    /// <summary>
                    /// Redirect Action Item
                    /// </summary>
                    public static readonly ID Id = new ID("{6DE918A4-4806-4DA0-AAAB-C3A2303536D1}");
                }
            }
           
            /// <summary>
            /// Response Actions
            /// </summary>
            public struct Response

            {
                /// <summary>
                /// Redirect Action
                /// </summary>
                public struct ResponseRedirectAction
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
                public struct ResponseTextAction
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
}
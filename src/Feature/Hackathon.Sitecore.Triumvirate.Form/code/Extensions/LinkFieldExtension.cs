using Sitecore.Data.Fields;
using Sitecore.Links;
using Sitecore.Resources.Media;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Extensions
{
    /// <summary>
    /// Link Field Extensions
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public static class LinkFieldExtension
    {
        /// <summary>
        /// Get Link Field Url
        /// </summary>
        /// <param name="linkField">given Link Field</param>
        /// <returns></returns>
        public static string GetLinkFieldUrl(this LinkField linkField)
        {
            if (string.IsNullOrEmpty(linkField?.LinkType))
            {
                return string.Empty;
            }

            switch (linkField.LinkType.ToLower())
            {
                case "internal":
                {
                    return linkField.TargetItem == null 
                            ? string.Empty 
                            : LinkManager.GetItemUrl(linkField.TargetItem);
                }

                case "media":
                {
                    return linkField.TargetItem == null 
                            ? string.Empty 
                            : MediaManager.GetMediaUrl(linkField.TargetItem);
                }

                case "anchor":
                    {
                        if (string.IsNullOrEmpty(linkField.Anchor))
                        {
                            return string.Empty;
                        }

                        return "#" + linkField.Anchor;
                    }

                case "external":
                    return linkField.Url;
                case "mailto":
                    return linkField.Url;
                case "javascript":
                    return linkField.Url;
                default:
                    return linkField.Url;
            }
        }
    }
}
using Hackathon.Sitecore.Triumvirate.Feature.Form.Models.Form;
using Sitecore.Data.Items;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Services.Form
{
    /// <summary>
    /// Form Response Service to Return a build form response depending on the given Context
    /// </summary>
    /// <author>
    /// Christian Hahn, Apr-2017
    /// </author>
    public interface IFormResponseService
    {
        /// <summary>
        /// Method to build the form response model based on the given form item
        /// </summary>
        /// <param name="formItem">given form item</param>
        /// <param name="success">flag to determine if the response is success or not</param>
        /// <returns>form response model</returns>
        IFormResponseModel BuildFormResponseModel(Item formItem, bool success = false);
    }
}

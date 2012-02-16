using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace System.Web.Mvc.Html {

    public static class MvcHtmlExtensions {
        /// <summary>
        /// Applies the css class "current" if the link matches the current controller
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="linkText"></param>
        /// <param name="actionName"></param>
        /// <param name="controllerName"></param>
        /// <returns></returns>
        public static MvcHtmlString NavLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName) {
            
            string currentController = (string)htmlHelper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue;
            
            if (currentController == controllerName) {
                return LinkExtensions.ActionLink(htmlHelper, linkText, actionName, controllerName, new { @class = "current" });
            }
            
            return LinkExtensions.ActionLink(htmlHelper, linkText, actionName, controllerName);
        }
    }
	
}
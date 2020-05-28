using BTLQLKTX.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BTLQLKTX.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var sess = (UserLogin)Session[CommonConstants.USER_SESSION];
            if (sess == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary((new { controller = "Login", action = "Index", Area = "Admin" })));
            }
            base.OnActionExecuted(filterContext);
        }
        protected void SetAlert(string message,string type)
        {
            TempData["AlertMessage"] = message;
            if(type=="success")
            {
                TempData["AlertType"] = "alert-success";

            }
            if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";

            }
            if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";

            }

        }
    }
}
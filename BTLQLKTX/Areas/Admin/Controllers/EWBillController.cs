using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLQLKTX.Areas.Admin.Controllers
{
    public class EWBillController : Controller
    {
        // GET: Admin/EWBill
        public ActionResult Index(string searchString, int pageNumber = 1, int pageSize = 5)
        {
            var dao = new UserDao();
            pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            var model = dao.showAllData(searchString, pageNumber, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
            return View();
        }
    }
}
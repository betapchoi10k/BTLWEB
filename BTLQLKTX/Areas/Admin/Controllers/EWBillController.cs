using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Configuration;
using Model;
using Model.Dao;
using Model.EF;

namespace BTLQLKTX.Areas.Admin.Controllers
{
    public class EWBillController : Controller
    {
        // GET: Admin/EWBill
        public ActionResult Index(string searchString, int pageNumber = 1, int pageSize = 5)
        {
            var dao = new EWBillDao();
            pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            var model = dao.showAllData(searchString, pageNumber, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
           
        }
        [HttpGet]
        public ActionResult Create()
        {
            setViewBag();
            return View();
        }
        [HttpPost]
        public ActionResult Create(HDDienNuoc hd)
        {
            if (ModelState.IsValid)
            {
                var dao = new EWBillDao();
               
                string id = dao.InsertHD(hd);
                if (id != null)
                {
                    //SetAlert("Tạo mới thành công ", "success");
                    return RedirectToAction("Index", "EWBillController");

                }
                {

                    ModelState.AddModelError("", "Thêm hóa đơn không thành công ");
                }

            }
            return View("Index");
        }
        public void setViewBag()
        {
            var dao = new EWBillDao();
            ViewBag.MaDien = new SelectList(dao.ListAllD(), "MaDien", "MaDien");
            ViewBag.MaNuoc = new SelectList(dao.ListAllN(), "MaNuoc", "MaNuoc");
        }
    }
}
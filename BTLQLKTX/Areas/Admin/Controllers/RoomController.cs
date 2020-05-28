using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace BTLQLKTX.Areas.Admin.Controllers
{
    public class RoomController : Controller
    {
        QuanLyKyTucXaDb db = new QuanLyKyTucXaDb();
        // GET: Admin/Room
        public ActionResult Index()
        {
            List<Phong> lstPhong = db.Phongs.OrderBy(x => x.MaKhu).ToList();
            if (lstPhong.Count == 0)
            {
                ViewBag.Phong = "Khong co san pham ";

            }
            ViewBag.lstPhong = lstPhong.ToList();
            return View(lstPhong);
          
        }
        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Phong model)
        {
            if (ModelState.IsValid)
            {
                var dao = new RoomDao();
            }
            return View(model);

        }
    
        public void SetViewBag(string selectdID=null)
        {
            //Tạo IEnumerable<SelectListItem> để đẩy dữ liệu vào dropdownlist
            var dao = new HouseDao();
            ViewBag.MaKhu = new SelectList(dao.ListAll(),"MaKhu","TenKhu", selectdID);
        }
        public PartialViewResult Khu()
        {
            return PartialView(db.KhuNhas.ToList());
        }
        public ViewResult PhongtheoKhu(string MaKhu = "")
        {
          List<Phong> lstPhong =   db.Phongs.Where(x => x.MaKhu == MaKhu).OrderBy(x => x.MaKhu).ToList();
            if (lstPhong.Count == 0)
            {
                ViewBag.Phong = "Khong co san pham ";

            }
            ViewBag.lstPhong = lstPhong.ToList();
            return View(lstPhong);

        }
        public ActionResult ChiTietPhong(String MaPhong = "A1P1")
        {
            var phong = db.Phongs.SingleOrDefault(x => x.MaPhong == MaPhong);
            if (phong == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(phong);
        }
    }
}
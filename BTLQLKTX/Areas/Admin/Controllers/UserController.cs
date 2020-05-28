using BTLQLKTX.Common;
using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Configuration;

namespace BTLQLKTX.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index(string searchString, int pageNumber = 1, int pageSize = 5)
        {
            var dao = new UserDao();
            pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            var model = dao.showAllData(searchString,pageNumber, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(string MaSV )
        {
            var user = new UserDao().ViewDetail(MaSV);
            return View(user);
        }
        [HttpPost]
        public ActionResult Create(Account user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var pass = Encrytor.ToMD5(user.Password);
                user.Password = pass;
                string id = dao.Insert(user);
                if (id != null)
                {
                    SetAlert("Tạo mới thành công ", "success");
                    return RedirectToAction("Index", "User");

                }
                {
                    
                    ModelState.AddModelError("", "Thêm user không thành công ");
                }

            }
            return View("Index"); 
        }
        [HttpPost]
        public ActionResult Edit(Account user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var pass = Encrytor.ToMD5(user.Password);
                user.Password = pass;
                var id = dao.Update(user);
                if (id )
                {
                    SetAlert("Sửa mới thành công ", "success");
                    return RedirectToAction("Index", "User");

                }
                {
                   
                    ModelState.AddModelError("", "Cập nhập user không thành công ");
                }

            }
            return View("Index");
        }
        [HttpDelete]
        public ActionResult Delete(string MaSV)
        {
           var user = new UserDao().Delete(MaSV);
            SetAlert("Đã xóa thành công -ấn F5 để tải lại trang", "success");
            return RedirectToAction("Index");
        }


    }
}
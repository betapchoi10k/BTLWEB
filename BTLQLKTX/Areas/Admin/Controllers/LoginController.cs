using BTLQLKTX.Areas.Admin.Models;
using BTLQLKTX.Common;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLQLKTX.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Login(LoginModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var dao = new UserDao();
        //        var res = dao.Login(model.UserName,Encrytor.GetMD5( model.PassWord));
        //        if (res==1)
        //        {
        //            var user = dao.GetByUserName(model.UserName);
        //            var userSession = new UserLogin();
        //            userSession.UserName = user.UserName;
        //            userSession.MaSV = user.MaSV;

        //            Session.Add(CommonConstants.USER_SESSION, userSession);
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else if (res == 0)
        //        {
        //            ModelState.AddModelError("", "Tài khoản không tồn tại");
        //        }
        //        else if (res == -1)
        //        {
        //            ModelState.AddModelError("", "Tài khoản đã bị khóa");
        //        }
        //        else if (res == -2)
        //        {
        //            ModelState.AddModelError("", "Mật khẩu không đúng");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Đăng nhập không đúng");
        //        }

        //    }
        //    return View("Index");

        //}
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var res = dao.Login(model.UserName, Encrytor.GetMD5(model.PassWord));
                if (res)
                {
                    var user = dao.GetByUserName(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.MaSV = user.MaSV;

                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng");
                }

            }
            return View("Index");

        }
    }
}
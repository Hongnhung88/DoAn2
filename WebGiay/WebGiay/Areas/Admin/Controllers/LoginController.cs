using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGiay.Areas.Admin.Data;
using WebGiay.Common;

namespace WebGiay.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginAdminModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new AdminDAO();
                
                var result = dao.Login(model.Email, model.Password);

                if (result == 1)
                {
                    var acc = dao.GetByID(model.Email);

                    var admimSession = new AdminLogin();

                    admimSession.AdminID = acc.id;
                    admimSession.AdminEmail = acc.email;

                    Session.Add(CommonConstants.ADMIN_SESSION, admimSession);

                    return RedirectToAction("Index", "HomeAdmin");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại !");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Sai mật khẩu. Vui lòng nhập lại !!!");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không thành công !!!");
                }
            }

            return View("Index");
        }
    }
}
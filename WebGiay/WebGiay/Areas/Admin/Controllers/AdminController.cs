using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGiay.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        // GET: Admin/Admin
        public ActionResult Index(string search, int page = 1, int pageSize = 10)
        {
            var model = new AdminDAO();

            var result = model.ListAllPage(search, page, pageSize);

            ViewBag.Search = search;

            return View(result);
        }

        // GET: Admin/Admin/Details/5
        public ActionResult Details(int id)
        {
            var model = new AdminDAO().Detail(id);

            return View(model);
        }

        // GET: Admin/Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin/Create
        [HttpPost]
        public ActionResult Create(admin admin)
        {
            if(ModelState.IsValid)
            {
                var adminDAO = new AdminDAO();

                long id = adminDAO.Insert(admin);

                if(id > 0)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới tài khoản thất bại !");
                }
            }

            return View();
        }

        // GET: Admin/Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(admin admin)
        {
            if (ModelState.IsValid)
            {
                var adminDAO = new AdminDAO();

                var result = adminDAO.Update(admin);

                if (result)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }

            return View("Edit");
        }

        // GET: Admin/Admin/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new AdminDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}

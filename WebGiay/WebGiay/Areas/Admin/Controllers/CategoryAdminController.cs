using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGiay.Areas.Admin.Controllers
{
    public class CategoryAdminController : BaseController
    {
        // GET: Admin/CategoryAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 10)
        {
            var category = new CategoryDAO();
            var model = category.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }


        // GET: Admin/CategoryAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CategoryAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CategoryAdmin/Create
        [HttpPost]
        public ActionResult Create(category category)
        {
            if (ModelState.IsValid)
            {
                var dao = new CategoryDAO();

                long id = dao.Insert(category);
                if (id > 0)
                {
                    return RedirectToAction("Index", "CategoryAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới danh mục sản phẩm thất bại");
                }
            }
            return View();
        }

        // GET: Admin/CategoryAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            var category = new CategoryDAO().Detail(id);
            return View(category);
        }

        // POST: Admin/CategoryAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(category category)
        {
            if (ModelState.IsValid)
            {
                var dao = new CategoryDAO();

                var result = dao.Update(category);
                if (result)
                {
                    return RedirectToAction("Index", "CategoryAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // POST: Admin/CategoryAdmin/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var idpro = new WebGiayDbContext().products.Where(x => x.category_id == id);
            if (idpro == null)
            {
                new CategoryDAO().Delete(id);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "Hãng giày đang chứa sản phẩm ! Bạn không thể xoá !";
                return RedirectToAction("Index");
            }
        }
    }
}

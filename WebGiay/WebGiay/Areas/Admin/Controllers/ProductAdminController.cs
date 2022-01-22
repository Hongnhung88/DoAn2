using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGiay.Areas.Admin.Controllers
{
    public class ProductAdminController : BaseController
    {
        // GET: Admin/ProductAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 5)
        {
            var iplAcc = new ProductDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            var pr = new ProductDAO().Detail(id);
            return View(pr);
        }

        // GET: Admin/ProductAdmin/Create
        public ActionResult Create()
        {
            CategoryDAO lx = new CategoryDAO();
            var lxList = lx.ListOf();

            ViewBag.LX = lxList;

            return View();
        }

        // POST: Admin/ProductAdmin/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(product product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDAO();

                long id = dao.Insert(product);
                if (id > 0)
                {
                    return RedirectToAction("Index", "ProductAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới thất bại");
                }
            }

            return View();
        }

        // GET: Admin/ProductAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            var sp = new ProductDAO().Detail(id);

            CategoryDAO lx = new CategoryDAO();
            var lxList = lx.ListOf();

            ViewBag.LX = lxList;

            return View(sp);
        }

        // POST: Admin/ProductAdmin/Edit/5
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(product sp)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDAO();

                var result = dao.Update(sp);
                if (result)
                {
                    return RedirectToAction("Index", "ProductAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/ProductAdmin/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var idorder = new DBWebGiayContent().order_details.Where(x => x.product_id == id);
            if (idorder == null)
            {
                new ProductDAO().Delete(id);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "Sản phẩm đang có trong đơn hàng. Bạn không thể xoá !!!";
                return RedirectToAction("Index");
            }
        }
    }
}

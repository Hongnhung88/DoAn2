using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGiay.Areas.Admin.Controllers
{
    public class OrdersAdminController : BaseController
    {
        // GET: Admin/OrdersAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 10)
        {
            var order = new OrderDAO();
            var model = order.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/OrdersAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: Admin/OrdersAdmin/Edit/5
        public ActionResult Status(int id, order orders)
        {
            if (ModelState.IsValid)
            {
                orders.id = id;
                var dao = new OrderDAO();
                var result = dao.Update(orders);
                if (result)
                {
                    return RedirectToAction("Index", "OrdersAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/OrdersAdmin/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new OrderDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}

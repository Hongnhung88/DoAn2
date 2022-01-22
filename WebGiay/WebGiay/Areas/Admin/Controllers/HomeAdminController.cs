using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGiay.Areas.Admin.Data;

namespace WebGiay.Areas.Admin.Controllers
{
    public class HomeAdminController : BaseController
    {
        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            var listPro = new ProductDAO().ListOf();
            ViewBag.Model = listPro.Count();

            var order = new OrderDAO().ListOf();
            ViewBag.Order = order.Count();
            ViewBag.Price = order.Sum(x => x.amount).ToString();

            var car = new CategoryDAO().ListOf();
            ViewBag.Car = car.Count();

            return View();
        }
    }
}

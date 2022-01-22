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
            var listProduct = new ProductDAO().ListNewPro();
            var listPro = new ProductDAO().ListOf();
            ViewBag.Model = listPro.Count();

            List<ProductAdminModel> listP = new List<ProductAdminModel>(); 
            foreach (var item in listProduct)
            {
                var product = new ProductAdminModel();
                product.Id = item.id;
                product.Name = item.name;
                product.Price = (double)item.price;
                product.Image = item.images[0];

            }

            return View();
        }

        // GET: Admin/HomeAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/HomeAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeAdmin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/HomeAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/HomeAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/HomeAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/HomeAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

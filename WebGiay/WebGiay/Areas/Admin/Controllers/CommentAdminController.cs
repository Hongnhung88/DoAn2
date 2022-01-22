using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGiay.Areas.Admin.Data;

namespace WebGiay.Areas.Admin.Controllers
{
    public class CommentAdminController : BaseController
    {
        // GET: Admin/CommentAdmin
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var iplAcc = new CommentDAO();
            var model = iplAcc.ListAllPage(page, pageSize);

            List<CommentAdminModel> listFB = new List<CommentAdminModel>();

            foreach (var item in model)
            {
                var newFb = new CommentAdminModel();
                newFb.ID = item.id;
                newFb.User_Email = item.user_email;
                newFb.Product_ID = (int)item.product_id;
                //newFb.Product_Image = item.Product == null ? string.Empty : item.Product.imagemain;
                newFb.Star = (int)item.star;
                newFb.Note = item.comment1;
                listFB.Add(newFb);
            }
            ViewBag.Feedback = listFB;

            return View(model);
        }

        // GET: Admin/CommentAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CommentAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CommentAdmin/Create
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

        // GET: Admin/CommentAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/CommentAdmin/Edit/5
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

        // GET: Admin/CommentAdmin/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new CommentDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}

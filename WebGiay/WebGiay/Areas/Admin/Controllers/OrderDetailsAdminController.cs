using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGiay.Areas.Admin.Data;

namespace WebGiay.Areas.Admin.Controllers
{
    public class OrderDetailsAdminController : BaseController
    {
        // GET: Admin/OrderDetailsAdmin
        public ActionResult Index(int id)
        {
            var orderDetail = new OrderDetailDAO().Detail(id);

            List<OrderDetailsAdminModel> listO = new List<OrderDetailsAdminModel>();
            foreach (var item in orderDetail)
            {
                var detail = new OrderDetailsAdminModel();
                detail.OrderID = (int)item.order_id;
                detail.ID = item.id;
                detail.ProductID = item.product.id;
                detail.ProductName = item.product == null ? string.Empty : item.product.name;
                detail.Price = (double)item.price;
                detail.Qty = (int)item.qty;
                //detail.ProductImage = item.Product.imagemain;
                listO.Add(detail);
            }
            ViewBag.Product = listO;

            var order = new OrderDAO().Detail(id);
            ViewBag.Order = order;

            return View();
        }
    }
}

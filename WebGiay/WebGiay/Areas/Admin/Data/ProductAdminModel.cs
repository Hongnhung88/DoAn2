using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGiay.Areas.Admin.Data
{
    public class ProductAdminModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public double Price { get; set; }
    }
}
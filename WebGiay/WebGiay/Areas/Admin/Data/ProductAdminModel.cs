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
        public double Price { get; set; }
        public int Number { get; set; }
        public string Image { get; set; }
    }
}
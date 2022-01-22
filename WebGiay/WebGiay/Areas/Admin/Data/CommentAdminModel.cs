using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGiay.Areas.Admin.Data
{
    public class CommentAdminModel
    {
        public int ID { get; set; }
        public string User_Email { get; set; }
        public int Product_ID { get; set; }
        public int Star { get; set; }
        public string Note { get; set; }
    }
}
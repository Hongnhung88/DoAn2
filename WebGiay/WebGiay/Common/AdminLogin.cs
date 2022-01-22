using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGiay.Common
{
    [Serializable]
    public class AdminLogin
    {
        public long AdminID { get; set; }
        public string AdminEmail { get; set; }
    }
}
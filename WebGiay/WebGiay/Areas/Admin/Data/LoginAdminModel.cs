using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebGiay.Areas.Admin.Data
{
    public class LoginAdminModel
    {
        public int ID { get; set; }

        public string DisplayName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email của bạn !")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu của bạn !")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu của bạn !")]
        public string RememberMe { get; set; }
    }
}
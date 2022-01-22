namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên !")]
        [StringLength(255)]
        [Display(Name = "Họ và tên")]
        public string name { get; set; }


        [Required(ErrorMessage = "Vui lòng nhập email của bạn !")]
        [StringLength(255)]
        [Display(Name = "Email")]
        public string email { get; set; }


        [Required(ErrorMessage = "Vui lòng nhập mật khẩu của bạn !")]
        [StringLength(255)]
        [Display(Name = "Mật khẩu")]
        public string password { get; set; }


        [Column(TypeName = "date")]
        [Display(Name = "Ngày tạo")]
        public DateTime? created_at { get; set; }


        [Column(TypeName = "date")]
        [Display(Name = "Ngày cập nhật")]
        public DateTime? updated_at { get; set; }
    }
}

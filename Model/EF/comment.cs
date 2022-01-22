namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comment
    {
        public int id { get; set; }

        [Display(Name = "Sản phẩm")]
        public int? product_id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email của bạn !")]
        [StringLength(255)]
        [Display(Name = "Email")]
        public string user_email { get; set; }

        [Column("comment", TypeName = "text")]
        [Display(Name = "Bình luận")]
        public string comment1 { get; set; }


        [Required(ErrorMessage = "Vui lòng chọn số sao bạn muốn đánh giá !")]
        public int? star { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày tạo")]
        public DateTime? created_at { get; set; }


        [Column(TypeName = "date")]
        [Display(Name = "Ngày cập nhật")]
        public DateTime? updated_at { get; set; }

        public virtual product product { get; set; }
    }
}

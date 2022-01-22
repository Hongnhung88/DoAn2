namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class image
    {
        public int id { get; set; }

        [Display(Name = "Sản phẩm")]
        public int? product_id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string url { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày tạo")]
        public DateTime? created_at { get; set; }


        [Column(TypeName = "date")]
        [Display(Name = "Ngày cập nhật")]
        public DateTime? updated_at { get; set; }

        public virtual product product { get; set; }
    }
}

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            comments = new HashSet<comment>();
            order_details = new HashSet<order_details>();
        }

        public int id { get; set; }


        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm !")]
        [StringLength(255)]
        [Display(Name = "Tên sản phẩm")]
        public string name { get; set; }


        [Required(ErrorMessage = "Vuilongfg nhập giá của sản phẩm !")]
        [Display(Name = "Giá sản phẩm")]
        public double? price { get; set; }


        [Display(Name = "Sale sản phẩm")]
        public double? sale { get; set; }


        [Column(TypeName = "text")]
        [Display(Name = "Thông tin sản phẩm")]
        public string information { get; set; }


        [StringLength(255)]
        [Display(Name = "Ảnh 1")]
        public string image1 { get; set; }


        [StringLength(255)]
        [Display(Name = "Ảnh 2")]
        public string image2 { get; set; }


        [StringLength(255)]
        [Display(Name = "Ảnh 3")]
        public string image3 { get; set; }


        [StringLength(255)]
        [Display(Name = "Ảnh 4")]
        public string image4 { get; set; }


        [Display(Name = "Danh mục sản phẩm")]
        public int? category_id { get; set; }


        [Column(TypeName = "date")]
        [Display(Name = "Ngày tạo")]
        public DateTime? created_at { get; set; }


        [Column(TypeName = "date")]
        [Display(Name = "Ngày cập nhật")]
        public DateTime? updated_at { get; set; }

        public virtual category category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_details> order_details { get; set; }
    }
}

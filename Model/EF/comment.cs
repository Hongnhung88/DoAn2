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

        public int? product_id { get; set; }

        [StringLength(255)]
        public string user_email { get; set; }

        [Column("comment", TypeName = "text")]
        public string comment1 { get; set; }

        public int? star { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public virtual product product { get; set; }
    }
}

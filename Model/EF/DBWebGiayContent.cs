using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.EF
{
    public partial class DBWebGiayContent : DbContext
    {
        public DBWebGiayContent()
            : base("name=DBWebGiayContent")
        {
        }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>()
                .HasMany(e => e.products)
                .WithOptional(e => e.category)
                .HasForeignKey(e => e.category_id);

            modelBuilder.Entity<comment>()
                .Property(e => e.comment1)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.user_phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.order_details)
                .WithOptional(e => e.order)
                .HasForeignKey(e => e.order_id);

            modelBuilder.Entity<product>()
                .Property(e => e.information)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.comments)
                .WithOptional(e => e.product)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<product>()
                .HasMany(e => e.order_details)
                .WithOptional(e => e.product)
                .HasForeignKey(e => e.product_id);
        }
    }
}

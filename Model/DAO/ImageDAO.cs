using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ImageDAO
    {
        WebGiayDbContext db = null;

        public ImageDAO()
        {
            db = new WebGiayDbContext();
        }


        // Tạo mới ảnh cho product
        public long Insert(image entity)
        {
            entity.created_at = DateTime.Now;
            entity.updated_at = DateTime.Now;

            db.images.Add(entity);
            db.SaveChanges();

            return entity.id;
        }


        // Cập nhật ảnh product
        public bool Update(image entity)
        {
            try
            {
                var image = db.images.Find(entity.id);

                image.product_id = entity.product_id;
                image.name = entity.name;
                image.url = entity.url;
                image.updated_at = entity.updated_at;

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        // Xoá hình ảnh product
        public bool Delete(int id)
        {
            try
            {
                var image = db.images.Find(id);

                db.images.Remove(image);
                db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}

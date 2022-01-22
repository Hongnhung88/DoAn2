using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ProductDAO
    {
        DBWebGiayContent db = null;

        public ProductDAO()
        {
            db = new DBWebGiayContent();
        }


        // Tạo mới sản phẩm
        public long Insert(product entity)
        {
            entity.created_at = DateTime.Now;
            entity.updated_at = DateTime.Now;

            db.products.Add(entity);
            db.SaveChanges();

            return entity.id;
        }


        // Chi tiết sản phẩm
        public product Detail(int id)
        {
            return db.products.Find(id);
        }


        // Cập nhật sản phẩm
        public bool Update(product entity)
        {
            try
            {
                var product = db.products.Find(entity.id);

                product.name = entity.name;
                product.price = entity.price;
                product.sale = entity.sale;
                product.information = entity.information;
                product.category_id = entity.category_id;
                product.image1 = entity.image1;
                product.image2 = entity.image2;
                product.image3 = entity.image3;
                product.image4 = entity.image4;
                product.updated_at = DateTime.Now;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        // Xoá sản phẩm
        public bool Delete(int id)
        {
            try
            {
                var product = db.products.Find(id);
                db.products.Remove(product);
                db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }


        public IEnumerable<product> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<product> model = db.products;

            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }


        public List<product> ListOf()
        {
            return db.products.ToList();
        }


        public List<product> ListAll()
        {
            var list = db.Database.SqlQuery<product>("Product_ListAll").ToList();

            return list;
        }


        public List<product> ListNewPro()
        {
            var list = db.Database.SqlQuery<product>("Product_ListNew").ToList();

            return list;
        }


        public IEnumerable<product> ListProductByCategory(int id)
        {
            IQueryable<product> model = db.products;

            model = model.Where((x) => x.category_id == id);

            return model.OrderBy(x => x.id).ToList();
        }
    }
}

using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class CategoryDAO
    {
        DBWebGiayContent db = null;

        public CategoryDAO()
        {
            db = new DBWebGiayContent();
        }


        // Tạo mới danh mục
        public long Insert(category entity)
        {
            entity.created_at = DateTime.Now;
            entity.updated_at = DateTime.Now;   

            db.categories.Add(entity);
            db.SaveChanges();

            return entity.id;
        }


        // Chi tiết danh mục
        public category Detail(int id)
        {
            return db.categories.Find(id);
        }


        // Cập nhật danh mục
        public bool Update(category entity)
        {
            try
            {
                var category = db.categories.Find(entity.id);

                category.name = entity.name;

                category.updated_at= DateTime.Now;

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        // Xoá danh mục
        public bool Delete(int id)
        {
            try
            {
                var category = db.categories.Find(id);

               db.categories.Remove(category);

                db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }


        public IEnumerable<category> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<category> model = db.categories;

            if(!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }


        public List<category> ListOf()
        {
            return db.categories.ToList();
        }
    }
}
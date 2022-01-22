using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class AdminDAO
    {
        DBWebGiayContent db = null;

        public AdminDAO()
        {
            db = new DBWebGiayContent();
        }


        // Tạo mới một Admin
        public long Insert(admin entity)
        {
            entity.created_at = DateTime.Now;
            entity.updated_at = DateTime.Now;

            db.admins.Add(entity);
            db.SaveChanges();

            return entity.id;
        }


        // Details Admin
        public admin Detail(int id)
        {
            return db.admins.Find(id);
        }


        // Cập nhật Admin
        public bool Update(admin entity)
        {
            try
            {
                var admin = db.admins.Find(entity.id);

                if (string.IsNullOrEmpty(entity.name))
                {
                    admin.name = entity.name;
                }

                if(string.IsNullOrEmpty(entity.password))
                {
                    admin.password = entity.password;
                }

                if (string.IsNullOrEmpty(entity.email))
                {
                    admin.email = entity.email;
                }

                admin.updated_at = DateTime.Now;

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        // Xoá Admin
        public bool Delete(int id)
        {
            try
            {
                var admin = db.admins.Find(id);

                db.admins.Remove(admin);

                db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }


        // Đăng nhập
        public int Login(string email, string password)
        {
            var result = db.admins.SingleOrDefault(x => x.email == email);
            if (result == null)
            {
                return 0;
            }else
            {
                if(result.password == password)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }


        public admin GetByID(string email)
        {
            return db.admins.SingleOrDefault(y => y.email == email);
        }


        public List<admin> ListAll()
        {
            return db.Database.SqlQuery<admin>("Admin_ListAll").ToList();
        }


        public IEnumerable<admin> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<admin> model = db.admins;
            if (!string.IsNullOrEmpty(search))
            {
                model =  model.Where(x => x.name.Contains(search) || x.email.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }
    }
}

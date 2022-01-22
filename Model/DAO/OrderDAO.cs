using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class OrderDAO
    {
        WebGiayDbContext db = null;

        public OrderDAO()
        {
            db = new WebGiayDbContext();
        }


        // Tạo đơn hàng
        public long Insert(order entity)
        {
            db.orders.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

    
        // Cập nhật trạng thái đơn hàng
        public bool Update(order entity)
        {
            try
            {
                var order = db.orders.Find(entity.id);
                order.status = 1;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        // Xoá đơn hàng
        public bool Delete(int id)
        {
            try
            {
                var order = db.orders.Find(id);

                db.orders.Remove(order);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<order> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<order> model = db.orders;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.note.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<order> ListOf()
        {
            return db.orders.ToList();
        }

        public IEnumerable<order> Detail(int id)
        {
            IQueryable<order> model = db.orders;
            model = model.Where(x => x.id == id);
            return model.OrderByDescending(x => x.id).ToList();
        }
    }
}

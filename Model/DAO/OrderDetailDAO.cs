using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class OrderDetailDAO
    {
        DBWebGiayContent db = null;

        public OrderDetailDAO()
        {
            db = new DBWebGiayContent();
        }


        public bool Insert(order_details entity)
        {
            try
            {
                db.order_details.Add(entity);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                string query = "DELETE FROM OrdersDetails WHERE order_id = " + id + " ";
                db.Database.ExecuteSqlCommand(query);

                //var order = db.OrdersDetails.Find(id);

                //db.OrdersDetails.Remove(model);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<order_details> Detail(int id)
        {
            IQueryable<order_details> model = db.order_details;
            model = model.Where(x => x.order_id == id);
            return model.OrderByDescending(x => x.id).ToList();
        }
    }
}

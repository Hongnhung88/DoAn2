using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class CommentDAO
    {
        WebGiayDbContext db = null;
        
        public CommentDAO()
        {
            db = new WebGiayDbContext();
        }


        // Tạo mới comment
        public long Insert(comment entity)
        {
            entity.created_at = DateTime.Now;
            entity.updated_at = DateTime.Now;

            db.comments.Add(entity);
            db.SaveChanges();

            return entity.id;
        }


        // Xoá comment
        public bool Delete(int id)
        {
            try
            {
                var comment = db.comments.Find(id);
                db.comments.Remove(comment);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public IEnumerable<comment> ListNewComment(int id)
        {
            IQueryable<comment> model = db.comments;
            model = model.Where(x => x.product_id == id);

            return model.OrderByDescending(x => x.id).ToList();
        }


        public IEnumerable<comment> ListAllPage(int page, int pageSize)
        {
            IQueryable<comment> model = db.comments;

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }


        public List<comment> ListNewCommentAdmin()
        {
            return db.Database.SqlQuery<comment>("CommentAdmin_List").ToList();
        }


        public List<comment> ListOf()
        {
            return db.comments.ToList();
        }
    }
}

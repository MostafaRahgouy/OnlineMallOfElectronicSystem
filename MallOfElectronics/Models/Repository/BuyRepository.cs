using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class BuyRepository
    {
        private MallOfElectronicsEntities db = null;
        public BuyRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(Buy buy)
        {
            db.Buys.Add(buy);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public Buy Find(long id)
        {
            return db.Buys.FirstOrDefault(m => m.TrackingCode == id);
        }
        public bool Delete(Buy buy)
        {
            db.Buys.Remove(buy);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public bool Delete(long id)
        {
            if (this.Delete(this.Find(id)))
                return true;
            return false;
        }
        public bool update(Buy buy)
        {
            db.Buys.Attach(buy);
            db.Entry(buy).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<Buy> Where(System.Linq.Expressions.Expression<Func<Buy, bool>> predicate)
        {
            return db.Buys.Where(predicate);
        }
        public IQueryable<Buy> select()
        {
            return db.Buys.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<Buy, TResult>> selector)
        {
            return db.Buys.Select(selector);
        }
        public List<Buy> where(System.Linq.Expressions.Expression<Func<Buy, bool>> predicate)
        {
            return db.Buys.Where(predicate).ToList();
        }
    }

}
using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class PhoneSupportRepository
    {
        private MallOfElectronicsEntities db = null;
        public PhoneSupportRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(PhoneSupport phoneSupport)
        {
            db.PhoneSupports.Add(phoneSupport);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public PhoneSupport Find(long id)
        {
            return db.PhoneSupports.FirstOrDefault(m => m.id == id);
        }
        public bool Delete(PhoneSupport phoneSupport)
        {
            db.PhoneSupports.Remove(phoneSupport);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public bool Delete(long id)
        {
            PhoneSupport phoneSupport = this.Find(id);
            if (this.Delete(phoneSupport))
                return true;
            return false;
        }
        public bool update(PhoneSupport phoneSupport)
        {
            db.PhoneSupports.Attach(phoneSupport);
            db.Entry(phoneSupport).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<PhoneSupport> Where(System.Linq.Expressions.Expression<Func<PhoneSupport, bool>> predicate)
        {
            return db.PhoneSupports.Where(predicate);
        }
        public IQueryable<PhoneSupport> select()
        {
            return db.PhoneSupports.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<PhoneSupport, TResult>> selector)
        {
            return db.PhoneSupports.Select(selector);
        }
        public List<PhoneSupport> where(System.Linq.Expressions.Expression<Func<PhoneSupport, bool>> predicate)
        {
            return db.PhoneSupports.Where(predicate).ToList();
        }

    }
}
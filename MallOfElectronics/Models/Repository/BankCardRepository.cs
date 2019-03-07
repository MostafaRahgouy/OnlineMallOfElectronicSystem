using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class BankCardRepository
    {
        private MallOfElectronicsEntities db = null;
        public BankCardRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(BankCard bankCard)
        {
            db.BankCards.Add(bankCard);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public BankCard Find(long id)
        {
            return db.BankCards.FirstOrDefault(m => m.CardNumber == id);
        }
        public bool Delete(BankCard bankCard)
        {
            db.BankCards.Remove(bankCard);
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
        public bool update(BankCard bankCard)
        {
            db.BankCards.Attach(bankCard);
            db.Entry(bankCard).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<BankCard> Where(System.Linq.Expressions.Expression<Func<BankCard, bool>> predicate)
        {
            return db.BankCards.Where(predicate);
        }
        public IQueryable<BankCard> select()
        {
            return db.BankCards.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<BankCard, TResult>> selector)
        {
            return db.BankCards.Select(selector);
        }
        public List<BankCard> where(System.Linq.Expressions.Expression<Func<BankCard, bool>> predicate)
        {
            return db.BankCards.Where(predicate).ToList();
        }
    }
}
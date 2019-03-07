using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class CompanyCategoryRepository
    {
        private MallOfElectronicsEntities db = null;
        public CompanyCategoryRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(CompanyCategory companyCategory)
        {
            db.CompanyCategories.Add(companyCategory);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public CompanyCategory Find(long id)
        {
            return db.CompanyCategories.FirstOrDefault(m => m.Id == id);
        }
        public bool Delete(CompanyCategory companyCategory)
        {
            db.CompanyCategories.Remove(companyCategory);
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
        public bool update(CompanyCategory companyCategory)
        {
            db.CompanyCategories.Attach(companyCategory);
            db.Entry(companyCategory).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<CompanyCategory> Where(System.Linq.Expressions.Expression<Func<CompanyCategory, bool>> predicate)
        {
            return db.CompanyCategories.Where(predicate);
        }
        public IQueryable<CompanyCategory> select()
        {
            return db.CompanyCategories.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<CompanyCategory, TResult>> selector)
        {
            return db.CompanyCategories.Select(selector);
        }
        public List<CompanyCategory> where(System.Linq.Expressions.Expression<Func<CompanyCategory, bool>> predicate)
        {
            return db.CompanyCategories.Where(predicate).ToList();
        }
    }
}
using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class CompanyRepository
    {
        private MallOfElectronicsEntities db = null;
        public CompanyRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(Company company)
        {
            db.Companies.Add(company);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public Company Find(long id)
        {
            return db.Companies.FirstOrDefault(m => m.Id == id);
        }
        public bool delete(Company company)
        {
            db.Companies.Remove(company);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public bool delete(long id)
        {
            if (this.delete(this.Find(id)))
                return true;
            return false;
        }
        public bool update(Company company)
        {
            db.Companies.Attach(company);
            db.Entry(company).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public bool update(long id)
        {
            Company company = new Company();
            company = this.Find(id);
            db.Companies.Attach(company);
            db.Entry(company).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<Company> Where(System.Linq.Expressions.Expression<Func<Company, bool>> predicate)
        {
            return db.Companies.Where(predicate);
        }
        public IQueryable<Company> select()
        {
            return db.Companies.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<Company, TResult>> selector)
        {
            return db.Companies.Select(selector);
        }
        public List<Company> where(System.Linq.Expressions.Expression<Func<Company, bool>> predicate)
        {
            return db.Companies.Where(predicate).ToList();
        }
    }
}
using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class CategoriesEntitiesRepository
    {
        private MallOfElectronicsEntities db = null;
        public CategoriesEntitiesRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(CategoriesEntity categoriesEntity)
        {
            db.CategoriesEntities.Add(categoriesEntity);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public CategoriesEntity Find(long id)
        {
            return db.CategoriesEntities.FirstOrDefault(m => m.Id == id);
        }
        public bool Delete(CategoriesEntity categoriesEntity)
        {
            db.CategoriesEntities.Remove(categoriesEntity);
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
        public bool update(CategoriesEntity categoriesEntity)
        {
            db.CategoriesEntities.Attach(categoriesEntity);
            db.Entry(categoriesEntity).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<CategoriesEntity> Where(System.Linq.Expressions.Expression<Func<CategoriesEntity, bool>> predicate)
        {
            return db.CategoriesEntities.Where(predicate);
        }
        public IQueryable<CategoriesEntity> select()
        {
            return db.CategoriesEntities.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<CategoriesEntity, TResult>> selector)
        {
            return db.CategoriesEntities.Select(selector);
        }
        public List<CategoriesEntity> where(System.Linq.Expressions.Expression<Func<CategoriesEntity, bool>> predicate)
        {
            return db.CategoriesEntities.Where(predicate).ToList();
        }
    }
}
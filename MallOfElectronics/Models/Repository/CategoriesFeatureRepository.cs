using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class CategoriesFeatureRepository
    {
        private MallOfElectronicsEntities db = null;
        public CategoriesFeatureRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(CategoriesFeature categoriesFeature)
        {
            db.CategoriesFeatures.Add(categoriesFeature);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public CategoriesFeature Find(long id)
        {
            return db.CategoriesFeatures.FirstOrDefault(m => m.Id == id);
        }
        public bool Delete(CategoriesFeature categoriesFeature)
        {
            db.CategoriesFeatures.Remove(categoriesFeature);
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
        public bool update(CategoriesFeature categoriesFeature)
        {
            db.CategoriesFeatures.Attach(categoriesFeature);
            db.Entry(categoriesFeature).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<CategoriesFeature> Where(System.Linq.Expressions.Expression<Func<CategoriesFeature, bool>> predicate)
        {
            return db.CategoriesFeatures.Where(predicate);
        }
        public IQueryable<CategoriesFeature> select()
        {
            return db.CategoriesFeatures.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<CategoriesFeature, TResult>> selector)
        {
            return db.CategoriesFeatures.Select(selector);
        }
        public List<CategoriesFeature> where(System.Linq.Expressions.Expression<Func<CategoriesFeature, bool>> predicate)
        {
            return db.CategoriesFeatures.Where(predicate).ToList();
        }
    }
}
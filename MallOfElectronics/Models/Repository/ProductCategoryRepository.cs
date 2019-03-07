using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class ProductCategoryRepository
    {
        private MallOfElectronicsEntities db = null;
        public ProductCategoryRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(ProductCategory productCategory)
        {
            db.ProductCategories.Add(productCategory);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public ProductCategory Find(long id)
        {
            return db.ProductCategories.FirstOrDefault(m => m.Id == id);
        }
        public bool Delete(ProductCategory productCategory)
        {
            db.ProductCategories.Remove(productCategory);
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
        public bool update(ProductCategory productCategory)
        {
            db.ProductCategories.Attach(productCategory);
            db.Entry(productCategory).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<ProductCategory> Where(System.Linq.Expressions.Expression<Func<ProductCategory, bool>> predicate)
        {
            return db.ProductCategories.Where(predicate);
        }
        public IQueryable<ProductCategory> select()
        {
            return db.ProductCategories.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<ProductCategory, TResult>> selector)
        {
            return db.ProductCategories.Select(selector);
        }
        public List<ProductCategory> where(System.Linq.Expressions.Expression<Func<ProductCategory, bool>> predicate)
        {
            return db.ProductCategories.Where(predicate).ToList();
        }
    }
}
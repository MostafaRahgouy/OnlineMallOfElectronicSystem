using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class ProductsRepository
    {
        private MallOfElectronicsEntities db = null;
        public ProductsRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(Product product)
        {
            db.Products.Add(product);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public Product Find(long id)
        {
            return db.Products.FirstOrDefault(m => m.Id == id);
        }
        public bool Delete(Product product)
        {
            db.Products.Remove(product);
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
        public bool update(Product product)
        {
            db.Products.Attach(product);
            db.Entry(product).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public bool update(long id)
        {
            Product product = new Product();
            product = this.Find(id);
            db.Products.Attach(product);
            db.Entry(product).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<Product> Where(System.Linq.Expressions.Expression<Func<Product, bool>> predicate)
        {
            return db.Products.Where(predicate);
        }
        public IQueryable<Product> select()
        {
            return db.Products.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<Product, TResult>> selector)
        {
            return db.Products.Select(selector);
        }
        public List<Product> where(System.Linq.Expressions.Expression<Func<Product, bool>> predicate)
        {
            return db.Products.Where(predicate).ToList();
        }
    }
}
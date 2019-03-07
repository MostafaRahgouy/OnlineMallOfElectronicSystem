using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
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
            this.Find(id)
        }
    }
}
using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class PersonRepository
    {
        private MallOfElectronicsEntities db = null;
        public PersonRepository()
        {
            db = new MallOfElectronicsEntities();
        }
        public bool Add(Person person)
        {
            db.People.Add(person);
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public Person Find(string email)
        {
            return db.People.FirstOrDefault(m => m.Email == email);
        }
        public Person Find(long id)
        {
            return db.People.FirstOrDefault(m => m.Id == id);
        }
        public bool Delete(Person person)
        {
            db.People.Remove(person);
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
        public bool update(Person person)
        {
            db.People.Attach(person);
            db.Entry(person).State = EntityState.Modified;
            if (Convert.ToBoolean(db.SaveChanges()))
                return true;
            return false;
        }
        public IQueryable<Person> Where(System.Linq.Expressions.Expression<Func<Person, bool>> predicate)
        {
            return db.People.Where(predicate);
        }
        public IQueryable<Person> select()
        {
            return db.People.AsQueryable();
        }
        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<Person, TResult>> selector)
        {
            return db.People.Select(selector);
        }
        public List<Person> where(System.Linq.Expressions.Expression<Func<Person, bool>> predicate)
        {
            return db.People.Where(predicate).ToList();
        }
    }

}
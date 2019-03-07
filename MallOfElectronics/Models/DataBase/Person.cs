//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MallOfElectronics.Models.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Buys = new HashSet<Buy>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Sex { get; set; }
        public Nullable<System.DateTime> RegisteryDate { get; set; }
        public long IdOfTheCategoryOfPersons { get; set; }
        public string Image { get; set; }
    
        public virtual ICollection<Buy> Buys { get; set; }
        public virtual CategoriesEntity CategoriesEntity { get; set; }
    }
}
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
    
    public partial class BankCard
    {
        public BankCard()
        {
            this.Buys = new HashSet<Buy>();
        }
    
        public long CardNumber { get; set; }
        public int Cvv2 { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int SecondPassword { get; set; }
    
        public virtual ICollection<Buy> Buys { get; set; }
    }
}
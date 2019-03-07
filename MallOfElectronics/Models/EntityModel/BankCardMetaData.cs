using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.EntityModel
{
    public class BankCardMetaData
    {
        [Required(ErrorMessage = " ")]
        [DisplayName("Card Number")]
        [Display(Name = "Card Number")]
        public long CardNumber { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("CVV2")]
        [Display(Name = "CVV2")]
        public int Cvv2 { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Experience Month")]
        [Display(Name = "Experience Month")]
        [Range( 1 , 12 )]
        public int month { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Experience Year")]
        [Display(Name = "Experience Year")]
        [Range( 0 , 99 )]
        public int day { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Second Password")]
        [Display(Name = "Second Password")]
        public int SecondPassword { get; set; }
    }
}
namespace MallOfElectronics.Models.DataBase
{
    [MetadataType(typeof(MallOfElectronics.Models.EntityModel.BankCardMetaData))]
    public partial class BankCard
    {

    }
}
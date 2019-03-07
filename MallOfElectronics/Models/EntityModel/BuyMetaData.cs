using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.EntityModel
{
    public class BuyMetaData
    {

        [ScaffoldColumn(false)]
        [Bindable(false)]
        [DisplayName("Tracking Code")]
        [Display(Name = "Tracking Code")]
        public long TrackingCode { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Buying Day")]
        [Display(Name = "Buying Day")]
        public int Day { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Buying Month")]
        [Display(Name = "Buying Month")]
        public int Month { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Buying Year")]
        [Display(Name = "Buying Year")]
        public int Year { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Customer ID")]
        [Display(Name = "Customer ID")]
        public long CustomerID { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Card Number")]
        [Display(Name = "Card Number")]
        public long CardNumber { get; set; }
    }
}

namespace MallOfElectronics.Models.DataBase
{
    [MetadataType(typeof(MallOfElectronics.Models.EntityModel.BuyMetaData))]
    public partial class Buy
    {

    }
}
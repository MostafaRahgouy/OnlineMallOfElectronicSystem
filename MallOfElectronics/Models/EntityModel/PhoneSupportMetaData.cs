using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.EntityModel
{
    public class PhoneSupportMetaData
    {
        [Required(ErrorMessage = " ")]
        [DisplayName("Company Id")]
        [Display(Name = "Company Id")]
        public long CompanyId { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Number of Phone Support")]
        [Display(Name = "Number of Phone Support")]
        public long PhoneSupport1 { get; set; }
    }
}
namespace MallOfElectronics.Models.DataBase
{
    [MetadataType(typeof(MallOfElectronics.Models.EntityModel.PhoneSupportMetaData))]
    public partial class PhoneSupport
    {

    }
}
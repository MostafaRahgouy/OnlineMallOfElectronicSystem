using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.EntityModel
{
    public class CompanyCategoryRepository
    {
        public long Id { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Name of Category Company")]
        [Display(Name = "Name of Category Company")]
        public string Name { get; set; }
    }
}
namespace MallOfElectronics.Models.DataBase
{
    [MetadataType(typeof(MallOfElectronics.Models.EntityModel.CompanyCategoryRepository))]
    public partial class CompanyCategory
    {

    }
}
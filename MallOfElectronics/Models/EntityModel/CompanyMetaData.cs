using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.EntityModel
{
    public class CompanyMetaData
    {
        public long Id { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Company Name")]
        [Display(Name = "Company Name")]
        public string Name { get; set; }

        [DisplayName("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = " ")]
        [DisplayName("Company Type")]
        [Display(Name = "Company Type")]
        public int CompanyType { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Company Id Categories")]
        [Display(Name = "Company Id Categories")]
        public long CompanyIDCategories { get; set; }

        [DisplayName("Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
namespace MallOfElectronics.Models.DataBase
{
    [MetadataType(typeof(MallOfElectronics.Models.EntityModel.CompanyMetaData))]
    public partial class Company
    {

    }
}
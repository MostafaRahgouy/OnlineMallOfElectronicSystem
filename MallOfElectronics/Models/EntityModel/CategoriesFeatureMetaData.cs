using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.EntityModel
{
    public class CategoriesFeatureMetaData
    {
        public long Id { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Name of Category Attribute")]
        [Display(Name = "Name of Category Attribute")]
        public string Name { get; set; }
    }
}
namespace MallOfElectronics.Models.DataBase
{
    [MetadataType(typeof(MallOfElectronics.Models.EntityModel.CategoriesFeatureMetaData))]
    public partial class CategoriesFeature
    {

    }
}

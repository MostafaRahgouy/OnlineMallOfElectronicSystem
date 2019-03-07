using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.EntityModel
{
    public class ProductCategoryMetaData
    {
        public long Id { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Category Name")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

    }
}
namespace MallOfElectronics.Models.DataBase
{
    [MetadataType(typeof(MallOfElectronics.Models.EntityModel.ProductCategoryMetaData))]
    public partial class ProductCategory
    {

    }
}
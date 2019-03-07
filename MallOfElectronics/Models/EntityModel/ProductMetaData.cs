using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.EntityModel
{
    public class ProductMetaData
    {
        public long Id { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Product Name")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Price")]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Color")]
        [Display(Name = "Color")]
        public string Color { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Count")]
        [Display(Name = "Count")]
        public int Count { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Company Id")]
        [Display(Name = "Company Id")]
        public long CompanyId { get; set; }

       // [Required(ErrorMessage = " ")]
        [DisplayName("Id Of Category Feature")]
        [Display(Name = "Id Of Category Feature")]
        public long IdOfCategoryFeatures { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Wight")]
        [Display(Name = "Wight")]
        public double Weight { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Product Type")]
        [Display(Name = "Product Type")]
        public int ProductType { get; set; }

        [DisplayName("Screen Size")]
        [Display(Name = "Screen Size")]
        public Nullable<double> ScreenSize { get; set; }

        [DisplayName("Memory Size")]
        [Display(Name = "Memory Size")]
        public Nullable<double> MemorySize { get; set; }

        [DisplayName("Brand")]
        [Display(Name = "Brand")]
        public string Brand { get; set; }

        [DisplayName("Precision Camera")]
        [Display(Name = "precision Camera")]
        public Nullable<double> PrecisionCamera { get; set; }
        public string Image { get; set; }

        [DisplayName("Product Id Categories")]
        [Display(Name = "Product Id Categories")]
        public Nullable<long> ProductIDCategories { get; set; }

        [DisplayName("Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
namespace MallOfElectronics.Models.DataBase
{
    [MetadataType(typeof(MallOfElectronics.Models.EntityModel.ProductMetaData))]
    public partial class Product
    {
    }
}

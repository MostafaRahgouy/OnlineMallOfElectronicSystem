using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.EntityModel
{
    public class PersonMetaData
    {
        public long Id { get; set; }
        [Required(ErrorMessage = " ")]
        [DisplayName("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = " ")]
        [DisplayName("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Password")]
        [Display(Name = "Password")]

        public string Password { get; set; }

        [Required(ErrorMessage = " ")]
        [DisplayName("Sex")]
        [Display(Name = "Sex")]
        public bool Sex { get; set; }
        [Required(ErrorMessage = " ")]
        [DisplayName("Registeration Date")]
        [Display(Name = "Registeration Date")]
        public Nullable<System.DateTime> RegisteryDate { get; set; }

        [DisplayName("Id Of The Category Of Persons")]
        [Display(Name = "Id Of The Category Of Persons")]
        public long IdOfTheCategoryOfPersons { get; set; }
        
        [DisplayName("Image")]
        [Display(Name = "Image")]
        public string Image { get; set; }
    }
}
namespace MallOfElectronics.Models.DataBase
{
    [MetadataType(typeof(MallOfElectronics.Models.EntityModel.PersonMetaData))]
    public partial class Person
    {

    }
}
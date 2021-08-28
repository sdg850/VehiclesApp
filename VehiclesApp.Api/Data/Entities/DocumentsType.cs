using System.ComponentModel.DataAnnotations;

namespace VehiclesApp.Api.Data.Entities
{
    public class DocumentsType
    {
        public int id { get; set; }

        [Display(Name = "Documents Type")]
        [MaxLength(50, ErrorMessage = "Field cannot contain more than {1}  caracteres")]
        [Required(ErrorMessage = "The field {0} is required")]
        public string Description { get; set; }

    }
}

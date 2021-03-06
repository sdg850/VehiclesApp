using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehiclesApp.Api.Data.Entities
{
    public class VehiclesType
    {
        public int id { get; set; }

        [Display(Name = "Vehicle type")]
        [MaxLength(50, ErrorMessage ="Field cannot contain more than {1}  caracteres")]
        [Required(ErrorMessage = "The field {0} is required")] 
        public string Description { get; set; }
    }
}

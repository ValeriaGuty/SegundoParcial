using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValeriaGutierrez.Models
{
    public class Naipe
    {
        [Key]
        public String NaipeId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "La longitud debe estar entre {4} y {200}")]
        public String Nombre { get; set; }
        [Url]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public String Imagen { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFPCrecer.Models
{
    public class TipoAfiliacion
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="No puede ser mas de 50 caracteres")]
        public string Nombre { get; set; }
    }
}

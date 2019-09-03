using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFPCrecer.Models
{
    public class Afiliacion
    {
        public int Id { get; set; }
        [Required]
        public int PersonaId { get; set; } 
        [Required]
        public int TipoAfiliacionId { get; set; }
        [Required]
        public DateTime fecha_afiliacion { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual TipoAfiliacion TipoAfiliacion { get; set; }

    }
}

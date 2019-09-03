using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFPCrecer.Models
{
    public class Persona
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="No puede ser mas de 50 Caracteres")]
        public string nombre { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "No puede ser mas de 50 Caracteres")]
        public string Apellido_Paterno { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "No puede ser mas de 50 Caracteres")]
        public string Apellido_Materno { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "No puede ser mas de 50 Caracteres")]
        public DateTime fecha_nac { get; set; }
    }
}

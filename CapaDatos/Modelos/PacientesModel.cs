using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("Pacientes")]
    public class PacientesModel : EntidadBase
    {
        [Key]
        public int PacienteId { get; set; }

        [Required]
        [MaxLength(120)]
        public string Nombres { get; set; }
        [Required]
        [MaxLength(120)]
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
    }
}

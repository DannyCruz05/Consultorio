using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("Citas")]
    public class CitasModel : EntidadBase
    {

        [Key]
        public int CitaId { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        
        [Required]
        [MaxLength(120)]
        public string Nombres { get; set; }
        [Required]
        [MaxLength(120)]
        public string Apellidos { get; set; }
        public DateTime FechaCita { get; set; }
        public bool Estado { get; set; }
    }
}

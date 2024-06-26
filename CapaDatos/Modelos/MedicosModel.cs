﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("Medicos")]
    public class MedicosModel : EntidadBase
    {
        [Key]
        public int MedicoId { get; set; }

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

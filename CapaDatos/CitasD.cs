using CapaDatos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Core;

namespace CapaDatos
{
    public class CitasD
    {
        UnitofWork _unitOfWork;
        Core.Repository<CitasModel> _repository;

        public CitasD()
        {
            _unitOfWork = new UnitofWork();
        }
        public int CitaId { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaCita { get; set; }
        public bool Estado { get; set; }
        public int ClasificacionCitaId { get; set; }

        public List<CitasModel> TodosLasCitas()
        {
            return _repository.Consulta().ToList();
        }

        public int Agregar(CitasModel Cita)
        {
            _unitOfWork.Repository<CitasModel>().Agregar(Cita);
            return _unitOfWork.Guardar(); ;
        }
        
        }
    }

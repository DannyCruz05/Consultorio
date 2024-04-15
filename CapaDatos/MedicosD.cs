using CapaDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MedicosD
    {
        Core.Repository<MedicosModel> _repository;
        public MedicosD()
        {
            _repository = new Core.Repository<MedicosModel>();
        }
        public int MedicoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        public int ClasificacionMedicoId { get; set; }

        public List<MedicosModel> TodosLosMedicos()
        {
            return _repository.Consulta().ToList();
        }

        public int Agregar(MedicosModel Medico)
        {
            Medico.FechaCreacion = DateTime.Now;
            Medico.FechaModificacion = DateTime.Now;
            _repository.Agregar(Medico);

            return 1;
        }
        public int Editar(MedicosModel Medico)
        {
            var MedicoInDb = _repository.Consulta().FirstOrDefault(C => C.MedicoId == Medico.MedicoId);

            if (MedicoInDb != null)
            {
                MedicoInDb.FechaModificacion = DateTime.Now;
                MedicoInDb.Nombres = Medico.Nombres;
                MedicoInDb.Apellidos = Medico.Apellidos;
                MedicoInDb.FechaIngreso = Medico.FechaIngreso;
                MedicoInDb.Estado = Medico.Estado;
                _repository.Editar(MedicoInDb);
                return 1;

            }
            return 0;
        }

        public int Eliminar(int MedicoId)
        {
            var MedicoInDb = _repository.Consulta().FirstOrDefault(C => C.MedicoId == MedicoId);
            if (MedicoInDb != null)
            {
                _repository.Eliminar(MedicoInDb);
                return 1;
            }
            return 0;
        }

        public void Editar(MedicosD Medico)
        {
            throw new NotImplementedException();
        }
    }
}

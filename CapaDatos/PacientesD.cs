using CapaDatos.Modelos;

namespace CapaDatos
{
    public class PacientesD
    {
        Core.Repository<PacientesModel> _repository;
        public PacientesD()
        {
            _repository = new Core.Repository<PacientesModel>();
        }
        public int PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        public int ClasificacionPacienteId { get; set; }

        public List<PacientesModel> TodosLosPacientes()
        {
            return _repository.Consulta().ToList();
        }

        public int Agregar(PacientesModel paciente)
        {
            paciente.FechaCreacion = DateTime.Now;
            paciente.FechaModificacion = DateTime.Now;
            _repository.Agregar(paciente);

            return 1;
        }
        public int Editar(PacientesModel paciente)
        {
            var pacienteInDb = _repository.Consulta().FirstOrDefault(C => C.PacienteId == paciente.PacienteId);

            if (pacienteInDb != null)
            {
                pacienteInDb.FechaModificacion = DateTime.Now;
                pacienteInDb.Nombres = paciente.Nombres;
                pacienteInDb.Apellidos = paciente.Apellidos;
                pacienteInDb.FechaIngreso = paciente.FechaIngreso;
                pacienteInDb.Estado = paciente.Estado;
                _repository.Editar(pacienteInDb);
                return 1;

            }
            return 0;
        }

        public int Eliminar(int pacienteId)
        {
            var pacienteInDb = _repository.Consulta().FirstOrDefault(C => C.PacienteId == pacienteId);
            if (pacienteInDb != null)
            {
                _repository.Eliminar(pacienteInDb);
                return 1;
            }
            return 0;
        }

        public void Editar(PacientesD paciente)
        {
            throw new NotImplementedException();
        }
    }
}

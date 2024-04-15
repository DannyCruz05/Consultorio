using CapaDatos;
using CapaDatos.Modelos;
using CapaNegocios.Common;

namespace CapaNegocios
{
    public class PacientesN

    {
        PacientesD dPaciente;

        public PacientesN()
        {
            dPaciente = new PacientesD();
        }

        public List<PacientesModel> obtenerTodosLosPacientes()
        {
            return dPaciente.TodosLosPacientes();
        }

        public List<PacientesModel> obtenerPacientesActivos()
        {
            return dPaciente.TodosLosPacientes().Where(c => c.Estado == true).ToList();
        }

        public int Guardar(PacientesModel Paciente)
        {
            if (Paciente.PacienteId == 0)
            {
                return dPaciente.Agregar(Paciente);
            }
            else
            {
                return dPaciente.Editar(Paciente);
            }

        }

        public int Eliminar(int PacienteId)
        {
            return dPaciente.Eliminar(PacienteId);
        }
    }
}


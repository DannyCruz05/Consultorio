using CapaDatos.Modelos;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class MedicosN
    {
        MedicosD dMedico;

        public MedicosN()
        {
            dMedico = new MedicosD();
        }

        public List<MedicosModel> obtenerTodosLosMedicos()
        {
            return dMedico.TodosLosMedicos();
        }

        public List<MedicosModel> obtenerMedicosActivos()
        {
            return dMedico.TodosLosMedicos().Where(c => c.Estado == true).ToList();
        }

        public int Guardar(MedicosModel Medico)
        {
            if (Medico.MedicoId == 0)
            {
                return dMedico.Agregar(Medico);
            }
            else
            {
                return dMedico.Editar(Medico);
            }

        }

        public int Eliminar(int MedicoId)
        {
            return dMedico.Eliminar(MedicoId);
        }
    }
}


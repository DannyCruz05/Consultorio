using CapaDatos.Modelos;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CitasN
    {
        CitasD dCita;

        public CitasN()
        {
            dCita = new CitasD();
        }

        public List<CitasModel> obtenerTodasLasCitas()
        {
            return dCita.TodasLasCitas();
        }

        public List<CitasModel> obtenerCitasActivos()
        {
            return dCita.TodasLasCitas().Where(c => c.Estado == true).ToList();
        }

        public int Guardar(CitasModel Cita)
        {
            if (Cita.CitaId == 0)
            {
                return dCita.Agregar(Cita);
            }
            else
            {
                return dCita.Editar(Cita);
            }

        }

        public int Eliminar(int CitaId)
        {
            return dCita.Eliminar(CitaId);
        }
    }
}

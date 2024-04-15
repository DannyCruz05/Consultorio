using CapaDatos.Modelos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCitas : Form
    {
        CitasN CitasN;

        public FormCitas()
        {
            InitializeComponent();
            CitasN = new CitasN();

        }

        private void cargarDatos()
        {
            var Citas = CitasN.obtenerTodasLasCitas()
                                   .ToList()
                                   .Select(c => new { c.CitaId, c.Nombres, c.Apellidos }).ToList();
            dgCitas.DataSource = Citas.ToList();
            CitasN.obtenerTodasLasCitas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CitasModel Cita = new CitasModel()
            {
                Nombres = txtPacienteId.Text,
                Apellidos = txtMedicoId.Text,
                Estado = cbEstado.Checked,
                FechaCita = dtpPaciente.Value
            };
            CitasN.Guardar(Cita);
            cargarDatos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var activo = cbFiltro.Checked;
            var Citas = CitasN.obtenerCitasActivos()
                                   .Where(c => c.Estado == activo)
                                   .ToList()
                                   .Select(c => new { c.CitaId, c.Nombres, c.Apellidos }).ToList();
            dgCitas.DataSource = Citas.ToList();
            CitasN.obtenerCitasActivos();
        }

        private void FormCitas_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}


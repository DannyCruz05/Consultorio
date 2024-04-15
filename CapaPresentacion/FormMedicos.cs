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
    public partial class FormMedicos : Form
    {
        MedicosN MedicosN;

        public FormMedicos()
        {
            InitializeComponent();
            MedicosN = new MedicosN();

        }

        private void cargarDatos()
        {
            var Medicos = MedicosN.obtenerTodosLosMedicos()
                                   .ToList()
                                   .Select(c => new { c.MedicoId, c.Nombres, c.Apellidos }).ToList();
            dgMedicos.DataSource = Medicos.ToList();
            MedicosN.obtenerTodosLosMedicos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MedicosModel Medico = new MedicosModel()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Estado = cbEstado.Checked,
                FechaIngreso = DateTime.Now
            };
            MedicosN.Guardar(Medico);
            cargarDatos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var activo = cbFiltro.Checked;
            var Medicos = MedicosN.obtenerMedicosActivos()
                                   .Where(c => c.Estado == activo)
                                   .ToList()
                                   .Select(c => new { c.MedicoId, c.Nombres, c.Apellidos, c.Estado }).ToList();
            dgMedicos.DataSource = Medicos.ToList();
            MedicosN.obtenerMedicosActivos();
        }

        private void FormMedicos_Load_1(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}

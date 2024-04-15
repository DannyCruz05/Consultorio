using CapaDatos.Modelos;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FormPacientes : Form
    {
        PacientesN PacientesN;

        public FormPacientes()
        {
            InitializeComponent();
            PacientesN = new PacientesN();

        }

        private void cargarDatos()
        {
            var Pacientes = PacientesN.obtenerTodosLosPacientes()
                                   .ToList()
                                   .Select(c => new { c.PacienteId, c.Nombres, c.Apellidos }).ToList();
            dgPaciente.DataSource = Pacientes.ToList();
            PacientesN.obtenerTodosLosPacientes();
        }




        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            PacientesModel Paciente = new PacientesModel()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Estado = cbEstado.Checked,
                FechaIngreso = DateTime.Now
            };
            PacientesN.Guardar(Paciente);
            cargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var activo = cbFiltro.Checked;
            var Pacientes = PacientesN.obtenerPacientesActivos()
                                   .Where(c => c.Estado == activo)
                                   .ToList()
                                   .Select(c => new { c.PacienteId, c.Nombres, c.Apellidos }).ToList();
            dgPaciente.DataSource = Pacientes.ToList();
            PacientesN.obtenerPacientesActivos();
        }

        private void FormPacientes_Load_1(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}

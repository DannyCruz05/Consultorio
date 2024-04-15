using CapaDatos.Modelos;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FormPacientes : Form
    {
        PacientesN PacientesN;
        //NClasificacioPacientesNs nClasificacioPacientesNs;
        //NGrupoPacientes nGrupoPacientes;
        public FormPacientes()
        {
            InitializeComponent();
            //PacientesN = new PacientesN();
            //nClasificacioPacientesNs = new NClasificacioPacientesNs();
            //nGrupoPacientes = new NGrupoPacientes();
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            cargarDatos();
            //cargaCombos();
        }
        private void cargarDatos()
        {
            var Pacientes = PacientesN.obtenerTodosLosPacientes()
                                   .ToList()
                                   .Select(c => new { c.PacienteId, c.Nombres, c.Apellidos }).ToList();
            dgPaciente.DataSource = Pacientes.ToList();//PacientesN.obtenerPaciente();
        }

        //private void cargaCombos()
        //{
        //    cbClasificacion.DataSource = nClasificacioPacientesNs.obtenerClasificacionesPaciente()
        //                                                       .Where(c => c.Estado == true).Select(c => new { c.ClasificacioPacientesNId, c.Descripcion })
        //                                                       .ToList();
        //    cbClasificacion.DisplayMember = "Descripcion";
        //    cbClasificacion.ValueMember = "ClasificacioPacientesNId";
        //    cbFiltroClasificacion.DataSource = nClasificacioPacientesNs.obtenerClasificacionesPaciente()
        //                                                       .Where(c => c.Estado == true).Select(c => new { c.ClasificacioPacientesNId, c.Descripcion })
        //                                                       .ToList();
        //    cbFiltroClasificacion.DisplayMember = "Descripcion";
        //    cbFiltroClasificacion.ValueMember = "ClasificacioPacientesNId";

        //    cbGrupo.DataSource = nGrupoPacientes.obtenerGruposPaciente()
        //                                       .Where(c => c.Estado == true)
        //                                       .Select(c => new { c.GrupoPacienteId, c.Descripcion })
        //                                       .ToList();
        //    cbGrupo.DisplayMember = "Descripcion";
        //    cbGrupo.ValueMember = "GrupoPacienteId";
        //}


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            PacientesModel Paciente = new PacientesModel()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Estado = cbEstado.Checked,
                //ClasificacioPacientesNId = int.Parse(cbClasificacion.SelectedValue.ToString()),
                //GrupoPacienteId = int.Parse(cbGrupo.SelectedValue.ToString()),
                FechaIngreso = DateTime.Now
            };
            PacientesN.Guardar(Paciente);
            cargarDatos();
        }

        private void cbFiltroClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            PacientesModel Paciente = new PacientesModel()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Estado = cbEstado.Checked,
                //ClasificacioPacientesNId = int.Parse(cbClasificacion.SelectedValue.ToString()),
                //GrupoPacienteId = int.Parse(cbGrupo.SelectedValue.ToString()),
                FechaIngreso = DateTime.Now
            };
            PacientesN.Guardar(Paciente);
            cargarDatos();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int clasificacionId = Convert.ToInt32(cbFiltroClasificacion.SelectedValue.ToString());
        //    var activo = cbFiltro.Checked;
        //    var Pacientes = PacientesN.obtenerPaciente()
        //                           .Where(c => c.ClasificacioPacientesNId == clasificacionId &&
        //                                       c.Estado == activo)
        //                           .ToList()
        //                           .Select(c => new { c.PacienteId, c.Codigo, c.Nombres, c.Apellidos, c.ClasificacioPacientesN.Descripcion }).ToList();
        //    dgPaciente.DataSource = Pacientes.ToList();//PacientesN.obtenerPaciente();

        //}
    }
}

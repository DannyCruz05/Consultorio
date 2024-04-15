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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FormPacientes FormPacientes = new FormPacientes();
            FormPacientes.ShowDialog();
        }

        private void BtnMedicos_Click(object sender, EventArgs e)
        {
            FormMedicos FormMedicos = new FormMedicos();
            FormMedicos.ShowDialog();
        }

        private void Citas_Click(object sender, EventArgs e)
        {
            FormCitas FormCitas = new FormCitas();
            FormCitas.ShowDialog();
        }
    }
}

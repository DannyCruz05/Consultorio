namespace CapaPresentacion
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPacientes = new Button();
            BtnMedicos = new Button();
            Citas = new Button();
            SuspendLayout();
            // 
            // btnPacientes
            // 
            btnPacientes.Location = new Point(98, 127);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(112, 47);
            btnPacientes.TabIndex = 70;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnGuardar_Click;
            // 
            // BtnMedicos
            // 
            BtnMedicos.Location = new Point(310, 127);
            BtnMedicos.Name = "BtnMedicos";
            BtnMedicos.Size = new Size(112, 47);
            BtnMedicos.TabIndex = 71;
            BtnMedicos.Text = "Medicos";
            BtnMedicos.UseVisualStyleBackColor = true;
            BtnMedicos.Click += BtnMedicos_Click;
            // 
            // Citas
            // 
            Citas.Location = new Point(511, 127);
            Citas.Name = "Citas";
            Citas.Size = new Size(112, 47);
            Citas.TabIndex = 72;
            Citas.Text = "Citas";
            Citas.UseVisualStyleBackColor = true;
            Citas.Click += Citas_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 318);
            Controls.Add(Citas);
            Controls.Add(BtnMedicos);
            Controls.Add(btnPacientes);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPacientes;
        private Button BtnMedicos;
        private Button Citas;
    }
}
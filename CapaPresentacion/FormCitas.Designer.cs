namespace CapaPresentacion
{
    partial class FormCitas
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
            dtpPaciente = new DateTimePicker();
            cbFiltro = new CheckBox();
            button1 = new Button();
            btnGuardar = new Button();
            txtMedicoId = new TextBox();
            label1 = new Label();
            txtPacienteId = new TextBox();
            label4 = new Label();
            cbEstado = new CheckBox();
            txtCitaId = new TextBox();
            lblEstado = new Label();
            label2 = new Label();
            dgCitas = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCitas).BeginInit();
            SuspendLayout();
            // 
            // dtpPaciente
            // 
            dtpPaciente.Location = new Point(145, 148);
            dtpPaciente.Name = "dtpPaciente";
            dtpPaciente.Size = new Size(259, 23);
            dtpPaciente.TabIndex = 95;
            // 
            // cbFiltro
            // 
            cbFiltro.AutoSize = true;
            cbFiltro.Location = new Point(344, 203);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(89, 19);
            cbFiltro.TabIndex = 94;
            cbFiltro.Text = "Solo activos";
            cbFiltro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(455, 199);
            button1.Name = "button1";
            button1.Size = new Size(66, 22);
            button1.TabIndex = 93;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(550, 174);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 47);
            btnGuardar.TabIndex = 88;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtMedicoId
            // 
            txtMedicoId.Location = new Point(145, 105);
            txtMedicoId.Name = "txtMedicoId";
            txtMedicoId.Size = new Size(184, 23);
            txtMedicoId.TabIndex = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 107);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 84;
            label1.Text = "MedicoId";
            // 
            // txtPacienteId
            // 
            txtPacienteId.Location = new Point(145, 60);
            txtPacienteId.Name = "txtPacienteId";
            txtPacienteId.Size = new Size(184, 23);
            txtPacienteId.TabIndex = 83;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 64);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 82;
            label4.Text = "Paciente Id";
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Location = new Point(147, 189);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(60, 19);
            cbEstado.TabIndex = 81;
            cbEstado.Text = "Activo";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtCitaId
            // 
            txtCitaId.BackColor = SystemColors.ControlLight;
            txtCitaId.Location = new Point(145, 22);
            txtCitaId.Name = "txtCitaId";
            txtCitaId.ReadOnly = true;
            txtCitaId.Size = new Size(88, 23);
            txtCitaId.TabIndex = 80;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(29, 192);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 79;
            lblEstado.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 22);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 78;
            label2.Text = "Cita Id";
            // 
            // dgCitas
            // 
            dgCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCitas.Location = new Point(26, 236);
            dgCitas.Name = "dgCitas";
            dgCitas.RowHeadersWidth = 51;
            dgCitas.RowTemplate.Height = 24;
            dgCitas.Size = new Size(839, 208);
            dgCitas.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 153);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 96;
            label3.Text = "Fecha Cita";
            // 
            // FormCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 494);
            Controls.Add(label3);
            Controls.Add(dtpPaciente);
            Controls.Add(cbFiltro);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(txtMedicoId);
            Controls.Add(label1);
            Controls.Add(txtPacienteId);
            Controls.Add(label4);
            Controls.Add(cbEstado);
            Controls.Add(txtCitaId);
            Controls.Add(lblEstado);
            Controls.Add(label2);
            Controls.Add(dgCitas);
            Name = "FormCitas";
            Text = "FormCitas";
            Load += FormCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpPaciente;
        private CheckBox cbFiltro;
        private Button button1;
        private Button btnGuardar;
        private TextBox txtMedicoId;
        private Label label1;
        private TextBox txtPacienteId;
        private Label label4;
        private CheckBox cbEstado;
        private TextBox txtCitaId;
        private Label lblEstado;
        private Label label2;
        private DataGridView dgCitas;
        private Label label3;
    }
}
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
            cbFiltroClasificacion = new ComboBox();
            label7 = new Label();
            cbGrupo = new ComboBox();
            label6 = new Label();
            btnGuardar = new Button();
            cbClasificacion = new ComboBox();
            label5 = new Label();
            txtMedicoId = new TextBox();
            label1 = new Label();
            txtPacienteId = new TextBox();
            label4 = new Label();
            cbEstado = new CheckBox();
            txtCitaId = new TextBox();
            lblEstado = new Label();
            label2 = new Label();
            dgPaciente = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgPaciente).BeginInit();
            SuspendLayout();
            // 
            // dtpPaciente
            // 
            dtpPaciente.Location = new Point(145, 95);
            dtpPaciente.Name = "dtpPaciente";
            dtpPaciente.Size = new Size(184, 23);
            dtpPaciente.TabIndex = 95;
            // 
            // cbFiltro
            // 
            cbFiltro.AutoSize = true;
            cbFiltro.Location = new Point(346, 260);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(89, 19);
            cbFiltro.TabIndex = 94;
            cbFiltro.Text = "Solo activos";
            cbFiltro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(456, 258);
            button1.Name = "button1";
            button1.Size = new Size(66, 22);
            button1.TabIndex = 93;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbFiltroClasificacion
            // 
            cbFiltroClasificacion.FormattingEnabled = true;
            cbFiltroClasificacion.Location = new Point(145, 257);
            cbFiltroClasificacion.Name = "cbFiltroClasificacion";
            cbFiltroClasificacion.Size = new Size(196, 23);
            cbFiltroClasificacion.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 260);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 91;
            label7.Text = "Filtrar por categoria";
            // 
            // cbGrupo
            // 
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(147, 183);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(196, 23);
            cbGrupo.TabIndex = 90;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(28, 189);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 89;
            label6.Text = "Grupo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(553, 233);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 47);
            btnGuardar.TabIndex = 88;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cbClasificacion
            // 
            cbClasificacion.FormattingEnabled = true;
            cbClasificacion.Location = new Point(147, 149);
            cbClasificacion.Name = "cbClasificacion";
            cbClasificacion.Size = new Size(196, 23);
            cbClasificacion.TabIndex = 87;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 154);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 86;
            label5.Text = "Clasificacion";
            // 
            // txtMedicoId
            // 
            txtMedicoId.Location = new Point(492, 48);
            txtMedicoId.Name = "txtMedicoId";
            txtMedicoId.Size = new Size(184, 23);
            txtMedicoId.TabIndex = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(394, 50);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 84;
            label1.Text = "MedicoId";
            // 
            // txtPacienteId
            // 
            txtPacienteId.Location = new Point(145, 48);
            txtPacienteId.Name = "txtPacienteId";
            txtPacienteId.Size = new Size(184, 23);
            txtPacienteId.TabIndex = 83;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 52);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 82;
            label4.Text = "Paciente Id";
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Location = new Point(147, 219);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(60, 19);
            cbEstado.TabIndex = 81;
            cbEstado.Text = "Activo";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtCitaId
            // 
            txtCitaId.BackColor = SystemColors.ControlLight;
            txtCitaId.Location = new Point(145, 10);
            txtCitaId.Name = "txtCitaId";
            txtCitaId.ReadOnly = true;
            txtCitaId.Size = new Size(88, 23);
            txtCitaId.TabIndex = 80;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(29, 222);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 79;
            lblEstado.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 10);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 78;
            label2.Text = "Cita Id";
            // 
            // dgPaciente
            // 
            dgPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPaciente.Location = new Point(26, 286);
            dgPaciente.Name = "dgPaciente";
            dgPaciente.RowHeadersWidth = 51;
            dgPaciente.RowTemplate.Height = 24;
            dgPaciente.Size = new Size(839, 185);
            dgPaciente.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 100);
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
            Controls.Add(cbFiltroClasificacion);
            Controls.Add(label7);
            Controls.Add(cbGrupo);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(cbClasificacion);
            Controls.Add(label5);
            Controls.Add(txtMedicoId);
            Controls.Add(label1);
            Controls.Add(txtPacienteId);
            Controls.Add(label4);
            Controls.Add(cbEstado);
            Controls.Add(txtCitaId);
            Controls.Add(lblEstado);
            Controls.Add(label2);
            Controls.Add(dgPaciente);
            Name = "FormCitas";
            Text = "FormCitas";
            ((System.ComponentModel.ISupportInitialize)dgPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpPaciente;
        private CheckBox cbFiltro;
        private Button button1;
        private ComboBox cbFiltroClasificacion;
        private Label label7;
        private ComboBox cbGrupo;
        private Label label6;
        private Button btnGuardar;
        private ComboBox cbClasificacion;
        private Label label5;
        private TextBox txtMedicoId;
        private Label label1;
        private TextBox txtPacienteId;
        private Label label4;
        private CheckBox cbEstado;
        private TextBox txtCitaId;
        private Label lblEstado;
        private Label label2;
        private DataGridView dgPaciente;
        private Label label3;
    }
}
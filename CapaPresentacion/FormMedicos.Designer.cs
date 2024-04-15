namespace CapaPresentacion
{
    partial class FormMedicos
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
            txtApellidos = new TextBox();
            label1 = new Label();
            txtNombres = new TextBox();
            label4 = new Label();
            cbEstado = new CheckBox();
            txtMedicoId = new TextBox();
            lblEstado = new Label();
            label2 = new Label();
            dgPaciente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgPaciente).BeginInit();
            SuspendLayout();
            // 
            // dtpPaciente
            // 
            dtpPaciente.Location = new Point(144, 125);
            dtpPaciente.Name = "dtpPaciente";
            dtpPaciente.Size = new Size(244, 23);
            dtpPaciente.TabIndex = 95;
            // 
            // cbFiltro
            // 
            cbFiltro.AutoSize = true;
            cbFiltro.Location = new Point(345, 273);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(89, 19);
            cbFiltro.TabIndex = 94;
            cbFiltro.Text = "Solo activos";
            cbFiltro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(455, 271);
            button1.Name = "button1";
            button1.Size = new Size(66, 22);
            button1.TabIndex = 93;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbFiltroClasificacion
            // 
            cbFiltroClasificacion.FormattingEnabled = true;
            cbFiltroClasificacion.Location = new Point(144, 270);
            cbFiltroClasificacion.Name = "cbFiltroClasificacion";
            cbFiltroClasificacion.Size = new Size(196, 23);
            cbFiltroClasificacion.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 273);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 91;
            label7.Text = "Filtrar por categoria";
            // 
            // cbGrupo
            // 
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(146, 196);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(196, 23);
            cbGrupo.TabIndex = 90;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 202);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 89;
            label6.Text = "Grupo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(552, 246);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 47);
            btnGuardar.TabIndex = 88;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cbClasificacion
            // 
            cbClasificacion.FormattingEnabled = true;
            cbClasificacion.Location = new Point(146, 162);
            cbClasificacion.Name = "cbClasificacion";
            cbClasificacion.Size = new Size(196, 23);
            cbClasificacion.TabIndex = 87;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 167);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 86;
            label5.Text = "Clasificacion";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(144, 94);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(293, 23);
            txtApellidos.TabIndex = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 98);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 84;
            label1.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(144, 61);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(293, 23);
            txtNombres.TabIndex = 83;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 65);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 82;
            label4.Text = "Nombres";
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Location = new Point(146, 232);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(60, 19);
            cbEstado.TabIndex = 81;
            cbEstado.Text = "Activo";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtMedicoId
            // 
            txtMedicoId.BackColor = SystemColors.ControlLight;
            txtMedicoId.Location = new Point(144, 23);
            txtMedicoId.Name = "txtMedicoId";
            txtMedicoId.ReadOnly = true;
            txtMedicoId.Size = new Size(88, 23);
            txtMedicoId.TabIndex = 80;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(28, 235);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 79;
            lblEstado.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 23);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 78;
            label2.Text = "Medico Id";
            // 
            // dgPaciente
            // 
            dgPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPaciente.Location = new Point(25, 299);
            dgPaciente.Name = "dgPaciente";
            dgPaciente.RowHeadersWidth = 51;
            dgPaciente.RowTemplate.Height = 24;
            dgPaciente.Size = new Size(839, 185);
            dgPaciente.TabIndex = 77;
            // 
            // FormMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 617);
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
            Controls.Add(txtApellidos);
            Controls.Add(label1);
            Controls.Add(txtNombres);
            Controls.Add(label4);
            Controls.Add(cbEstado);
            Controls.Add(txtMedicoId);
            Controls.Add(lblEstado);
            Controls.Add(label2);
            Controls.Add(dgPaciente);
            Name = "FormMedicos";
            Text = "FormMedicos";
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
        private TextBox txtApellidos;
        private Label label1;
        private TextBox txtNombres;
        private Label label4;
        private CheckBox cbEstado;
        private TextBox txtMedicoId;
        private Label lblEstado;
        private Label label2;
        private DataGridView dgPaciente;
    }
}
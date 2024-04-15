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
            cbFiltro = new CheckBox();
            button1 = new Button();
            btnGuardar = new Button();
            txtApellidos = new TextBox();
            label1 = new Label();
            txtNombres = new TextBox();
            label4 = new Label();
            cbEstado = new CheckBox();
            txtMedicoId = new TextBox();
            lblEstado = new Label();
            label2 = new Label();
            dgMedicos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgMedicos).BeginInit();
            SuspendLayout();
            // 
            // cbFiltro
            // 
            cbFiltro.AutoSize = true;
            cbFiltro.Location = new Point(345, 153);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(89, 19);
            cbFiltro.TabIndex = 94;
            cbFiltro.Text = "Solo activos";
            cbFiltro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(455, 151);
            button1.Name = "button1";
            button1.Size = new Size(66, 22);
            button1.TabIndex = 93;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(552, 126);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 47);
            btnGuardar.TabIndex = 88;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
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
            cbEstado.Location = new Point(144, 138);
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
            lblEstado.Location = new Point(26, 141);
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
            // dgMedicos
            // 
            dgMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMedicos.Location = new Point(25, 179);
            dgMedicos.Name = "dgMedicos";
            dgMedicos.RowHeadersWidth = 51;
            dgMedicos.RowTemplate.Height = 24;
            dgMedicos.Size = new Size(839, 185);
            dgMedicos.TabIndex = 77;
            // 
            // FormMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 396);
            Controls.Add(cbFiltro);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(txtApellidos);
            Controls.Add(label1);
            Controls.Add(txtNombres);
            Controls.Add(label4);
            Controls.Add(cbEstado);
            Controls.Add(txtMedicoId);
            Controls.Add(lblEstado);
            Controls.Add(label2);
            Controls.Add(dgMedicos);
            Name = "FormMedicos";
            Text = "FormMedicos";
            Load += FormMedicos_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cbFiltro;
        private Button button1;
        private Button btnGuardar;
        private TextBox txtApellidos;
        private Label label1;
        private TextBox txtNombres;
        private Label label4;
        private CheckBox cbEstado;
        private TextBox txtMedicoId;
        private Label lblEstado;
        private Label label2;
        private DataGridView dgMedicos;
    }
}
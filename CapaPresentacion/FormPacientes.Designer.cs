﻿namespace CapaPresentacion
{
    partial class FormPacientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            txtPacienteId = new TextBox();
            lblEstado = new Label();
            label2 = new Label();
            dgPaciente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgPaciente).BeginInit();
            SuspendLayout();
            // 
            // cbFiltro
            // 
            cbFiltro.AutoSize = true;
            cbFiltro.Location = new Point(350, 160);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(89, 19);
            cbFiltro.TabIndex = 75;
            cbFiltro.Text = "Solo activos";
            cbFiltro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(460, 158);
            button1.Name = "button1";
            button1.Size = new Size(66, 22);
            button1.TabIndex = 74;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(557, 133);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 47);
            btnGuardar.TabIndex = 69;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(148, 98);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(293, 23);
            txtApellidos.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 102);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 63;
            label1.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(148, 67);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(293, 23);
            txtNombres.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 69);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 61;
            label4.Text = "Nombres";
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Location = new Point(147, 143);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(60, 19);
            cbEstado.TabIndex = 60;
            cbEstado.Text = "Activo";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtPacienteId
            // 
            txtPacienteId.BackColor = SystemColors.ControlLight;
            txtPacienteId.Location = new Point(148, 27);
            txtPacienteId.Name = "txtPacienteId";
            txtPacienteId.ReadOnly = true;
            txtPacienteId.Size = new Size(88, 23);
            txtPacienteId.TabIndex = 58;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(29, 140);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 57;
            lblEstado.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 27);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 55;
            label2.Text = "Cliente Id";
            // 
            // dgPaciente
            // 
            dgPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPaciente.Location = new Point(29, 186);
            dgPaciente.Name = "dgPaciente";
            dgPaciente.RowHeadersWidth = 51;
            dgPaciente.RowTemplate.Height = 24;
            dgPaciente.Size = new Size(839, 185);
            dgPaciente.TabIndex = 54;
            // 
            // FormPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 441);
            Controls.Add(cbFiltro);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(txtApellidos);
            Controls.Add(label1);
            Controls.Add(txtNombres);
            Controls.Add(label4);
            Controls.Add(cbEstado);
            Controls.Add(txtPacienteId);
            Controls.Add(lblEstado);
            Controls.Add(label2);
            Controls.Add(dgPaciente);
            Name = "FormPacientes";
            Text = "Form1";
            Load += FormPacientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgPaciente).EndInit();
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
        private TextBox txtPacienteId;
        private Label lblEstado;
        private Label label2;
        private DataGridView dgPaciente;
    }
}
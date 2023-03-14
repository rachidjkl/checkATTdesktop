namespace checkATTdesktop.Gestion
{
    partial class GestionarAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCrearModificarAlumno = new System.Windows.Forms.Panel();
            this.buttonEliminarAlumno = new System.Windows.Forms.Button();
            this.buttonModiAlumno = new System.Windows.Forms.Button();
            this.buttonCrearAlumno = new System.Windows.Forms.Button();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.textBoxBuscarAlumno = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.comboBoxSeleccionarClase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_centro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_incorporacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas_cursadas_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año_cursando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCrearModificarAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearModificarAlumno
            // 
            this.panelCrearModificarAlumno.Controls.Add(this.buttonEliminarAlumno);
            this.panelCrearModificarAlumno.Controls.Add(this.buttonModiAlumno);
            this.panelCrearModificarAlumno.Controls.Add(this.buttonCrearAlumno);
            this.panelCrearModificarAlumno.Controls.Add(this.dataGridViewAlumnos);
            this.panelCrearModificarAlumno.Controls.Add(this.textBoxBuscarAlumno);
            this.panelCrearModificarAlumno.Controls.Add(this.iconPictureBox1);
            this.panelCrearModificarAlumno.Controls.Add(this.comboBoxSeleccionarClase);
            this.panelCrearModificarAlumno.Controls.Add(this.label1);
            this.panelCrearModificarAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrearModificarAlumno.Location = new System.Drawing.Point(0, 0);
            this.panelCrearModificarAlumno.Name = "panelCrearModificarAlumno";
            this.panelCrearModificarAlumno.Size = new System.Drawing.Size(948, 537);
            this.panelCrearModificarAlumno.TabIndex = 0;
            // 
            // buttonEliminarAlumno
            // 
            this.buttonEliminarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEliminarAlumno.FlatAppearance.BorderSize = 2;
            this.buttonEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarAlumno.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminarAlumno.Location = new System.Drawing.Point(604, 462);
            this.buttonEliminarAlumno.Name = "buttonEliminarAlumno";
            this.buttonEliminarAlumno.Size = new System.Drawing.Size(138, 34);
            this.buttonEliminarAlumno.TabIndex = 21;
            this.buttonEliminarAlumno.Text = "Eliminar";
            this.buttonEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // buttonModiAlumno
            // 
            this.buttonModiAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiAlumno.FlatAppearance.BorderSize = 2;
            this.buttonModiAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModiAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModiAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiAlumno.Location = new System.Drawing.Point(748, 462);
            this.buttonModiAlumno.Name = "buttonModiAlumno";
            this.buttonModiAlumno.Size = new System.Drawing.Size(153, 34);
            this.buttonModiAlumno.TabIndex = 20;
            this.buttonModiAlumno.Text = "Modificar Alumno";
            this.buttonModiAlumno.UseVisualStyleBackColor = true;
            this.buttonModiAlumno.Click += new System.EventHandler(this.buttonModiAlumno_Click);
            // 
            // buttonCrearAlumno
            // 
            this.buttonCrearAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearAlumno.FlatAppearance.BorderSize = 2;
            this.buttonCrearAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearAlumno.Location = new System.Drawing.Point(763, 57);
            this.buttonCrearAlumno.Name = "buttonCrearAlumno";
            this.buttonCrearAlumno.Size = new System.Drawing.Size(138, 34);
            this.buttonCrearAlumno.TabIndex = 19;
            this.buttonCrearAlumno.Text = "Crear Alumno";
            this.buttonCrearAlumno.UseVisualStyleBackColor = true;
            this.buttonCrearAlumno.Click += new System.EventHandler(this.buttonCrearAlumno_Click_1);
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.AllowUserToAddRows = false;
            this.dataGridViewAlumnos.AllowUserToDeleteRows = false;
            this.dataGridViewAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.email,
            this.email_centro,
            this.telefono,
            this.fecha_nacimiento,
            this.fecha_incorporacion,
            this.direccion,
            this.horas_cursadas_totales,
            this.año_cursando});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlumnos.EnableHeadersVisualStyles = false;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.ReadOnly = true;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(889, 309);
            this.dataGridViewAlumnos.TabIndex = 18;
            // 
            // textBoxBuscarAlumno
            // 
            this.textBoxBuscarAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarAlumno.Location = new System.Drawing.Point(50, 108);
            this.textBoxBuscarAlumno.Name = "textBoxBuscarAlumno";
            this.textBoxBuscarAlumno.Size = new System.Drawing.Size(300, 20);
            this.textBoxBuscarAlumno.TabIndex = 17;
            this.textBoxBuscarAlumno.Text = "Buscar...";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 95);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 16;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click_1);
            // 
            // comboBoxSeleccionarClase
            // 
            this.comboBoxSeleccionarClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeleccionarClase.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeleccionarClase.FormattingEnabled = true;
            this.comboBoxSeleccionarClase.Items.AddRange(new object[] {
            "DAM1",
            "DAW1",
            "SMIX",
            "ASIX",
            "LOL"});
            this.comboBoxSeleccionarClase.Location = new System.Drawing.Point(17, 57);
            this.comboBoxSeleccionarClase.Name = "comboBoxSeleccionarClase";
            this.comboBoxSeleccionarClase.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSeleccionarClase.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clase";
            // 
            // dni
            // 
            this.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido1
            // 
            this.apellido1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellido1.HeaderText = "Apellido1";
            this.apellido1.Name = "apellido1";
            this.apellido1.ReadOnly = true;
            // 
            // apellido2
            // 
            this.apellido2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellido2.HeaderText = "Apellido2";
            this.apellido2.Name = "apellido2";
            this.apellido2.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.HeaderText = "Correo";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // email_centro
            // 
            this.email_centro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email_centro.HeaderText = "Correo_centro";
            this.email_centro.Name = "email_centro";
            this.email_centro.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefono.HeaderText = "Tel";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_nacimiento.HeaderText = "Nacimiento";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
            // 
            // fecha_incorporacion
            // 
            this.fecha_incorporacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_incorporacion.HeaderText = "Incorporación";
            this.fecha_incorporacion.Name = "fecha_incorporacion";
            this.fecha_incorporacion.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // horas_cursadas_totales
            // 
            this.horas_cursadas_totales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horas_cursadas_totales.HeaderText = "Horas cursadas";
            this.horas_cursadas_totales.Name = "horas_cursadas_totales";
            this.horas_cursadas_totales.ReadOnly = true;
            // 
            // año_cursando
            // 
            this.año_cursando.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.año_cursando.HeaderText = "Año cursando";
            this.año_cursando.Name = "año_cursando";
            this.año_cursando.ReadOnly = true;
            // 
            // GestionarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(948, 537);
            this.Controls.Add(this.panelCrearModificarAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarAlumnos";
            this.Text = "GestionarAlumnos";
            this.panelCrearModificarAlumno.ResumeLayout(false);
            this.panelCrearModificarAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearModificarAlumno;
        private System.Windows.Forms.Button buttonModiAlumno;
        private System.Windows.Forms.Button buttonCrearAlumno;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.TextBox textBoxBuscarAlumno;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox comboBoxSeleccionarClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminarAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_incorporacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas_cursadas_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn año_cursando;
    }
}
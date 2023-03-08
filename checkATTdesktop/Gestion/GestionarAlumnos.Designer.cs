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
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corre_centro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorporacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas_cursadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscarAlumno = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.comboBoxSeleccionarClase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonModiAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonCrearAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido1,
            this.Apellido2,
            this.DNI,
            this.Correo,
            this.corre_centro,
            this.TELEFONO,
            this.nacimiento,
            this.incorporacion,
            this.Direction,
            this.horas_cursadas,
            this.año});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlumnos.EnableHeadersVisualStyles = false;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.ReadOnly = true;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(889, 294);
            this.dataGridViewAlumnos.TabIndex = 18;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 60;
            // 
            // Apellido1
            // 
            this.Apellido1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apellido1.FillWeight = 69.85402F;
            this.Apellido1.HeaderText = "Apellido1";
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.ReadOnly = true;
            this.Apellido1.Width = 74;
            // 
            // Apellido2
            // 
            this.Apellido2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apellido2.FillWeight = 69.85402F;
            this.Apellido2.HeaderText = "Apellido2";
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.ReadOnly = true;
            this.Apellido2.Width = 73;
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DNI.FillWeight = 401.4598F;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 45;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Correo.FillWeight = 69.85402F;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 50;
            // 
            // corre_centro
            // 
            this.corre_centro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.corre_centro.FillWeight = 69.85402F;
            this.corre_centro.HeaderText = "Correo_CEP";
            this.corre_centro.Name = "corre_centro";
            this.corre_centro.ReadOnly = true;
            this.corre_centro.Width = 85;
            // 
            // TELEFONO
            // 
            this.TELEFONO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TELEFONO.FillWeight = 69.85402F;
            this.TELEFONO.HeaderText = "Telf";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Width = 40;
            // 
            // nacimiento
            // 
            this.nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nacimiento.FillWeight = 69.85402F;
            this.nacimiento.HeaderText = "Nacimiento";
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.ReadOnly = true;
            this.nacimiento.Width = 80;
            // 
            // incorporacion
            // 
            this.incorporacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.incorporacion.FillWeight = 69.85402F;
            this.incorporacion.HeaderText = "Incorporación";
            this.incorporacion.Name = "incorporacion";
            this.incorporacion.ReadOnly = true;
            // 
            // Direction
            // 
            this.Direction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Direction.FillWeight = 69.85402F;
            this.Direction.HeaderText = "Direc";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            this.Direction.Width = 50;
            // 
            // horas_cursadas
            // 
            this.horas_cursadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.horas_cursadas.FillWeight = 69.85402F;
            this.horas_cursadas.HeaderText = "Horas cursadas";
            this.horas_cursadas.Name = "horas_cursadas";
            this.horas_cursadas.ReadOnly = true;
            this.horas_cursadas.Width = 94;
            // 
            // año
            // 
            this.año.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.año.FillWeight = 69.85402F;
            this.año.HeaderText = "Año cursando";
            this.año.Name = "año";
            this.año.ReadOnly = true;
            this.año.Width = 95;
            // 
            // textBoxBuscarAlumno
            // 
            this.textBoxBuscarAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarAlumno.Location = new System.Drawing.Point(50, 108);
            this.textBoxBuscarAlumno.Name = "textBoxBuscarAlumno";
            this.textBoxBuscarAlumno.Size = new System.Drawing.Size(300, 19);
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
            this.comboBoxSeleccionarClase.FormattingEnabled = true;
            this.comboBoxSeleccionarClase.Items.AddRange(new object[] {
            "DAM1",
            "DAW1",
            "SMIX",
            "ASIX",
            "LOL"});
            this.comboBoxSeleccionarClase.Location = new System.Drawing.Point(17, 57);
            this.comboBoxSeleccionarClase.Name = "comboBoxSeleccionarClase";
            this.comboBoxSeleccionarClase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSeleccionarClase.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clase";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn corre_centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorporacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas_cursadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
    }
}
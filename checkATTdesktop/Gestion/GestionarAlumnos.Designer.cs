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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCrearModificarAlumno = new System.Windows.Forms.Panel();
            this.buttonMatricularAlumnosUF = new System.Windows.Forms.Button();
            this.buttonEliminarAlumno = new System.Windows.Forms.Button();
            this.buttonModiAlumno = new System.Windows.Forms.Button();
            this.buttonCrearAlumno = new System.Windows.Forms.Button();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.dnialumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrealumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1alumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorpalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añocursandoalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDataGridAlumnos = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscarAlumno = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.comboBoxSeleccionarClase = new System.Windows.Forms.ComboBox();
            this.bindingSourceComboBoxClase = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelCrearModificarAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboBoxClase)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearModificarAlumno
            // 
            this.panelCrearModificarAlumno.Controls.Add(this.buttonMatricularAlumnosUF);
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
            // buttonMatricularAlumnosUF
            // 
            this.buttonMatricularAlumnosUF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonMatricularAlumnosUF.FlatAppearance.BorderSize = 2;
            this.buttonMatricularAlumnosUF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatricularAlumnosUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatricularAlumnosUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonMatricularAlumnosUF.Location = new System.Drawing.Point(12, 480);
            this.buttonMatricularAlumnosUF.Name = "buttonMatricularAlumnosUF";
            this.buttonMatricularAlumnosUF.Size = new System.Drawing.Size(153, 34);
            this.buttonMatricularAlumnosUF.TabIndex = 22;
            this.buttonMatricularAlumnosUF.Text = "Matricular en UF";
            this.buttonMatricularAlumnosUF.UseVisualStyleBackColor = true;
            this.buttonMatricularAlumnosUF.Click += new System.EventHandler(this.buttonMatricularAlumnosUF_Click);
            // 
            // buttonEliminarAlumno
            // 
            this.buttonEliminarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEliminarAlumno.FlatAppearance.BorderSize = 2;
            this.buttonEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarAlumno.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminarAlumno.Location = new System.Drawing.Point(604, 480);
            this.buttonEliminarAlumno.Name = "buttonEliminarAlumno";
            this.buttonEliminarAlumno.Size = new System.Drawing.Size(138, 34);
            this.buttonEliminarAlumno.TabIndex = 21;
            this.buttonEliminarAlumno.Text = "Eliminar";
            this.buttonEliminarAlumno.UseVisualStyleBackColor = true;
            this.buttonEliminarAlumno.Click += new System.EventHandler(this.buttonEliminarAlumno_Click);
            // 
            // buttonModiAlumno
            // 
            this.buttonModiAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiAlumno.FlatAppearance.BorderSize = 2;
            this.buttonModiAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModiAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModiAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiAlumno.Location = new System.Drawing.Point(748, 480);
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
            this.dataGridViewAlumnos.AutoGenerateColumns = false;
            this.dataGridViewAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dnialumnoDataGridViewTextBoxColumn,
            this.nombrealumnoDataGridViewTextBoxColumn,
            this.apellido1alumnoDataGridViewTextBoxColumn,
            this.emailalumnoDataGridViewTextBoxColumn,
            this.telalumnoDataGridViewTextBoxColumn,
            this.nacimientoalumnoDataGridViewTextBoxColumn,
            this.incorpalumnoDataGridViewTextBoxColumn,
            this.direccionalumnoDataGridViewTextBoxColumn,
            this.añocursandoalumnoDataGridViewTextBoxColumn});
            this.dataGridViewAlumnos.DataSource = this.bindingSourceDataGridAlumnos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlumnos.EnableHeadersVisualStyles = false;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.ReadOnly = true;
            this.dataGridViewAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(889, 341);
            this.dataGridViewAlumnos.TabIndex = 18;
            this.dataGridViewAlumnos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAlumnos_CellFormatting);
            // 
            // dnialumnoDataGridViewTextBoxColumn
            // 
            this.dnialumnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dnialumnoDataGridViewTextBoxColumn.DataPropertyName = "dni_alumno";
            this.dnialumnoDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dnialumnoDataGridViewTextBoxColumn.Name = "dnialumnoDataGridViewTextBoxColumn";
            this.dnialumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrealumnoDataGridViewTextBoxColumn
            // 
            this.nombrealumnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrealumnoDataGridViewTextBoxColumn.DataPropertyName = "nombre_alumno";
            this.nombrealumnoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrealumnoDataGridViewTextBoxColumn.Name = "nombrealumnoDataGridViewTextBoxColumn";
            this.nombrealumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido1alumnoDataGridViewTextBoxColumn
            // 
            this.apellido1alumnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellido1alumnoDataGridViewTextBoxColumn.DataPropertyName = "apellido1_alumno";
            this.apellido1alumnoDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellido1alumnoDataGridViewTextBoxColumn.Name = "apellido1alumnoDataGridViewTextBoxColumn";
            this.apellido1alumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailalumnoDataGridViewTextBoxColumn
            // 
            this.emailalumnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailalumnoDataGridViewTextBoxColumn.DataPropertyName = "email_alumno";
            this.emailalumnoDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailalumnoDataGridViewTextBoxColumn.Name = "emailalumnoDataGridViewTextBoxColumn";
            this.emailalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telalumnoDataGridViewTextBoxColumn
            // 
            this.telalumnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telalumnoDataGridViewTextBoxColumn.DataPropertyName = "tel_alumno";
            this.telalumnoDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telalumnoDataGridViewTextBoxColumn.Name = "telalumnoDataGridViewTextBoxColumn";
            this.telalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacimientoalumnoDataGridViewTextBoxColumn
            // 
            this.nacimientoalumnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nacimientoalumnoDataGridViewTextBoxColumn.DataPropertyName = "nacimiento_alumno";
            this.nacimientoalumnoDataGridViewTextBoxColumn.HeaderText = "Nacimiento";
            this.nacimientoalumnoDataGridViewTextBoxColumn.Name = "nacimientoalumnoDataGridViewTextBoxColumn";
            this.nacimientoalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incorpalumnoDataGridViewTextBoxColumn
            // 
            this.incorpalumnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.incorpalumnoDataGridViewTextBoxColumn.DataPropertyName = "incorp_alumno";
            this.incorpalumnoDataGridViewTextBoxColumn.HeaderText = "Incorp";
            this.incorpalumnoDataGridViewTextBoxColumn.Name = "incorpalumnoDataGridViewTextBoxColumn";
            this.incorpalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionalumnoDataGridViewTextBoxColumn
            // 
            this.direccionalumnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccionalumnoDataGridViewTextBoxColumn.DataPropertyName = "direccion_alumno";
            this.direccionalumnoDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionalumnoDataGridViewTextBoxColumn.Name = "direccionalumnoDataGridViewTextBoxColumn";
            this.direccionalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // añocursandoalumnoDataGridViewTextBoxColumn
            // 
            this.añocursandoalumnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.añocursandoalumnoDataGridViewTextBoxColumn.DataPropertyName = "año_cursando_alumno";
            this.añocursandoalumnoDataGridViewTextBoxColumn.HeaderText = "Cursando";
            this.añocursandoalumnoDataGridViewTextBoxColumn.Name = "añocursandoalumnoDataGridViewTextBoxColumn";
            this.añocursandoalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceDataGridAlumnos
            // 
            this.bindingSourceDataGridAlumnos.DataSource = typeof(checkATTdesktop.Models.Alumno);
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
            this.comboBoxSeleccionarClase.DataSource = this.bindingSourceComboBoxClase;
            this.comboBoxSeleccionarClase.DisplayMember = "nombre_clase";
            this.comboBoxSeleccionarClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeleccionarClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeleccionarClase.FormattingEnabled = true;
            this.comboBoxSeleccionarClase.Location = new System.Drawing.Point(17, 57);
            this.comboBoxSeleccionarClase.Name = "comboBoxSeleccionarClase";
            this.comboBoxSeleccionarClase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSeleccionarClase.TabIndex = 15;
            this.comboBoxSeleccionarClase.ValueMember = "id_clase";
            this.comboBoxSeleccionarClase.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeleccionarClase_SelectedIndexChanged);
            // 
            // bindingSourceComboBoxClase
            // 
            this.bindingSourceComboBoxClase.DataSource = typeof(checkATTdesktop.Models.Clase);
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
            this.Load += new System.EventHandler(this.GestionarAlumnos_Load);
            this.panelCrearModificarAlumno.ResumeLayout(false);
            this.panelCrearModificarAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboBoxClase)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceComboBoxClase;
        private System.Windows.Forms.BindingSource bindingSourceDataGridAlumnos;
        private System.Windows.Forms.Button buttonMatricularAlumnosUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnialumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrealumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1alumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcentroalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorpalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añocursandoalumnoDataGridViewTextBoxColumn;
    }
}
namespace checkATTdesktop.Gestion
{
    partial class GestionarProfesores
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
            this.panelCrearModificarProfesores = new System.Windows.Forms.Panel();
            this.buttonEliminarProfesor = new System.Windows.Forms.Button();
            this.buttonModiProfesor = new System.Windows.Forms.Button();
            this.buttonCrearProfesor = new System.Windows.Forms.Button();
            this.dataGridViewProfesor = new System.Windows.Forms.DataGridView();
            this.textBoxBuscarProfesor = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.bindingSourceDataGridProfesores = new System.Windows.Forms.BindingSource(this.components);
            this.dniprofeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreprofeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1profeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailprofeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user_profe_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telprofeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoprofeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorpprofeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionprofeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDataGridProfesores = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscarProfesor = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelCrearModificarProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearModificarProfesores
            // 
            this.panelCrearModificarProfesores.Controls.Add(this.buttonEliminarProfesor);
            this.panelCrearModificarProfesores.Controls.Add(this.buttonModiProfesor);
            this.panelCrearModificarProfesores.Controls.Add(this.buttonCrearProfesor);
            this.panelCrearModificarProfesores.Controls.Add(this.dataGridViewProfesor);
            this.panelCrearModificarProfesores.Controls.Add(this.textBoxBuscarProfesor);
            this.panelCrearModificarProfesores.Controls.Add(this.iconPictureBox1);
            this.panelCrearModificarProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrearModificarProfesores.Location = new System.Drawing.Point(0, 0);
            this.panelCrearModificarProfesores.Name = "panelCrearModificarProfesores";
            this.panelCrearModificarProfesores.Size = new System.Drawing.Size(948, 537);
            this.panelCrearModificarProfesores.TabIndex = 0;
            // 
            // buttonEliminarProfesor
            // 
            this.buttonEliminarProfesor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEliminarProfesor.FlatAppearance.BorderSize = 2;
            this.buttonEliminarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarProfesor.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminarProfesor.Location = new System.Drawing.Point(595, 469);
            this.buttonEliminarProfesor.Name = "buttonEliminarProfesor";
            this.buttonEliminarProfesor.Size = new System.Drawing.Size(138, 34);
            this.buttonEliminarProfesor.TabIndex = 24;
            this.buttonEliminarProfesor.Text = "Eliminar";
            this.buttonEliminarProfesor.UseVisualStyleBackColor = true;
            this.buttonEliminarProfesor.Click += new System.EventHandler(this.buttonEliminarProfesor_Click);
            // 
            // buttonModiProfesor
            // 
            this.buttonModiProfesor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiProfesor.FlatAppearance.BorderSize = 2;
            this.buttonModiProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModiProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModiProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiProfesor.Location = new System.Drawing.Point(739, 469);
            this.buttonModiProfesor.Name = "buttonModiProfesor";
            this.buttonModiProfesor.Size = new System.Drawing.Size(168, 34);
            this.buttonModiProfesor.TabIndex = 23;
            this.buttonModiProfesor.Text = "Modificar Profesor";
            this.buttonModiProfesor.UseVisualStyleBackColor = true;
            this.buttonModiProfesor.Click += new System.EventHandler(this.buttonModiProfesor_Click);
            // 
            // buttonCrearProfesor
            // 
            this.buttonCrearProfesor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearProfesor.FlatAppearance.BorderSize = 2;
            this.buttonCrearProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearProfesor.Location = new System.Drawing.Point(769, 27);
            this.buttonCrearProfesor.Name = "buttonCrearProfesor";
            this.buttonCrearProfesor.Size = new System.Drawing.Size(138, 34);
            this.buttonCrearProfesor.TabIndex = 22;
            this.buttonCrearProfesor.Text = "Crear Profesor";
            this.buttonCrearProfesor.UseVisualStyleBackColor = true;
            this.buttonCrearProfesor.Click += new System.EventHandler(this.buttonCrearProfesor_Click);
            // 
            // dataGridViewProfesor
            // 
            this.dataGridViewProfesor.AllowUserToAddRows = false;
            this.dataGridViewProfesor.AutoGenerateColumns = false;
            this.dataGridViewProfesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniprofeDataGridViewTextBoxColumn,
            this.nombreprofeDataGridViewTextBoxColumn,
            this.apellido1profeDataGridViewTextBoxColumn,
            this.emailprofeDataGridViewTextBoxColumn,
            this.id_user_profe_cep,
            this.telprofeDataGridViewTextBoxColumn,
            this.nacimientoprofeDataGridViewTextBoxColumn,
            this.incorpprofeDataGridViewTextBoxColumn,
            this.direccionprofeDataGridViewTextBoxColumn});
            this.dataGridViewProfesor.DataSource = this.bindingSourceDataGridProfesores;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProfesor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProfesor.EnableHeadersVisualStyles = false;
            this.dataGridViewProfesor.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewProfesor.Name = "dataGridViewProfesor";
            this.dataGridViewProfesor.ReadOnly = true;
            this.dataGridViewProfesor.Size = new System.Drawing.Size(895, 361);
            this.dataGridViewProfesor.TabIndex = 21;
            this.dataGridViewProfesor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewProfesor_CellFormatting);
            // 
            // textBoxBuscarProfesor
            // 
            this.textBoxBuscarProfesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarProfesor.Location = new System.Drawing.Point(50, 41);
            this.textBoxBuscarProfesor.Name = "textBoxBuscarProfesor";
            this.textBoxBuscarProfesor.Size = new System.Drawing.Size(300, 19);
            this.textBoxBuscarProfesor.TabIndex = 20;
            this.textBoxBuscarProfesor.Text = "Buscar...";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 19;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // bindingSourceDataGridProfesores
            // 
            this.bindingSourceDataGridProfesores.DataSource = typeof(checkATTdesktop.Models.Profesor);
            // 
            // dniprofeDataGridViewTextBoxColumn
            // 
            this.dniprofeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dniprofeDataGridViewTextBoxColumn.DataPropertyName = "dni_profe";
            this.dniprofeDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dniprofeDataGridViewTextBoxColumn.Name = "dniprofeDataGridViewTextBoxColumn";
            this.dniprofeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreprofeDataGridViewTextBoxColumn
            // 
            this.nombreprofeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreprofeDataGridViewTextBoxColumn.DataPropertyName = "nombre_profe";
            this.nombreprofeDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreprofeDataGridViewTextBoxColumn.Name = "nombreprofeDataGridViewTextBoxColumn";
            this.nombreprofeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido1profeDataGridViewTextBoxColumn
            // 
            this.apellido1profeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellido1profeDataGridViewTextBoxColumn.DataPropertyName = "apellido1_profe";
            this.apellido1profeDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellido1profeDataGridViewTextBoxColumn.Name = "apellido1profeDataGridViewTextBoxColumn";
            this.apellido1profeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido2profeDataGridViewTextBoxColumn
            // 
            this.apellido2profeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellido2profeDataGridViewTextBoxColumn.DataPropertyName = "apellido2_profe";
            this.apellido2profeDataGridViewTextBoxColumn.HeaderText = "Apellido2";
            this.apellido2profeDataGridViewTextBoxColumn.Name = "apellido2profeDataGridViewTextBoxColumn";
            this.apellido2profeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailprofeDataGridViewTextBoxColumn
            // 
            this.emailprofeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailprofeDataGridViewTextBoxColumn.DataPropertyName = "email_profe";
            this.emailprofeDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailprofeDataGridViewTextBoxColumn.Name = "emailprofeDataGridViewTextBoxColumn";
            this.emailprofeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id_user_profe_cep
            // 
            this.id_user_profe_cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_user_profe_cep.DataPropertyName = "id_user_profe_cep";
            this.id_user_profe_cep.HeaderText = "EmailCep";
            this.id_user_profe_cep.Name = "id_user_profe_cep";
            this.id_user_profe_cep.ReadOnly = true;
            // 
            // telprofeDataGridViewTextBoxColumn
            // 
            this.telprofeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telprofeDataGridViewTextBoxColumn.DataPropertyName = "tel_profe";
            this.telprofeDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telprofeDataGridViewTextBoxColumn.Name = "telprofeDataGridViewTextBoxColumn";
            this.telprofeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacimientoprofeDataGridViewTextBoxColumn
            // 
            this.nacimientoprofeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nacimientoprofeDataGridViewTextBoxColumn.DataPropertyName = "nacimiento_profe";
            this.nacimientoprofeDataGridViewTextBoxColumn.HeaderText = "Nacimiento";
            this.nacimientoprofeDataGridViewTextBoxColumn.Name = "nacimientoprofeDataGridViewTextBoxColumn";
            this.nacimientoprofeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incorpprofeDataGridViewTextBoxColumn
            // 
            this.incorpprofeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.incorpprofeDataGridViewTextBoxColumn.DataPropertyName = "incorp_profe";
            this.incorpprofeDataGridViewTextBoxColumn.HeaderText = "Incorp";
            this.incorpprofeDataGridViewTextBoxColumn.Name = "incorpprofeDataGridViewTextBoxColumn";
            this.incorpprofeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionprofeDataGridViewTextBoxColumn
            // 
            this.direccionprofeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccionprofeDataGridViewTextBoxColumn.DataPropertyName = "direccion_profe";
            this.direccionprofeDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionprofeDataGridViewTextBoxColumn.Name = "direccionprofeDataGridViewTextBoxColumn";
            this.direccionprofeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceDataGridProfesores
            // 
            this.bindingSourceDataGridProfesores.DataSource = typeof(checkATTdesktop.Models.Profesor);
            // 
            // textBoxBuscarProfesor
            // 
            this.textBoxBuscarProfesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarProfesor.Location = new System.Drawing.Point(50, 41);
            this.textBoxBuscarProfesor.Name = "textBoxBuscarProfesor";
            this.textBoxBuscarProfesor.Size = new System.Drawing.Size(300, 19);
            this.textBoxBuscarProfesor.TabIndex = 20;
            this.textBoxBuscarProfesor.Text = "Buscar...";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 19;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // GestionarProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(948, 537);
            this.Controls.Add(this.panelCrearModificarProfesores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarProfesores";
            this.Text = "GestionarProfesores";
            this.Load += new System.EventHandler(this.GestionarProfesores_Load);
            this.panelCrearModificarProfesores.ResumeLayout(false);
            this.panelCrearModificarProfesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearModificarProfesores;
        private System.Windows.Forms.DataGridView dataGridViewProfesor;
        private System.Windows.Forms.TextBox textBoxBuscarProfesor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button buttonCrearProfesor;
        private System.Windows.Forms.Button buttonEliminarProfesor;
        private System.Windows.Forms.Button buttonModiProfesor;
        private System.Windows.Forms.BindingSource bindingSourceDataGridProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcentroprofeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniprofeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreprofeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1profeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailprofeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user_profe_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn telprofeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoprofeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorpprofeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionprofeDataGridViewTextBoxColumn;
    }
}
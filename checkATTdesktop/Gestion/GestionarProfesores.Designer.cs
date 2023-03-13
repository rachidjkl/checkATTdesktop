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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCrearModificarProfesores = new System.Windows.Forms.Panel();
            this.buttonEliminarProfesor = new System.Windows.Forms.Button();
            this.buttonModiProfesor = new System.Windows.Forms.Button();
            this.buttonCrearProfesor = new System.Windows.Forms.Button();
            this.dataGridViewProfesor = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscarProfesor = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelCrearModificarProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
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
            this.buttonEliminarProfesor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarProfesor.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminarProfesor.Location = new System.Drawing.Point(595, 469);
            this.buttonEliminarProfesor.Name = "buttonEliminarProfesor";
            this.buttonEliminarProfesor.Size = new System.Drawing.Size(138, 34);
            this.buttonEliminarProfesor.TabIndex = 24;
            this.buttonEliminarProfesor.Text = "Eliminar";
            this.buttonEliminarProfesor.UseVisualStyleBackColor = true;
            // 
            // buttonModiProfesor
            // 
            this.buttonModiProfesor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiProfesor.FlatAppearance.BorderSize = 2;
            this.buttonModiProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModiProfesor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonCrearProfesor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearProfesor.Location = new System.Drawing.Point(769, 75);
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
            this.dataGridViewProfesor.AllowUserToDeleteRows = false;
            this.dataGridViewProfesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.apellido2,
            this.Correo,
            this.Column1,
            this.DNI,
            this.TELEFONO,
            this.Column2,
            this.Column3,
            this.Direction});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProfesor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProfesor.EnableHeadersVisualStyles = false;
            this.dataGridViewProfesor.Location = new System.Drawing.Point(41, 121);
            this.dataGridViewProfesor.Name = "dataGridViewProfesor";
            this.dataGridViewProfesor.ReadOnly = true;
            this.dataGridViewProfesor.Size = new System.Drawing.Size(866, 307);
            this.dataGridViewProfesor.TabIndex = 21;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.HeaderText = "Apellido1";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // apellido2
            // 
            this.apellido2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellido2.HeaderText = "Apellido2";
            this.apellido2.Name = "apellido2";
            this.apellido2.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Correo_CEP";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TELEFONO.HeaderText = "Telf";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Fecha nacimiento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Fecha incorporación";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Direction
            // 
            this.Direction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direction.HeaderText = "Dirección";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            // 
            // textBoxBuscarProfesor
            // 
            this.textBoxBuscarProfesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarProfesor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarProfesor.Location = new System.Drawing.Point(80, 84);
            this.textBoxBuscarProfesor.Name = "textBoxBuscarProfesor";
            this.textBoxBuscarProfesor.Size = new System.Drawing.Size(300, 20);
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
            this.iconPictureBox1.Location = new System.Drawing.Point(42, 71);
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
            this.panelCrearModificarProfesores.ResumeLayout(false);
            this.panelCrearModificarProfesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
    }
}
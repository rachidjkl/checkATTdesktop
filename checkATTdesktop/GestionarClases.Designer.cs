namespace checkATTdesktop
{
    partial class GestionarClases
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
            this.buttonEliminarClase = new System.Windows.Forms.Button();
            this.buttonModiClase = new System.Windows.Forms.Button();
            this.buttonCrearClase = new System.Windows.Forms.Button();
            this.dataGridViewClase = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscarClase = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminarClase
            // 
            this.buttonEliminarClase.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEliminarClase.FlatAppearance.BorderSize = 2;
            this.buttonEliminarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarClase.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminarClase.Location = new System.Drawing.Point(595, 448);
            this.buttonEliminarClase.Name = "buttonEliminarClase";
            this.buttonEliminarClase.Size = new System.Drawing.Size(138, 34);
            this.buttonEliminarClase.TabIndex = 30;
            this.buttonEliminarClase.Text = "Eliminar";
            this.buttonEliminarClase.UseVisualStyleBackColor = true;
            // 
            // buttonModiClase
            // 
            this.buttonModiClase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiClase.FlatAppearance.BorderSize = 2;
            this.buttonModiClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModiClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModiClase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiClase.Location = new System.Drawing.Point(739, 448);
            this.buttonModiClase.Name = "buttonModiClase";
            this.buttonModiClase.Size = new System.Drawing.Size(168, 34);
            this.buttonModiClase.TabIndex = 29;
            this.buttonModiClase.Text = "Modificar Clase";
            this.buttonModiClase.UseVisualStyleBackColor = true;
            this.buttonModiClase.Click += new System.EventHandler(this.buttonModiClase_Click);
            // 
            // buttonCrearClase
            // 
            this.buttonCrearClase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearClase.FlatAppearance.BorderSize = 2;
            this.buttonCrearClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearClase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearClase.Location = new System.Drawing.Point(769, 54);
            this.buttonCrearClase.Name = "buttonCrearClase";
            this.buttonCrearClase.Size = new System.Drawing.Size(138, 34);
            this.buttonCrearClase.TabIndex = 28;
            this.buttonCrearClase.Text = "Crear Clase";
            this.buttonCrearClase.UseVisualStyleBackColor = true;
            this.buttonCrearClase.Click += new System.EventHandler(this.buttonCrearClase_Click);
            // 
            // dataGridViewClase
            // 
            this.dataGridViewClase.AllowUserToAddRows = false;
            this.dataGridViewClase.AllowUserToDeleteRows = false;
            this.dataGridViewClase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.TELEFONO,
            this.Correo,
            this.Direction});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClase.EnableHeadersVisualStyles = false;
            this.dataGridViewClase.Location = new System.Drawing.Point(41, 100);
            this.dataGridViewClase.Name = "dataGridViewClase";
            this.dataGridViewClase.ReadOnly = true;
            this.dataGridViewClase.Size = new System.Drawing.Size(644, 307);
            this.dataGridViewClase.TabIndex = 27;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "Telefono";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Direction
            // 
            this.Direction.HeaderText = "Dirección";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            // 
            // textBoxBuscarClase
            // 
            this.textBoxBuscarClase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarClase.Location = new System.Drawing.Point(80, 63);
            this.textBoxBuscarClase.Name = "textBoxBuscarClase";
            this.textBoxBuscarClase.Size = new System.Drawing.Size(300, 19);
            this.textBoxBuscarClase.TabIndex = 26;
            this.textBoxBuscarClase.Text = "Buscar...";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(42, 54);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 25;
            this.iconPictureBox1.TabStop = false;
            // 
            // GestionarClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(948, 537);
            this.Controls.Add(this.buttonEliminarClase);
            this.Controls.Add(this.buttonModiClase);
            this.Controls.Add(this.buttonCrearClase);
            this.Controls.Add(this.dataGridViewClase);
            this.Controls.Add(this.textBoxBuscarClase);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarClases";
            this.Text = "GestionarClases";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminarClase;
        private System.Windows.Forms.Button buttonModiClase;
        private System.Windows.Forms.Button buttonCrearClase;
        private System.Windows.Forms.DataGridView dataGridViewClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.TextBox textBoxBuscarClase;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
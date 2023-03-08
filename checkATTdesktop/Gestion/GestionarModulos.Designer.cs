namespace checkATTdesktop.Gestion
{
    partial class GestionarModulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCrearModulo = new System.Windows.Forms.Panel();
            this.buttonEliminarModulo = new System.Windows.Forms.Button();
            this.buttonModiModulo = new System.Windows.Forms.Button();
            this.buttonCrearModulo = new System.Windows.Forms.Button();
            this.dataGridViewModulos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscarModulo = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelCrearModulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearModulo
            // 
            this.panelCrearModulo.Controls.Add(this.buttonEliminarModulo);
            this.panelCrearModulo.Controls.Add(this.buttonModiModulo);
            this.panelCrearModulo.Controls.Add(this.buttonCrearModulo);
            this.panelCrearModulo.Controls.Add(this.dataGridViewModulos);
            this.panelCrearModulo.Controls.Add(this.textBoxBuscarModulo);
            this.panelCrearModulo.Controls.Add(this.iconPictureBox1);
            this.panelCrearModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrearModulo.Location = new System.Drawing.Point(0, 0);
            this.panelCrearModulo.Name = "panelCrearModulo";
            this.panelCrearModulo.Size = new System.Drawing.Size(948, 537);
            this.panelCrearModulo.TabIndex = 0;
            // 
            // buttonEliminarModulo
            // 
            this.buttonEliminarModulo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEliminarModulo.FlatAppearance.BorderSize = 2;
            this.buttonEliminarModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarModulo.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminarModulo.Location = new System.Drawing.Point(595, 448);
            this.buttonEliminarModulo.Name = "buttonEliminarModulo";
            this.buttonEliminarModulo.Size = new System.Drawing.Size(138, 34);
            this.buttonEliminarModulo.TabIndex = 30;
            this.buttonEliminarModulo.Text = "Eliminar";
            this.buttonEliminarModulo.UseVisualStyleBackColor = true;
            // 
            // buttonModiModulo
            // 
            this.buttonModiModulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiModulo.FlatAppearance.BorderSize = 2;
            this.buttonModiModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModiModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModiModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiModulo.Location = new System.Drawing.Point(739, 448);
            this.buttonModiModulo.Name = "buttonModiModulo";
            this.buttonModiModulo.Size = new System.Drawing.Size(168, 34);
            this.buttonModiModulo.TabIndex = 29;
            this.buttonModiModulo.Text = "Modificar Modulo";
            this.buttonModiModulo.UseVisualStyleBackColor = true;
            this.buttonModiModulo.Click += new System.EventHandler(this.buttonModiModulo_Click);
            // 
            // buttonCrearModulo
            // 
            this.buttonCrearModulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearModulo.FlatAppearance.BorderSize = 2;
            this.buttonCrearModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearModulo.Location = new System.Drawing.Point(769, 75);
            this.buttonCrearModulo.Name = "buttonCrearModulo";
            this.buttonCrearModulo.Size = new System.Drawing.Size(138, 34);
            this.buttonCrearModulo.TabIndex = 28;
            this.buttonCrearModulo.Text = "Crear Modulo";
            this.buttonCrearModulo.UseVisualStyleBackColor = true;
            this.buttonCrearModulo.Click += new System.EventHandler(this.buttonCrearModulo_Click);
            // 
            // dataGridViewModulos
            // 
            this.dataGridViewModulos.AllowUserToAddRows = false;
            this.dataGridViewModulos.AllowUserToDeleteRows = false;
            this.dataGridViewModulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewModulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Direction});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewModulos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewModulos.EnableHeadersVisualStyles = false;
            this.dataGridViewModulos.Location = new System.Drawing.Point(41, 128);
            this.dataGridViewModulos.Name = "dataGridViewModulos";
            this.dataGridViewModulos.ReadOnly = true;
            this.dataGridViewModulos.Size = new System.Drawing.Size(692, 279);
            this.dataGridViewModulos.TabIndex = 27;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre del módulo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direction
            // 
            this.Direction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direction.HeaderText = "Horas totales del módulo";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            // 
            // textBoxBuscarModulo
            // 
            this.textBoxBuscarModulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarModulo.Location = new System.Drawing.Point(80, 84);
            this.textBoxBuscarModulo.Name = "textBoxBuscarModulo";
            this.textBoxBuscarModulo.Size = new System.Drawing.Size(300, 19);
            this.textBoxBuscarModulo.TabIndex = 26;
            this.textBoxBuscarModulo.Text = "Buscar...";
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
            this.iconPictureBox1.TabIndex = 25;
            this.iconPictureBox1.TabStop = false;
            // 
            // GestionarModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(948, 537);
            this.Controls.Add(this.panelCrearModulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarModulos";
            this.Text = "GestionarModulos";
            this.panelCrearModulo.ResumeLayout(false);
            this.panelCrearModulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearModulo;
        private System.Windows.Forms.Button buttonEliminarModulo;
        private System.Windows.Forms.Button buttonModiModulo;
        private System.Windows.Forms.Button buttonCrearModulo;
        private System.Windows.Forms.DataGridView dataGridViewModulos;
        private System.Windows.Forms.TextBox textBoxBuscarModulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
    }
}
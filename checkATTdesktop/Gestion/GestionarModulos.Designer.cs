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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCrearModulo = new System.Windows.Forms.Panel();
            this.buttonEliminarModulo = new System.Windows.Forms.Button();
            this.buttonModiModulo = new System.Windows.Forms.Button();
            this.buttonCrearModulo = new System.Windows.Forms.Button();
            this.dataGridViewModulos = new System.Windows.Forms.DataGridView();
            this.nombremoduloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horastotalesmoduloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDataGridModulos = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscarModulo = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelCrearModulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridModulos)).BeginInit();
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
            this.buttonCrearModulo.Location = new System.Drawing.Point(769, 27);
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
            this.dataGridViewModulos.AutoGenerateColumns = false;
            this.dataGridViewModulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewModulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombremoduloDataGridViewTextBoxColumn,
            this.horastotalesmoduloDataGridViewTextBoxColumn});
            this.dataGridViewModulos.DataSource = this.bindingSourceDataGridModulos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewModulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewModulos.EnableHeadersVisualStyles = false;
            this.dataGridViewModulos.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewModulos.Name = "dataGridViewModulos";
            this.dataGridViewModulos.ReadOnly = true;
            this.dataGridViewModulos.Size = new System.Drawing.Size(895, 354);
            this.dataGridViewModulos.TabIndex = 27;
            // 
            // nombremoduloDataGridViewTextBoxColumn
            // 
            this.nombremoduloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombremoduloDataGridViewTextBoxColumn.DataPropertyName = "nombre_modulo";
            this.nombremoduloDataGridViewTextBoxColumn.HeaderText = "Nombre del modulo";
            this.nombremoduloDataGridViewTextBoxColumn.Name = "nombremoduloDataGridViewTextBoxColumn";
            this.nombremoduloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horastotalesmoduloDataGridViewTextBoxColumn
            // 
            this.horastotalesmoduloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horastotalesmoduloDataGridViewTextBoxColumn.DataPropertyName = "horas_totales_modulo";
            this.horastotalesmoduloDataGridViewTextBoxColumn.HeaderText = "Horas totales del modulo";
            this.horastotalesmoduloDataGridViewTextBoxColumn.Name = "horastotalesmoduloDataGridViewTextBoxColumn";
            this.horastotalesmoduloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceDataGridModulos
            // 
            this.bindingSourceDataGridModulos.DataSource = typeof(checkATTdesktop.Models.Modulo);
            // 
            // textBoxBuscarModulo
            // 
            this.textBoxBuscarModulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarModulo.Location = new System.Drawing.Point(50, 41);
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
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 29);
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
            this.Load += new System.EventHandler(this.GestionarModulos_Load);
            this.panelCrearModulo.ResumeLayout(false);
            this.panelCrearModulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridModulos)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceDataGridModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombremoduloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horastotalesmoduloDataGridViewTextBoxColumn;
    }
}
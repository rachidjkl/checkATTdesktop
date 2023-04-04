namespace checkATTdesktop.ModiAdd
{
    partial class ModiAddModulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBoxNombre = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxNombreModulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUFModulo = new System.Windows.Forms.DataGridView();
            this.nombreufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horastotalesufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEditarUF = new System.Windows.Forms.Button();
            this.buttonCrearUF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHorasTotalesModulos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxClases = new System.Windows.Forms.ListBox();
            this.bindingSourceListBoxClase = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceClases = new System.Windows.Forms.BindingSource(this.components);
            this.iconPictureBoxAñadir = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxBorrar = new FontAwesome.Sharp.IconPictureBox();
            this.buttonCrearModulo = new System.Windows.Forms.Button();
            this.textBoxHorasTotales = new System.Windows.Forms.TextBox();
            this.textBoxNumeroUF = new System.Windows.Forms.TextBox();
            this.textBox1NombreUF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClases = new System.Windows.Forms.ComboBox();
            this.bindingSourceClases = new System.Windows.Forms.BindingSource(this.components);
            this.label89 = new System.Windows.Forms.Label();
            this.buttonEliminarUf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUFModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListBoxClase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del módulo";
            // 
            // iconPictureBoxNombre
            // 
            this.iconPictureBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iconPictureBoxNombre.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBoxNombre.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.iconPictureBoxNombre.IconColor = System.Drawing.Color.Red;
            this.iconPictureBoxNombre.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBoxNombre.IconSize = 14;
            this.iconPictureBoxNombre.Location = new System.Drawing.Point(172, 17);
            this.iconPictureBoxNombre.Name = "iconPictureBoxNombre";
            this.iconPictureBoxNombre.Size = new System.Drawing.Size(14, 14);
            this.iconPictureBoxNombre.TabIndex = 79;
            this.iconPictureBoxNombre.TabStop = false;
            // 
            // textBoxNombreModulo
            // 
            this.textBoxNombreModulo.Location = new System.Drawing.Point(39, 46);
            this.textBoxNombreModulo.Name = "textBoxNombreModulo";
            this.textBoxNombreModulo.Size = new System.Drawing.Size(260, 20);
            this.textBoxNombreModulo.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "UF del módulo";
            // 
            // dataGridViewUFModulo
            // 
            this.dataGridViewUFModulo.AllowUserToAddRows = false;
            this.dataGridViewUFModulo.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUFModulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUFModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUFModulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreufDataGridViewTextBoxColumn,
            this.horastotalesufDataGridViewTextBoxColumn});
            this.dataGridViewUFModulo.DataSource = this.uFBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUFModulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUFModulo.Location = new System.Drawing.Point(40, 119);
            this.dataGridViewUFModulo.MultiSelect = false;
            this.dataGridViewUFModulo.Name = "dataGridViewUFModulo";
            this.dataGridViewUFModulo.ReadOnly = true;
            this.dataGridViewUFModulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUFModulo.Size = new System.Drawing.Size(481, 260);
            this.dataGridViewUFModulo.TabIndex = 82;
            this.dataGridViewUFModulo.SelectionChanged += new System.EventHandler(this.dataGridViewUFModulo_SelectionChanged);
            // 
            // nombreufDataGridViewTextBoxColumn
            // 
            this.nombreufDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreufDataGridViewTextBoxColumn.DataPropertyName = "nombre_uf";
            this.nombreufDataGridViewTextBoxColumn.HeaderText = "nombre_uf";
            this.nombreufDataGridViewTextBoxColumn.Name = "nombreufDataGridViewTextBoxColumn";
            this.nombreufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horastotalesufDataGridViewTextBoxColumn
            // 
            this.horastotalesufDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horastotalesufDataGridViewTextBoxColumn.DataPropertyName = "horas_totales_uf";
            this.horastotalesufDataGridViewTextBoxColumn.HeaderText = "horas_totales_uf";
            this.horastotalesufDataGridViewTextBoxColumn.Name = "horastotalesufDataGridViewTextBoxColumn";
            this.horastotalesufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uFBindingSource
            // 
            this.uFBindingSource.DataSource = typeof(checkATTdesktop.Models.UF);
            // 
            // buttonEditarUF
            // 
            this.buttonEditarUF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonEditarUF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonEditarUF.Location = new System.Drawing.Point(678, 347);
            this.buttonEditarUF.Name = "buttonEditarUF";
            this.buttonEditarUF.Size = new System.Drawing.Size(85, 32);
            this.buttonEditarUF.TabIndex = 83;
            this.buttonEditarUF.Text = "Editar Uf";
            this.buttonEditarUF.UseVisualStyleBackColor = true;
            this.buttonEditarUF.Click += new System.EventHandler(this.buttonEditarUF_Click);
            // 
            // buttonCrearUF
            // 
            this.buttonCrearUF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearUF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearUF.Location = new System.Drawing.Point(574, 347);
            this.buttonCrearUF.Name = "buttonCrearUF";
            this.buttonCrearUF.Size = new System.Drawing.Size(85, 32);
            this.buttonCrearUF.TabIndex = 84;
            this.buttonCrearUF.Text = "Crear UF";
            this.buttonCrearUF.UseVisualStyleBackColor = true;
            this.buttonCrearUF.Click += new System.EventHandler(this.buttonCrearUF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 24);
            this.label3.TabIndex = 85;
            this.label3.Text = "Horas totales del modulo:";
            // 
            // labelHorasTotalesModulos
            // 
            this.labelHorasTotalesModulos.AutoSize = true;
            this.labelHorasTotalesModulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorasTotalesModulos.Location = new System.Drawing.Point(726, 43);
            this.labelHorasTotalesModulos.Name = "labelHorasTotalesModulos";
            this.labelHorasTotalesModulos.Size = new System.Drawing.Size(19, 21);
            this.labelHorasTotalesModulos.TabIndex = 86;
            this.labelHorasTotalesModulos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Clases Seleccionadas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBoxClases
            // 
            this.listBoxClases.DataSource = this.bindingSourceListBoxClase;
            this.listBoxClases.DisplayMember = "nombre_clase";
            this.listBoxClases.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClases.FormattingEnabled = true;
            this.listBoxClases.Location = new System.Drawing.Point(42, 423);
            this.listBoxClases.Name = "listBoxClases";
            this.listBoxClases.Size = new System.Drawing.Size(261, 56);
            this.listBoxClases.TabIndex = 88;
            this.listBoxClases.ValueMember = "id_clase";
            // 
            // bindingSourceListBoxClase
            // 
            this.bindingSourceListBoxClase.DataSource = typeof(checkATTdesktop.Models.Clase);
            // 
            // bindingSourceClases
            // 
            this.bindingSourceClases.DataSource = typeof(checkATTdesktop.Models.Clase);
            // 
            // iconPictureBoxAñadir
            // 
            this.iconPictureBoxAñadir.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.iconPictureBoxAñadir.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.iconPictureBoxAñadir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.iconPictureBoxAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxAñadir.Location = new System.Drawing.Point(574, 431);
            this.iconPictureBoxAñadir.Name = "iconPictureBoxAñadir";
            this.iconPictureBoxAñadir.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxAñadir.TabIndex = 89;
            this.iconPictureBoxAñadir.TabStop = false;
            this.iconPictureBoxAñadir.Click += new System.EventHandler(this.iconPictureBoxAñadir_Click);
            // 
            // iconPictureBoxBorrar
            // 
            this.iconPictureBoxBorrar.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxBorrar.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBoxBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconPictureBoxBorrar.IconColor = System.Drawing.Color.Red;
            this.iconPictureBoxBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxBorrar.IconSize = 27;
            this.iconPictureBoxBorrar.Location = new System.Drawing.Point(309, 423);
            this.iconPictureBoxBorrar.Name = "iconPictureBoxBorrar";
            this.iconPictureBoxBorrar.Size = new System.Drawing.Size(27, 32);
            this.iconPictureBoxBorrar.TabIndex = 90;
            this.iconPictureBoxBorrar.TabStop = false;
            this.iconPictureBoxBorrar.Click += new System.EventHandler(this.iconPictureBoxBorrar_Click);
            // 
            // buttonCrearModulo
            // 
            this.buttonCrearModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearModulo.FlatAppearance.BorderSize = 0;
            this.buttonCrearModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearModulo.ForeColor = System.Drawing.Color.White;
            this.buttonCrearModulo.Location = new System.Drawing.Point(760, 473);
            this.buttonCrearModulo.Name = "buttonCrearModulo";
            this.buttonCrearModulo.Size = new System.Drawing.Size(140, 40);
            this.buttonCrearModulo.TabIndex = 91;
            this.buttonCrearModulo.Text = "Crear módulo";
            this.buttonCrearModulo.UseVisualStyleBackColor = false;
            this.buttonCrearModulo.Click += new System.EventHandler(this.buttonCrearModulo_Click);
            // 
            // textBoxHorasTotales
            // 
            this.textBoxHorasTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHorasTotales.Location = new System.Drawing.Point(574, 302);
            this.textBoxHorasTotales.Name = "textBoxHorasTotales";
            this.textBoxHorasTotales.Size = new System.Drawing.Size(289, 20);
            this.textBoxHorasTotales.TabIndex = 97;
            // 
            // textBoxNumeroUF
            // 
            this.textBoxNumeroUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroUF.Location = new System.Drawing.Point(574, 225);
            this.textBoxNumeroUF.Name = "textBoxNumeroUF";
            this.textBoxNumeroUF.Size = new System.Drawing.Size(289, 20);
            this.textBoxNumeroUF.TabIndex = 96;
            // 
            // textBox1NombreUF
            // 
            this.textBox1NombreUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1NombreUF.Location = new System.Drawing.Point(574, 147);
            this.textBox1NombreUF.Name = "textBox1NombreUF";
            this.textBox1NombreUF.Size = new System.Drawing.Size(289, 20);
            this.textBox1NombreUF.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Horas totales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "Numero UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 92;
            this.label7.Text = "Nombre de la UF";
            // 
            // comboBoxClases
            // 
            this.comboBoxClases.DataSource = this.bindingSourceClases;
            this.comboBoxClases.DisplayMember = "nombre_clase";
            this.comboBoxClases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClases.FormattingEnabled = true;
            this.comboBoxClases.Location = new System.Drawing.Point(378, 431);
            this.comboBoxClases.Name = "comboBoxClases";
            this.comboBoxClases.Size = new System.Drawing.Size(183, 21);
            this.comboBoxClases.TabIndex = 99;
            this.comboBoxClases.ValueMember = "id_clase";
            // 
            // bindingSourceClases
            // 
            this.bindingSourceClases.DataSource = typeof(checkATTdesktop.Models.Clase);
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(378, 397);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(49, 20);
            this.label89.TabIndex = 98;
            this.label89.Text = "Clase";
            // 
            // buttonEliminarUf
            // 
            this.buttonEliminarUf.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEliminarUf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarUf.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminarUf.Location = new System.Drawing.Point(780, 347);
            this.buttonEliminarUf.Name = "buttonEliminarUf";
            this.buttonEliminarUf.Size = new System.Drawing.Size(85, 32);
            this.buttonEliminarUf.TabIndex = 100;
            this.buttonEliminarUf.Text = "Eliminar Uf";
            this.buttonEliminarUf.UseVisualStyleBackColor = true;
            this.buttonEliminarUf.Click += new System.EventHandler(this.buttonEliminarUf_Click);
            // 
            // ModiAddModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(948, 537);
            this.Controls.Add(this.buttonEliminarUf);
            this.Controls.Add(this.comboBoxClases);
            this.Controls.Add(this.label89);
            this.Controls.Add(this.textBoxHorasTotales);
            this.Controls.Add(this.textBoxNumeroUF);
            this.Controls.Add(this.textBox1NombreUF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCrearModulo);
            this.Controls.Add(this.iconPictureBoxBorrar);
            this.Controls.Add(this.iconPictureBoxAñadir);
            this.Controls.Add(this.listBoxClases);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelHorasTotalesModulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCrearUF);
            this.Controls.Add(this.buttonEditarUF);
            this.Controls.Add(this.dataGridViewUFModulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreModulo);
            this.Controls.Add(this.iconPictureBoxNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModiAddModulos";
            this.Text = "ModiAddModulos";
            this.Load += new System.EventHandler(this.ModiAddModulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUFModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListBoxClase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBorrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxNombre;
        private System.Windows.Forms.TextBox textBoxNombreModulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUFModulo;
        private System.Windows.Forms.Button buttonEditarUF;
        private System.Windows.Forms.Button buttonCrearUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHorasTotalesModulos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxClases;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxAñadir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBorrar;
        private System.Windows.Forms.Button buttonCrearModulo;
        private System.Windows.Forms.TextBox textBoxHorasTotales;
        private System.Windows.Forms.TextBox textBoxNumeroUF;
        private System.Windows.Forms.TextBox textBox1NombreUF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxClases;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.BindingSource uFBindingSource;
        private System.Windows.Forms.Button buttonEliminarUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horastotalesufDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceClases;
        private System.Windows.Forms.BindingSource bindingSourceListBoxClase;
    }
}
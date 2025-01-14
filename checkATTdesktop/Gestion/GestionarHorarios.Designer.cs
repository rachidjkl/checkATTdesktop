﻿namespace checkATTdesktop.Gestion
{
    partial class GestionarHorarios
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
            this.buttonEliminarHorario = new System.Windows.Forms.Button();
            this.buttonModiHorario = new System.Windows.Forms.Button();
            this.buttonCrearHorario = new System.Windows.Forms.Button();
            this.dataGridViewHorarios = new System.Windows.Forms.DataGridView();
            this.idhorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmoduloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasemanahorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDataGridHorario = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscarHorario = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.comboBoxSeleccionarClase = new System.Windows.Forms.ComboBox();
            this.bindingSourceComboBoxClase = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDiaSemana = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboBoxClase)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminarHorario
            // 
            this.buttonEliminarHorario.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEliminarHorario.FlatAppearance.BorderSize = 2;
            this.buttonEliminarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarHorario.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminarHorario.Location = new System.Drawing.Point(595, 469);
            this.buttonEliminarHorario.Name = "buttonEliminarHorario";
            this.buttonEliminarHorario.Size = new System.Drawing.Size(138, 34);
            this.buttonEliminarHorario.TabIndex = 36;
            this.buttonEliminarHorario.Text = "Eliminar";
            this.buttonEliminarHorario.UseVisualStyleBackColor = true;
            this.buttonEliminarHorario.Click += new System.EventHandler(this.buttonEliminarHorario_Click);
            // 
            // buttonModiHorario
            // 
            this.buttonModiHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiHorario.FlatAppearance.BorderSize = 2;
            this.buttonModiHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModiHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModiHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonModiHorario.Location = new System.Drawing.Point(739, 469);
            this.buttonModiHorario.Name = "buttonModiHorario";
            this.buttonModiHorario.Size = new System.Drawing.Size(168, 34);
            this.buttonModiHorario.TabIndex = 35;
            this.buttonModiHorario.Text = "Modificar Horario";
            this.buttonModiHorario.UseVisualStyleBackColor = true;
            this.buttonModiHorario.Click += new System.EventHandler(this.buttonModiHorario_Click);
            // 
            // buttonCrearHorario
            // 
            this.buttonCrearHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearHorario.FlatAppearance.BorderSize = 2;
            this.buttonCrearHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearHorario.Location = new System.Drawing.Point(769, 43);
            this.buttonCrearHorario.Name = "buttonCrearHorario";
            this.buttonCrearHorario.Size = new System.Drawing.Size(138, 34);
            this.buttonCrearHorario.TabIndex = 34;
            this.buttonCrearHorario.Text = "Crear Horario";
            this.buttonCrearHorario.UseVisualStyleBackColor = true;
            this.buttonCrearHorario.Click += new System.EventHandler(this.buttonCrearHorario_Click);
            // 
            // dataGridViewHorarios
            // 
            this.dataGridViewHorarios.AllowUserToAddRows = false;
            this.dataGridViewHorarios.AutoGenerateColumns = false;
            this.dataGridViewHorarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhorarioDataGridViewTextBoxColumn,
            this.idclaseDataGridViewTextBoxColumn,
            this.idmoduloDataGridViewTextBoxColumn,
            this.horainicioDataGridViewTextBoxColumn,
            this.horafinDataGridViewTextBoxColumn,
            this.diasemanahorarioDataGridViewTextBoxColumn,
            this.claseDataGridViewTextBoxColumn});
            this.dataGridViewHorarios.DataSource = this.bindingSourceDataGridHorario;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHorarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHorarios.EnableHeadersVisualStyles = false;
            this.dataGridViewHorarios.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewHorarios.Name = "dataGridViewHorarios";
            this.dataGridViewHorarios.ReadOnly = true;
            this.dataGridViewHorarios.Size = new System.Drawing.Size(895, 299);
            this.dataGridViewHorarios.TabIndex = 33;
            this.dataGridViewHorarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewHorarios_CellFormatting);
            // 
            // idhorarioDataGridViewTextBoxColumn
            // 
            this.idhorarioDataGridViewTextBoxColumn.DataPropertyName = "id_horario";
            this.idhorarioDataGridViewTextBoxColumn.HeaderText = "id_horario";
            this.idhorarioDataGridViewTextBoxColumn.Name = "idhorarioDataGridViewTextBoxColumn";
            this.idhorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idhorarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // idclaseDataGridViewTextBoxColumn
            // 
            this.idclaseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idclaseDataGridViewTextBoxColumn.DataPropertyName = "id_clase";
            this.idclaseDataGridViewTextBoxColumn.HeaderText = "Clase";
            this.idclaseDataGridViewTextBoxColumn.Name = "idclaseDataGridViewTextBoxColumn";
            this.idclaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idmoduloDataGridViewTextBoxColumn
            // 
            this.idmoduloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idmoduloDataGridViewTextBoxColumn.DataPropertyName = "id_modulo";
            this.idmoduloDataGridViewTextBoxColumn.HeaderText = "Nombre modulo";
            this.idmoduloDataGridViewTextBoxColumn.Name = "idmoduloDataGridViewTextBoxColumn";
            this.idmoduloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horainicioDataGridViewTextBoxColumn
            // 
            this.horainicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horainicioDataGridViewTextBoxColumn.DataPropertyName = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.horainicioDataGridViewTextBoxColumn.Name = "horainicioDataGridViewTextBoxColumn";
            this.horainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horafinDataGridViewTextBoxColumn
            // 
            this.horafinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horafinDataGridViewTextBoxColumn.DataPropertyName = "hora_fin";
            this.horafinDataGridViewTextBoxColumn.HeaderText = "Final";
            this.horafinDataGridViewTextBoxColumn.Name = "horafinDataGridViewTextBoxColumn";
            this.horafinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasemanahorarioDataGridViewTextBoxColumn
            // 
            this.diasemanahorarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diasemanahorarioDataGridViewTextBoxColumn.DataPropertyName = "dia_semana_horario";
            this.diasemanahorarioDataGridViewTextBoxColumn.HeaderText = "Dia semana";
            this.diasemanahorarioDataGridViewTextBoxColumn.Name = "diasemanahorarioDataGridViewTextBoxColumn";
            this.diasemanahorarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claseDataGridViewTextBoxColumn
            // 
            this.claseDataGridViewTextBoxColumn.DataPropertyName = "Clase";
            this.claseDataGridViewTextBoxColumn.HeaderText = "Clase";
            this.claseDataGridViewTextBoxColumn.Name = "claseDataGridViewTextBoxColumn";
            this.claseDataGridViewTextBoxColumn.ReadOnly = true;
            this.claseDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceDataGridHorario
            // 
            this.bindingSourceDataGridHorario.DataSource = typeof(checkATTdesktop.Models.Horario);
            // 
            // textBoxBuscarHorario
            // 
            this.textBoxBuscarHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarHorario.Location = new System.Drawing.Point(50, 107);
            this.textBoxBuscarHorario.Name = "textBoxBuscarHorario";
            this.textBoxBuscarHorario.Size = new System.Drawing.Size(300, 19);
            this.textBoxBuscarHorario.TabIndex = 32;
            this.textBoxBuscarHorario.Text = "Buscar...";
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
            this.iconPictureBox1.TabIndex = 31;
            this.iconPictureBox1.TabStop = false;
            // 
            // comboBoxSeleccionarClase
            // 
            this.comboBoxSeleccionarClase.DataSource = this.bindingSourceComboBoxClase;
            this.comboBoxSeleccionarClase.DisplayMember = "nombre_clase";
            this.comboBoxSeleccionarClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeleccionarClase.FormattingEnabled = true;
            this.comboBoxSeleccionarClase.Location = new System.Drawing.Point(12, 56);
            this.comboBoxSeleccionarClase.Name = "comboBoxSeleccionarClase";
            this.comboBoxSeleccionarClase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSeleccionarClase.TabIndex = 38;
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
            this.label1.TabIndex = 37;
            this.label1.Text = "Clase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Dia de la semana";
            // 
            // comboBoxDiaSemana
            // 
            this.comboBoxDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiaSemana.FormattingEnabled = true;
            this.comboBoxDiaSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.comboBoxDiaSemana.Location = new System.Drawing.Point(247, 56);
            this.comboBoxDiaSemana.Name = "comboBoxDiaSemana";
            this.comboBoxDiaSemana.Size = new System.Drawing.Size(203, 21);
            this.comboBoxDiaSemana.TabIndex = 40;
            this.comboBoxDiaSemana.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiaSemana_SelectedIndexChanged);
            // 
            // GestionarHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(948, 537);
            this.Controls.Add(this.comboBoxDiaSemana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSeleccionarClase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminarHorario);
            this.Controls.Add(this.buttonModiHorario);
            this.Controls.Add(this.buttonCrearHorario);
            this.Controls.Add(this.dataGridViewHorarios);
            this.Controls.Add(this.textBoxBuscarHorario);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarHorarios";
            this.Text = "GestionarHorarios";
            this.Load += new System.EventHandler(this.GestionarHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboBoxClase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminarHorario;
        private System.Windows.Forms.Button buttonModiHorario;
        private System.Windows.Forms.Button buttonCrearHorario;
        private System.Windows.Forms.DataGridView dataGridViewHorarios;
        private System.Windows.Forms.TextBox textBoxBuscarHorario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox comboBoxSeleccionarClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDiaSemana;
        private System.Windows.Forms.BindingSource bindingSourceDataGridHorario;
        private System.Windows.Forms.BindingSource bindingSourceComboBoxClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmoduloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasemanahorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseDataGridViewTextBoxColumn;
    }
}
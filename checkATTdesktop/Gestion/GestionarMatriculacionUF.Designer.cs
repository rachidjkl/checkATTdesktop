namespace checkATTdesktop.Gestion
{
    partial class GestionarMatriculacionUF
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
            this.iconPictureBoxCerrarForm = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModulos = new System.Windows.Forms.ComboBox();
            this.bindingSourceComboBoxModulos = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmoduloufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horastotalesufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasarListaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDataGridUF = new System.Windows.Forms.BindingSource(this.components);
            this.iconButtonAceptar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboBoxModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridUF)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBoxCerrarForm
            // 
            this.iconPictureBoxCerrarForm.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxCerrarForm.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBoxCerrarForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconPictureBoxCerrarForm.IconColor = System.Drawing.Color.Red;
            this.iconPictureBoxCerrarForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCerrarForm.Location = new System.Drawing.Point(465, 14);
            this.iconPictureBoxCerrarForm.Name = "iconPictureBoxCerrarForm";
            this.iconPictureBoxCerrarForm.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxCerrarForm.TabIndex = 14;
            this.iconPictureBoxCerrarForm.TabStop = false;
            this.iconPictureBoxCerrarForm.Click += new System.EventHandler(this.iconPictureBoxCerrarForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modulos";
            // 
            // comboBoxModulos
            // 
            this.comboBoxModulos.DataSource = this.bindingSourceComboBoxModulos;
            this.comboBoxModulos.DisplayMember = "nombre_modulo";
            this.comboBoxModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModulos.FormattingEnabled = true;
            this.comboBoxModulos.Location = new System.Drawing.Point(21, 38);
            this.comboBoxModulos.Name = "comboBoxModulos";
            this.comboBoxModulos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModulos.TabIndex = 16;
            this.comboBoxModulos.ValueMember = "id_modulo";
            this.comboBoxModulos.SelectedIndexChanged += new System.EventHandler(this.comboBoxModulos_SelectedIndexChanged);
            // 
            // bindingSourceComboBoxModulos
            // 
            this.bindingSourceComboBoxModulos.DataSource = typeof(checkATTdesktop.Models.Modulo);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idufDataGridViewTextBoxColumn,
            this.idmoduloufDataGridViewTextBoxColumn,
            this.nombreufDataGridViewTextBoxColumn,
            this.horastotalesufDataGridViewTextBoxColumn,
            this.moduloDataGridViewTextBoxColumn,
            this.pasarListaDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceDataGridUF;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(476, 295);
            this.dataGridView1.TabIndex = 17;
            // 
            // idufDataGridViewTextBoxColumn
            // 
            this.idufDataGridViewTextBoxColumn.DataPropertyName = "id_uf";
            this.idufDataGridViewTextBoxColumn.HeaderText = "id_uf";
            this.idufDataGridViewTextBoxColumn.Name = "idufDataGridViewTextBoxColumn";
            this.idufDataGridViewTextBoxColumn.ReadOnly = true;
            this.idufDataGridViewTextBoxColumn.Visible = false;
            // 
            // idmoduloufDataGridViewTextBoxColumn
            // 
            this.idmoduloufDataGridViewTextBoxColumn.DataPropertyName = "id_modulo_uf";
            this.idmoduloufDataGridViewTextBoxColumn.HeaderText = "id_modulo_uf";
            this.idmoduloufDataGridViewTextBoxColumn.Name = "idmoduloufDataGridViewTextBoxColumn";
            this.idmoduloufDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmoduloufDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreufDataGridViewTextBoxColumn
            // 
            this.nombreufDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreufDataGridViewTextBoxColumn.DataPropertyName = "nombre_uf";
            this.nombreufDataGridViewTextBoxColumn.HeaderText = "Nombre de la UF";
            this.nombreufDataGridViewTextBoxColumn.Name = "nombreufDataGridViewTextBoxColumn";
            this.nombreufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horastotalesufDataGridViewTextBoxColumn
            // 
            this.horastotalesufDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horastotalesufDataGridViewTextBoxColumn.DataPropertyName = "horas_totales_uf";
            this.horastotalesufDataGridViewTextBoxColumn.HeaderText = "Horas totales de la UF";
            this.horastotalesufDataGridViewTextBoxColumn.Name = "horastotalesufDataGridViewTextBoxColumn";
            this.horastotalesufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moduloDataGridViewTextBoxColumn
            // 
            this.moduloDataGridViewTextBoxColumn.DataPropertyName = "Modulo";
            this.moduloDataGridViewTextBoxColumn.HeaderText = "Modulo";
            this.moduloDataGridViewTextBoxColumn.Name = "moduloDataGridViewTextBoxColumn";
            this.moduloDataGridViewTextBoxColumn.ReadOnly = true;
            this.moduloDataGridViewTextBoxColumn.Visible = false;
            // 
            // pasarListaDataGridViewTextBoxColumn
            // 
            this.pasarListaDataGridViewTextBoxColumn.DataPropertyName = "Pasar_Lista";
            this.pasarListaDataGridViewTextBoxColumn.HeaderText = "Pasar_Lista";
            this.pasarListaDataGridViewTextBoxColumn.Name = "pasarListaDataGridViewTextBoxColumn";
            this.pasarListaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pasarListaDataGridViewTextBoxColumn.Visible = false;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculaDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceDataGridUF
            // 
            this.bindingSourceDataGridUF.DataSource = typeof(checkATTdesktop.Models.UF);
            // 
            // iconButtonAceptar
            // 
            this.iconButtonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.iconButtonAceptar.FlatAppearance.BorderSize = 0;
            this.iconButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAceptar.ForeColor = System.Drawing.Color.White;
            this.iconButtonAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButtonAceptar.IconColor = System.Drawing.Color.White;
            this.iconButtonAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAceptar.IconSize = 30;
            this.iconButtonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAceptar.Location = new System.Drawing.Point(394, 388);
            this.iconButtonAceptar.Name = "iconButtonAceptar";
            this.iconButtonAceptar.Size = new System.Drawing.Size(103, 36);
            this.iconButtonAceptar.TabIndex = 114;
            this.iconButtonAceptar.Text = "Matricular";
            this.iconButtonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAceptar.UseVisualStyleBackColor = false;
            this.iconButtonAceptar.Click += new System.EventHandler(this.iconButtonAceptar_Click);
            // 
            // GestionarMatriculacionUF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(518, 436);
            this.ControlBox = false;
            this.Controls.Add(this.iconButtonAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxModulos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBoxCerrarForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GestionarMatriculacionUF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionarMatriculacionUF";
            this.Load += new System.EventHandler(this.GestionarMatriculacionUF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboBoxModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataGridUF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCerrarForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModulos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonAceptar;
        private System.Windows.Forms.BindingSource bindingSourceComboBoxModulos;
        private System.Windows.Forms.BindingSource bindingSourceDataGridUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn horascursadasufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmoduloufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horastotalesufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasarListaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
    }
}
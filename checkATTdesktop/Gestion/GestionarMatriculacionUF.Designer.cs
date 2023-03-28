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
            this.iconPictureBoxCerrarForm = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModulos = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButtonAceptar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modulos";
            // 
            // comboBoxModulos
            // 
            this.comboBoxModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModulos.FormattingEnabled = true;
            this.comboBoxModulos.Location = new System.Drawing.Point(21, 38);
            this.comboBoxModulos.Name = "comboBoxModulos";
            this.comboBoxModulos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModulos.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 295);
            this.dataGridView1.TabIndex = 17;
            // 
            // iconButtonAceptar
            // 
            this.iconButtonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.iconButtonAceptar.FlatAppearance.BorderSize = 0;
            this.iconButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // GestionarMatriculacionUF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCerrarForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModulos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonAceptar;
    }
}
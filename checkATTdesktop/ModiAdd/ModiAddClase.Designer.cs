namespace checkATTdesktop.ModiAdd
{
    partial class ModiAddClase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreClase = new System.Windows.Forms.TextBox();
            this.comboBoxTutor = new System.Windows.Forms.ComboBox();
            this.bindingSourceComboBoxProfes = new System.Windows.Forms.BindingSource(this.components);
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.buttonCrearModiAddClase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboBoxProfes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la clase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutor";
            // 
            // textBoxNombreClase
            // 
            this.textBoxNombreClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreClase.Location = new System.Drawing.Point(14, 77);
            this.textBoxNombreClase.Name = "textBoxNombreClase";
            this.textBoxNombreClase.Size = new System.Drawing.Size(285, 22);
            this.textBoxNombreClase.TabIndex = 2;
            // 
            // comboBoxTutor
            // 
            this.comboBoxTutor.DataSource = this.bindingSourceComboBoxProfes;
            this.comboBoxTutor.DisplayMember = "nombre_completo";
            this.comboBoxTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTutor.FormattingEnabled = true;
            this.comboBoxTutor.Location = new System.Drawing.Point(14, 154);
            this.comboBoxTutor.Name = "comboBoxTutor";
            this.comboBoxTutor.Size = new System.Drawing.Size(285, 24);
            this.comboBoxTutor.TabIndex = 3;
            this.comboBoxTutor.ValueMember = "id_profe";
            // 
            // bindingSourceComboBoxProfes
            // 
            this.bindingSourceComboBoxProfes.DataSource = typeof(checkATTdesktop.Models.Profesor);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(277, 9);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // buttonCrearModiAddClase
            // 
            this.buttonCrearModiAddClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearModiAddClase.FlatAppearance.BorderSize = 0;
            this.buttonCrearModiAddClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearModiAddClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearModiAddClase.ForeColor = System.Drawing.Color.White;
            this.buttonCrearModiAddClase.Location = new System.Drawing.Point(94, 229);
            this.buttonCrearModiAddClase.Name = "buttonCrearModiAddClase";
            this.buttonCrearModiAddClase.Size = new System.Drawing.Size(114, 32);
            this.buttonCrearModiAddClase.TabIndex = 5;
            this.buttonCrearModiAddClase.Text = "Crear";
            this.buttonCrearModiAddClase.UseVisualStyleBackColor = false;
            this.buttonCrearModiAddClase.Click += new System.EventHandler(this.buttonCrearModiAddClase_Click);
            // 
            // ModiAddClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(312, 276);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCrearModiAddClase);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.comboBoxTutor);
            this.Controls.Add(this.textBoxNombreClase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModiAddClase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModiAddClase";
            this.Load += new System.EventHandler(this.ModiAddClase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboBoxProfes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreClase;
        private System.Windows.Forms.ComboBox comboBoxTutor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button buttonCrearModiAddClase;
        private System.Windows.Forms.BindingSource bindingSourceComboBoxProfes;
    }
}
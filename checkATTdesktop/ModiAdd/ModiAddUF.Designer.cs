namespace checkATTdesktop.ModiAdd
{
    partial class ModiAddUF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1NombreUF = new System.Windows.Forms.TextBox();
            this.textBoxNumeroUF = new System.Windows.Forms.TextBox();
            this.textBoxHorasTotales = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.buttonCrearModiAddUF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la UF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero UF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas totales";
            // 
            // textBox1NombreUF
            // 
            this.textBox1NombreUF.Location = new System.Drawing.Point(48, 66);
            this.textBox1NombreUF.Name = "textBox1NombreUF";
            this.textBox1NombreUF.Size = new System.Drawing.Size(289, 20);
            this.textBox1NombreUF.TabIndex = 3;
            // 
            // textBoxNumeroUF
            // 
            this.textBoxNumeroUF.Location = new System.Drawing.Point(48, 144);
            this.textBoxNumeroUF.Name = "textBoxNumeroUF";
            this.textBoxNumeroUF.Size = new System.Drawing.Size(289, 20);
            this.textBoxNumeroUF.TabIndex = 4;
            // 
            // textBoxHorasTotales
            // 
            this.textBoxHorasTotales.Location = new System.Drawing.Point(48, 221);
            this.textBoxHorasTotales.Name = "textBoxHorasTotales";
            this.textBoxHorasTotales.Size = new System.Drawing.Size(289, 20);
            this.textBoxHorasTotales.TabIndex = 5;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(329, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // buttonCrearModiAddUF
            // 
            this.buttonCrearModiAddUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.buttonCrearModiAddUF.FlatAppearance.BorderSize = 0;
            this.buttonCrearModiAddUF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearModiAddUF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearModiAddUF.ForeColor = System.Drawing.Color.White;
            this.buttonCrearModiAddUF.Location = new System.Drawing.Point(125, 280);
            this.buttonCrearModiAddUF.Name = "buttonCrearModiAddUF";
            this.buttonCrearModiAddUF.Size = new System.Drawing.Size(114, 32);
            this.buttonCrearModiAddUF.TabIndex = 7;
            this.buttonCrearModiAddUF.Text = "Crear";
            this.buttonCrearModiAddUF.UseVisualStyleBackColor = false;
            // 
            // ModiAddUF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 334);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCrearModiAddUF);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.textBoxHorasTotales);
            this.Controls.Add(this.textBoxNumeroUF);
            this.Controls.Add(this.textBox1NombreUF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModiAddUF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModiAddUF";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1NombreUF;
        private System.Windows.Forms.TextBox textBoxNumeroUF;
        private System.Windows.Forms.TextBox textBoxHorasTotales;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button buttonCrearModiAddUF;
    }
}
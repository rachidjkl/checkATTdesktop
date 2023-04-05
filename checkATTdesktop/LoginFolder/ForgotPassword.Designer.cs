namespace checkATTdesktop.LoginFolder
{
    partial class ForgotPassword
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
            this.textBoxCorreoRestablecerContraseña = new System.Windows.Forms.TextBox();
            this.iconButtonAceptarRestablecerContraseña = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce un correo para restablecer la contraseña";
            // 
            // textBoxCorreoRestablecerContraseña
            // 
            this.textBoxCorreoRestablecerContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoRestablecerContraseña.Location = new System.Drawing.Point(25, 64);
            this.textBoxCorreoRestablecerContraseña.Name = "textBoxCorreoRestablecerContraseña";
            this.textBoxCorreoRestablecerContraseña.Size = new System.Drawing.Size(549, 26);
            this.textBoxCorreoRestablecerContraseña.TabIndex = 1;
            // 
            // iconButtonAceptarRestablecerContraseña
            // 
            this.iconButtonAceptarRestablecerContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.iconButtonAceptarRestablecerContraseña.FlatAppearance.BorderSize = 0;
            this.iconButtonAceptarRestablecerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAceptarRestablecerContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAceptarRestablecerContraseña.ForeColor = System.Drawing.Color.White;
            this.iconButtonAceptarRestablecerContraseña.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButtonAceptarRestablecerContraseña.IconColor = System.Drawing.Color.White;
            this.iconButtonAceptarRestablecerContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAceptarRestablecerContraseña.IconSize = 30;
            this.iconButtonAceptarRestablecerContraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAceptarRestablecerContraseña.Location = new System.Drawing.Point(240, 137);
            this.iconButtonAceptarRestablecerContraseña.Name = "iconButtonAceptarRestablecerContraseña";
            this.iconButtonAceptarRestablecerContraseña.Size = new System.Drawing.Size(103, 36);
            this.iconButtonAceptarRestablecerContraseña.TabIndex = 114;
            this.iconButtonAceptarRestablecerContraseña.Text = "Aceptar";
            this.iconButtonAceptarRestablecerContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAceptarRestablecerContraseña.UseVisualStyleBackColor = false;
            this.iconButtonAceptarRestablecerContraseña.Click += new System.EventHandler(this.iconButtonAceptarRestablecerContraseña_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(542, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 115;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(590, 185);
            this.ControlBox = false;
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconButtonAceptarRestablecerContraseña);
            this.Controls.Add(this.textBoxCorreoRestablecerContraseña);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCorreoRestablecerContraseña;
        private FontAwesome.Sharp.IconButton iconButtonAceptarRestablecerContraseña;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
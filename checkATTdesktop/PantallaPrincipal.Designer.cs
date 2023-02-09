namespace checkATTdesktop
{
    partial class PantallaPrincipal
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
            this.panelConTodoIzquierda = new System.Windows.Forms.Panel();
            this.panelIzquierdaSuperiorLogo = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGestionarAlumnos = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.panelConTodoIzquierda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConTodoIzquierda
            // 
            this.panelConTodoIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelConTodoIzquierda.Controls.Add(this.button);
            this.panelConTodoIzquierda.Controls.Add(this.buttonGestionarAlumnos);
            this.panelConTodoIzquierda.Controls.Add(this.buttonHome);
            this.panelConTodoIzquierda.Controls.Add(this.panelIzquierdaSuperiorLogo);
            this.panelConTodoIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConTodoIzquierda.Location = new System.Drawing.Point(0, 0);
            this.panelConTodoIzquierda.Name = "panelConTodoIzquierda";
            this.panelConTodoIzquierda.Size = new System.Drawing.Size(212, 1041);
            this.panelConTodoIzquierda.TabIndex = 0;
            // 
            // panelIzquierdaSuperiorLogo
            // 
            this.panelIzquierdaSuperiorLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIzquierdaSuperiorLogo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdaSuperiorLogo.Name = "panelIzquierdaSuperiorLogo";
            this.panelIzquierdaSuperiorLogo.Size = new System.Drawing.Size(212, 138);
            this.panelIzquierdaSuperiorLogo.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(0, 138);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(212, 47);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonGestionarAlumnos
            // 
            this.buttonGestionarAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarAlumnos.FlatAppearance.BorderSize = 0;
            this.buttonGestionarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarAlumnos.ForeColor = System.Drawing.Color.White;
            this.buttonGestionarAlumnos.Location = new System.Drawing.Point(0, 185);
            this.buttonGestionarAlumnos.Name = "buttonGestionarAlumnos";
            this.buttonGestionarAlumnos.Size = new System.Drawing.Size(212, 47);
            this.buttonGestionarAlumnos.TabIndex = 2;
            this.buttonGestionarAlumnos.Text = "Gestionar alumnos";
            this.buttonGestionarAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionarAlumnos.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Top;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(0, 232);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(212, 23);
            this.button.TabIndex = 3;
            this.button.Text = "button1";
            this.button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelConTodoIzquierda);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.panelConTodoIzquierda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConTodoIzquierda;
        private System.Windows.Forms.Panel panelIzquierdaSuperiorLogo;
        private System.Windows.Forms.Button buttonGestionarAlumnos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button button;
    }
}
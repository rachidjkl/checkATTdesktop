using System.Windows.Forms;

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
            this.panelConTodoMenusIzquierda = new System.Windows.Forms.Panel();
            this.buttonGestionModulos = new System.Windows.Forms.Button();
            this.buttonGestionClases = new System.Windows.Forms.Button();
            this.buttonGestionarProfes = new System.Windows.Forms.Button();
            this.buttonGestionarAlumnos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelIzquierdaSuperiorLogo = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.panelConTodoMenusIzquierda.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConTodoMenusIzquierda
            // 
            this.panelConTodoMenusIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelConTodoMenusIzquierda.Controls.Add(this.buttonGestionModulos);
            this.panelConTodoMenusIzquierda.Controls.Add(this.buttonGestionClases);
            this.panelConTodoMenusIzquierda.Controls.Add(this.buttonGestionarProfes);
            this.panelConTodoMenusIzquierda.Controls.Add(this.buttonGestionarAlumnos);
            this.panelConTodoMenusIzquierda.Controls.Add(this.buttonHome);
            this.panelConTodoMenusIzquierda.Controls.Add(this.panelIzquierdaSuperiorLogo);
            this.panelConTodoMenusIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConTodoMenusIzquierda.Location = new System.Drawing.Point(0, 0);
            this.panelConTodoMenusIzquierda.Name = "panelConTodoMenusIzquierda";
            this.panelConTodoMenusIzquierda.Size = new System.Drawing.Size(212, 1041);
            this.panelConTodoMenusIzquierda.TabIndex = 0;
            // 
            // buttonGestionModulos
            // 
            this.buttonGestionModulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionModulos.FlatAppearance.BorderSize = 0;
            this.buttonGestionModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionModulos.ForeColor = System.Drawing.Color.White;
            this.buttonGestionModulos.Location = new System.Drawing.Point(0, 326);
            this.buttonGestionModulos.Name = "buttonGestionModulos";
            this.buttonGestionModulos.Size = new System.Drawing.Size(212, 47);
            this.buttonGestionModulos.TabIndex = 5;
            this.buttonGestionModulos.Text = "Gestionar modulos";
            this.buttonGestionModulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionModulos.UseVisualStyleBackColor = true;
            // 
            // buttonGestionClases
            // 
            this.buttonGestionClases.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionClases.FlatAppearance.BorderSize = 0;
            this.buttonGestionClases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionClases.ForeColor = System.Drawing.Color.White;
            this.buttonGestionClases.Location = new System.Drawing.Point(0, 279);
            this.buttonGestionClases.Name = "buttonGestionClases";
            this.buttonGestionClases.Size = new System.Drawing.Size(212, 47);
            this.buttonGestionClases.TabIndex = 4;
            this.buttonGestionClases.Text = "Gestionar clases";
            this.buttonGestionClases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionClases.UseVisualStyleBackColor = true;
            // 
            // buttonGestionarProfes
            // 
            this.buttonGestionarProfes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarProfes.FlatAppearance.BorderSize = 0;
            this.buttonGestionarProfes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarProfes.ForeColor = System.Drawing.Color.White;
            this.buttonGestionarProfes.Location = new System.Drawing.Point(0, 232);
            this.buttonGestionarProfes.Name = "buttonGestionarProfes";
            this.buttonGestionarProfes.Size = new System.Drawing.Size(212, 47);
            this.buttonGestionarProfes.TabIndex = 3;
            this.buttonGestionarProfes.Text = "Gestionar profesores";
            this.buttonGestionarProfes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionarProfes.UseVisualStyleBackColor = true;
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
            // panelIzquierdaSuperiorLogo
            // 
            this.panelIzquierdaSuperiorLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIzquierdaSuperiorLogo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdaSuperiorLogo.Name = "panelIzquierdaSuperiorLogo";
            this.panelIzquierdaSuperiorLogo.Size = new System.Drawing.Size(212, 138);
            this.panelIzquierdaSuperiorLogo.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.labelNombreUsuario);
            this.panelSuperior.Controls.Add(this.labelBienvenido);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(212, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1692, 99);
            this.panelSuperior.TabIndex = 1;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.labelNombreUsuario.Location = new System.Drawing.Point(46, 53);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(139, 33);
            this.labelNombreUsuario.TabIndex = 1;
            this.labelNombreUsuario.Text = "Jose Luis";
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.ForeColor = System.Drawing.Color.White;
            this.labelBienvenido.Location = new System.Drawing.Point(34, 9);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(167, 33);
            this.labelBienvenido.TabIndex = 0;
            this.labelBienvenido.Text = "Bienvenido,";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelConTodoMenusIzquierda);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.panelConTodoMenusIzquierda.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConTodoMenusIzquierda;
        private System.Windows.Forms.Panel panelIzquierdaSuperiorLogo;
        private System.Windows.Forms.Button buttonGestionarAlumnos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGestionModulos;
        private System.Windows.Forms.Button buttonGestionClases;
        private System.Windows.Forms.Button buttonGestionarProfes;
        private System.Windows.Forms.Panel panelSuperior;
        private Label labelBienvenido;
        private Label labelNombreUsuario;
    }
}
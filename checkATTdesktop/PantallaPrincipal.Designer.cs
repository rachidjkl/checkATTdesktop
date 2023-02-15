using System;
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
            this.components = new System.ComponentModel.Container();
            this.panelConTodoMenusIzquierda = new System.Windows.Forms.Panel();
            this.buttonGestionModulos = new System.Windows.Forms.Button();
            this.buttonGestionClases = new System.Windows.Forms.Button();
            this.buttonGestionarProfes = new System.Windows.Forms.Button();
            this.buttonGestionarAlumnos = new System.Windows.Forms.Button();
            this.panelIzquierdaSuperiorLogo = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelPantallaSeleccionada = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMuestraHora = new System.Windows.Forms.Label();
            this.labelMuestraFecha = new System.Windows.Forms.Label();
            this.panelConTodoMenusIzquierda.SuspendLayout();
            this.panelIzquierdaSuperiorLogo.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.panelConTodoMenusIzquierda.Size = new System.Drawing.Size(212, 623);
            this.panelConTodoMenusIzquierda.TabIndex = 0;
            // 
            // buttonGestionModulos
            // 
            this.buttonGestionModulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionModulos.FlatAppearance.BorderSize = 0;
            this.buttonGestionModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionModulos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonGestionClases.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonGestionarProfes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonGestionarAlumnos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestionarAlumnos.ForeColor = System.Drawing.Color.White;
            this.buttonGestionarAlumnos.Location = new System.Drawing.Point(0, 185);
            this.buttonGestionarAlumnos.Name = "buttonGestionarAlumnos";
            this.buttonGestionarAlumnos.Size = new System.Drawing.Size(212, 47);
            this.buttonGestionarAlumnos.TabIndex = 2;
            this.buttonGestionarAlumnos.Text = "Gestionar alumnos";
            this.buttonGestionarAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionarAlumnos.UseVisualStyleBackColor = true;
            // 
            // panelIzquierdaSuperiorLogo
            // 
            this.panelIzquierdaSuperiorLogo.Controls.Add(this.pictureBox2);
            this.panelIzquierdaSuperiorLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIzquierdaSuperiorLogo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdaSuperiorLogo.Name = "panelIzquierdaSuperiorLogo";
            this.panelIzquierdaSuperiorLogo.Size = new System.Drawing.Size(212, 138);
            this.panelIzquierdaSuperiorLogo.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSuperior.Controls.Add(this.labelPantallaSeleccionada);
            this.panelSuperior.Controls.Add(this.labelNombreUsuario);
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(212, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(948, 69);
            this.panelSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::checkATTdesktop.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(708, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = global::checkATTdesktop.Properties.Resources.home__1_1;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHome.Location = new System.Drawing.Point(0, 138);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(212, 47);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::checkATTdesktop.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.labelNombreUsuario.Location = new System.Drawing.Point(794, 19);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(139, 33);
            this.labelNombreUsuario.TabIndex = 3;
            this.labelNombreUsuario.Text = "Jose Luis";
            // 
            // labelPantallaSeleccionada
            // 
            this.labelPantallaSeleccionada.AutoSize = true;
            this.labelPantallaSeleccionada.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPantallaSeleccionada.ForeColor = System.Drawing.Color.White;
            this.labelPantallaSeleccionada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPantallaSeleccionada.Location = new System.Drawing.Point(24, 19);
            this.labelPantallaSeleccionada.Name = "labelPantallaSeleccionada";
            this.labelPantallaSeleccionada.Size = new System.Drawing.Size(95, 33);
            this.labelPantallaSeleccionada.TabIndex = 4;
            this.labelPantallaSeleccionada.Text = "Home";
            this.labelPantallaSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::checkATTdesktop.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(332, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(223, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(561, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de la aplicación";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMuestraHora
            // 
            this.labelMuestraHora.AutoSize = true;
            this.labelMuestraHora.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestraHora.ForeColor = System.Drawing.Color.White;
            this.labelMuestraHora.Location = new System.Drawing.Point(699, 291);
            this.labelMuestraHora.Name = "labelMuestraHora";
            this.labelMuestraHora.Size = new System.Drawing.Size(130, 44);
            this.labelMuestraHora.TabIndex = 4;
            this.labelMuestraHora.Text = "label2";
            // 
            // labelMuestraFecha
            // 
            this.labelMuestraFecha.AutoSize = true;
            this.labelMuestraFecha.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestraFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(142)))));
            this.labelMuestraFecha.Location = new System.Drawing.Point(575, 349);
            this.labelMuestraFecha.Name = "labelMuestraFecha";
            this.labelMuestraFecha.Size = new System.Drawing.Size(96, 33);
            this.labelMuestraFecha.TabIndex = 5;
            this.labelMuestraFecha.Text = "label2";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1160, 623);
            this.Controls.Add(this.labelMuestraFecha);
            this.Controls.Add(this.labelMuestraHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelConTodoMenusIzquierda);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.panelConTodoMenusIzquierda.ResumeLayout(false);
            this.panelIzquierdaSuperiorLogo.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelPantallaSeleccionada;
        private Label labelNombreUsuario;
        private PictureBox pictureBox3;
        private Label label1;
        private Timer timer1;
        private Label labelMuestraHora;
        private Label labelMuestraFecha;
    }
}
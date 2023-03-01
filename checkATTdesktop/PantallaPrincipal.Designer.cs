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
            this.iconButtonManageHorario = new FontAwesome.Sharp.IconButton();
            this.iconButtonManageModuls = new FontAwesome.Sharp.IconButton();
            this.iconButtonManageClass = new FontAwesome.Sharp.IconButton();
            this.iconButtonManageTeacher = new FontAwesome.Sharp.IconButton();
            this.iconButtonManageStudent = new FontAwesome.Sharp.IconButton();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelIzquierdaSuperiorLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelPantallaSeleccionada = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMuestraHora = new System.Windows.Forms.Label();
            this.labelMuestraFecha = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.iconButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.panelConTodoMenusIzquierda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelIzquierdaSuperiorLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConTodoMenusIzquierda
            // 
            this.panelConTodoMenusIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.panelConTodoMenusIzquierda.Controls.Add(this.iconButtonManageHorario);
            this.panelConTodoMenusIzquierda.Controls.Add(this.iconButtonManageModuls);
            this.panelConTodoMenusIzquierda.Controls.Add(this.iconButtonManageClass);
            this.panelConTodoMenusIzquierda.Controls.Add(this.iconButtonManageTeacher);
            this.panelConTodoMenusIzquierda.Controls.Add(this.iconButtonManageStudent);
            this.panelConTodoMenusIzquierda.Controls.Add(this.iconButtonHome);
            this.panelConTodoMenusIzquierda.Controls.Add(this.panel1);
            this.panelConTodoMenusIzquierda.Controls.Add(this.panelIzquierdaSuperiorLogo);
            this.panelConTodoMenusIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConTodoMenusIzquierda.Location = new System.Drawing.Point(0, 0);
            this.panelConTodoMenusIzquierda.Name = "panelConTodoMenusIzquierda";
            this.panelConTodoMenusIzquierda.Size = new System.Drawing.Size(212, 623);
            this.panelConTodoMenusIzquierda.TabIndex = 0;
            // 
            // iconButtonManageHorario
            // 
            this.iconButtonManageHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonManageHorario.FlatAppearance.BorderSize = 0;
            this.iconButtonManageHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonManageHorario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonManageHorario.ForeColor = System.Drawing.Color.White;
            this.iconButtonManageHorario.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.iconButtonManageHorario.IconColor = System.Drawing.Color.White;
            this.iconButtonManageHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonManageHorario.IconSize = 30;
            this.iconButtonManageHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageHorario.Location = new System.Drawing.Point(0, 415);
            this.iconButtonManageHorario.Name = "iconButtonManageHorario";
            this.iconButtonManageHorario.Padding = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.iconButtonManageHorario.Size = new System.Drawing.Size(212, 50);
            this.iconButtonManageHorario.TabIndex = 12;
            this.iconButtonManageHorario.Text = "Gestionar horarios";
            this.iconButtonManageHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonManageHorario.UseVisualStyleBackColor = true;
            this.iconButtonManageHorario.Click += new System.EventHandler(this.iconButtonManageHorario_Click);
            // 
            // iconButtonManageModuls
            // 
            this.iconButtonManageModuls.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonManageModuls.FlatAppearance.BorderSize = 0;
            this.iconButtonManageModuls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonManageModuls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonManageModuls.ForeColor = System.Drawing.Color.White;
            this.iconButtonManageModuls.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButtonManageModuls.IconColor = System.Drawing.Color.White;
            this.iconButtonManageModuls.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonManageModuls.IconSize = 30;
            this.iconButtonManageModuls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageModuls.Location = new System.Drawing.Point(0, 365);
            this.iconButtonManageModuls.Name = "iconButtonManageModuls";
            this.iconButtonManageModuls.Padding = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.iconButtonManageModuls.Size = new System.Drawing.Size(212, 50);
            this.iconButtonManageModuls.TabIndex = 11;
            this.iconButtonManageModuls.Text = "Gestionar modulos";
            this.iconButtonManageModuls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageModuls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonManageModuls.UseVisualStyleBackColor = true;
            this.iconButtonManageModuls.Click += new System.EventHandler(this.iconButtonManageModuls_Click);
            // 
            // iconButtonManageClass
            // 
            this.iconButtonManageClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonManageClass.FlatAppearance.BorderSize = 0;
            this.iconButtonManageClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonManageClass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonManageClass.ForeColor = System.Drawing.Color.White;
            this.iconButtonManageClass.IconChar = FontAwesome.Sharp.IconChar.School;
            this.iconButtonManageClass.IconColor = System.Drawing.Color.White;
            this.iconButtonManageClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonManageClass.IconSize = 33;
            this.iconButtonManageClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageClass.Location = new System.Drawing.Point(0, 315);
            this.iconButtonManageClass.Name = "iconButtonManageClass";
            this.iconButtonManageClass.Padding = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.iconButtonManageClass.Size = new System.Drawing.Size(212, 50);
            this.iconButtonManageClass.TabIndex = 10;
            this.iconButtonManageClass.Text = "Gestionar clases";
            this.iconButtonManageClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonManageClass.UseVisualStyleBackColor = true;
            this.iconButtonManageClass.Click += new System.EventHandler(this.iconButtonManageClass_Click);
            // 
            // iconButtonManageTeacher
            // 
            this.iconButtonManageTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonManageTeacher.FlatAppearance.BorderSize = 0;
            this.iconButtonManageTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonManageTeacher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonManageTeacher.ForeColor = System.Drawing.Color.White;
            this.iconButtonManageTeacher.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.iconButtonManageTeacher.IconColor = System.Drawing.Color.White;
            this.iconButtonManageTeacher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonManageTeacher.IconSize = 35;
            this.iconButtonManageTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageTeacher.Location = new System.Drawing.Point(0, 265);
            this.iconButtonManageTeacher.Name = "iconButtonManageTeacher";
            this.iconButtonManageTeacher.Padding = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.iconButtonManageTeacher.Size = new System.Drawing.Size(212, 50);
            this.iconButtonManageTeacher.TabIndex = 9;
            this.iconButtonManageTeacher.Text = "Gestionar profesores";
            this.iconButtonManageTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonManageTeacher.UseVisualStyleBackColor = true;
            this.iconButtonManageTeacher.Click += new System.EventHandler(this.iconButtonManageTeacher_Click);
            // 
            // iconButtonManageStudent
            // 
            this.iconButtonManageStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonManageStudent.FlatAppearance.BorderSize = 0;
            this.iconButtonManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonManageStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonManageStudent.ForeColor = System.Drawing.Color.White;
            this.iconButtonManageStudent.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconButtonManageStudent.IconColor = System.Drawing.Color.White;
            this.iconButtonManageStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonManageStudent.IconSize = 35;
            this.iconButtonManageStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageStudent.Location = new System.Drawing.Point(0, 215);
            this.iconButtonManageStudent.Name = "iconButtonManageStudent";
            this.iconButtonManageStudent.Padding = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.iconButtonManageStudent.Size = new System.Drawing.Size(212, 50);
            this.iconButtonManageStudent.TabIndex = 8;
            this.iconButtonManageStudent.Text = "Gestionar alumnos";
            this.iconButtonManageStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManageStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonManageStudent.UseVisualStyleBackColor = true;
            this.iconButtonManageStudent.Click += new System.EventHandler(this.iconButtonManageStudent_Click);
            // 
            // iconButtonHome
            // 
            this.iconButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHome.FlatAppearance.BorderSize = 0;
            this.iconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHome.ForeColor = System.Drawing.Color.White;
            this.iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonHome.IconColor = System.Drawing.Color.White;
            this.iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHome.IconSize = 35;
            this.iconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.Location = new System.Drawing.Point(0, 165);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Padding = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.iconButtonHome.Size = new System.Drawing.Size(212, 50);
            this.iconButtonHome.TabIndex = 7;
            this.iconButtonHome.Text = "Home";
            this.iconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHome.UseVisualStyleBackColor = true;
            this.iconButtonHome.Click += new System.EventHandler(this.iconButtonHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 87);
            this.panel1.TabIndex = 6;
            // 
            // panelIzquierdaSuperiorLogo
            // 
            this.panelIzquierdaSuperiorLogo.Controls.Add(this.pictureBox2);
            this.panelIzquierdaSuperiorLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIzquierdaSuperiorLogo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdaSuperiorLogo.Name = "panelIzquierdaSuperiorLogo";
            this.panelIzquierdaSuperiorLogo.Size = new System.Drawing.Size(212, 165);
            this.panelIzquierdaSuperiorLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::checkATTdesktop.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(10, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.panelSuperior.Controls.Add(this.labelPantallaSeleccionada);
            this.panelSuperior.Controls.Add(this.labelNombreUsuario);
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(212, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(948, 86);
            this.panelSuperior.TabIndex = 1;
            // 
            // labelPantallaSeleccionada
            // 
            this.labelPantallaSeleccionada.AutoSize = true;
            this.labelPantallaSeleccionada.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPantallaSeleccionada.ForeColor = System.Drawing.Color.White;
            this.labelPantallaSeleccionada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPantallaSeleccionada.Location = new System.Drawing.Point(24, 28);
            this.labelPantallaSeleccionada.Name = "labelPantallaSeleccionada";
            this.labelPantallaSeleccionada.Size = new System.Drawing.Size(95, 33);
            this.labelPantallaSeleccionada.TabIndex = 4;
            this.labelPantallaSeleccionada.Text = "Home";
            this.labelPantallaSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.labelNombreUsuario.Location = new System.Drawing.Point(797, 29);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(139, 33);
            this.labelNombreUsuario.TabIndex = 3;
            this.labelNombreUsuario.Text = "Jose Luis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::checkATTdesktop.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(708, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(560, 242);
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
            this.labelMuestraHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(164)))), ((int)(((byte)(241)))));
            this.labelMuestraHora.Location = new System.Drawing.Point(698, 309);
            this.labelMuestraHora.Name = "labelMuestraHora";
            this.labelMuestraHora.Size = new System.Drawing.Size(130, 44);
            this.labelMuestraHora.TabIndex = 4;
            this.labelMuestraHora.Text = "label2";
            // 
            // labelMuestraFecha
            // 
            this.labelMuestraFecha.AutoSize = true;
            this.labelMuestraFecha.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestraFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(164)))), ((int)(((byte)(241)))));
            this.labelMuestraFecha.Location = new System.Drawing.Point(574, 367);
            this.labelMuestraFecha.Name = "labelMuestraFecha";
            this.labelMuestraFecha.Size = new System.Drawing.Size(96, 33);
            this.labelMuestraFecha.TabIndex = 5;
            this.labelMuestraFecha.Text = "label2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::checkATTdesktop.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(331, 240);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(223, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // iconButtonLogOut
            // 
            this.iconButtonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iconButtonLogOut.FlatAppearance.BorderSize = 0;
            this.iconButtonLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.iconButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogOut.ForeColor = System.Drawing.Color.Red;
            this.iconButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonLogOut.IconColor = System.Drawing.Color.Black;
            this.iconButtonLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogOut.Location = new System.Drawing.Point(36, 27);
            this.iconButtonLogOut.Name = "iconButtonLogOut";
            this.iconButtonLogOut.Size = new System.Drawing.Size(125, 38);
            this.iconButtonLogOut.TabIndex = 0;
            this.iconButtonLogOut.Text = "LogOut";
            this.iconButtonLogOut.UseVisualStyleBackColor = false;
            this.iconButtonLogOut.Click += new System.EventHandler(this.iconButtonLogOut_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1160, 623);
            this.Controls.Add(this.labelMuestraFecha);
            this.Controls.Add(this.labelMuestraHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelConTodoMenusIzquierda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 59);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.panelConTodoMenusIzquierda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelIzquierdaSuperiorLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConTodoMenusIzquierda;
        private System.Windows.Forms.Panel panelIzquierdaSuperiorLogo;
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
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private FontAwesome.Sharp.IconButton iconButtonManageHorario;
        private FontAwesome.Sharp.IconButton iconButtonManageModuls;
        private FontAwesome.Sharp.IconButton iconButtonManageClass;
        private FontAwesome.Sharp.IconButton iconButtonManageTeacher;
        private FontAwesome.Sharp.IconButton iconButtonManageStudent;
        private FontAwesome.Sharp.IconButton iconButtonLogOut;
    }
}
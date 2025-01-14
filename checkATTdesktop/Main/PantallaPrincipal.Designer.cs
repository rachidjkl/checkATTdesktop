﻿using System;
using System.Windows.Forms;

namespace checkATTdesktop.Main
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
            this.iconButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.panelIzquierdaSuperiorLogo = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.iconPictureBoxOpcionSeleccionada = new FontAwesome.Sharp.IconPictureBox();
            this.labelPantallaSeleccionada = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelMuestraFecha = new System.Windows.Forms.Label();
            this.labelMuestraHora = new System.Windows.Forms.Label();
            this.labelNombreApp = new System.Windows.Forms.Label();
            this.panelConTodoMenusIzquierda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelIzquierdaSuperiorLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxOpcionSeleccionada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
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
            // iconButtonLogOut
            // 
            this.iconButtonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iconButtonLogOut.FlatAppearance.BorderSize = 0;
            this.iconButtonLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.iconButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // panelIzquierdaSuperiorLogo
            // 
            this.panelIzquierdaSuperiorLogo.Controls.Add(this.iconPictureBox2);
            this.panelIzquierdaSuperiorLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIzquierdaSuperiorLogo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdaSuperiorLogo.Name = "panelIzquierdaSuperiorLogo";
            this.panelIzquierdaSuperiorLogo.Size = new System.Drawing.Size(212, 165);
            this.panelIzquierdaSuperiorLogo.TabIndex = 0;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 97;
            this.iconPictureBox2.Location = new System.Drawing.Point(22, 33);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(155, 97);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.panelSuperior.Controls.Add(this.iconPictureBoxOpcionSeleccionada);
            this.panelSuperior.Controls.Add(this.labelPantallaSeleccionada);
            this.panelSuperior.Controls.Add(this.labelNombreUsuario);
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(212, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(948, 86);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // iconPictureBoxOpcionSeleccionada
            // 
            this.iconPictureBoxOpcionSeleccionada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.iconPictureBoxOpcionSeleccionada.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxOpcionSeleccionada.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxOpcionSeleccionada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxOpcionSeleccionada.IconSize = 38;
            this.iconPictureBoxOpcionSeleccionada.Location = new System.Drawing.Point(19, 29);
            this.iconPictureBoxOpcionSeleccionada.Name = "iconPictureBoxOpcionSeleccionada";
            this.iconPictureBoxOpcionSeleccionada.Size = new System.Drawing.Size(44, 38);
            this.iconPictureBoxOpcionSeleccionada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxOpcionSeleccionada.TabIndex = 5;
            this.iconPictureBoxOpcionSeleccionada.TabStop = false;
            // 
            // labelPantallaSeleccionada
            // 
            this.labelPantallaSeleccionada.AutoSize = true;
            this.labelPantallaSeleccionada.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPantallaSeleccionada.ForeColor = System.Drawing.Color.White;
            this.labelPantallaSeleccionada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPantallaSeleccionada.Location = new System.Drawing.Point(69, 32);
            this.labelPantallaSeleccionada.Name = "labelPantallaSeleccionada";
            this.labelPantallaSeleccionada.Size = new System.Drawing.Size(95, 33);
            this.labelPantallaSeleccionada.TabIndex = 4;
            this.labelPantallaSeleccionada.Text = "Home";
            this.labelPantallaSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.labelNombreUsuario.Location = new System.Drawing.Point(797, 29);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(135, 36);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.iconPictureBox1);
            this.panelDesktop.Controls.Add(this.labelMuestraFecha);
            this.panelDesktop.Controls.Add(this.labelMuestraHora);
            this.panelDesktop.Controls.Add(this.labelNombreApp);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(212, 86);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(948, 537);
            this.panelDesktop.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 158;
            this.iconPictureBox1.Location = new System.Drawing.Point(124, 188);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(231, 158);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelMuestraFecha
            // 
            this.labelMuestraFecha.AutoSize = true;
            this.labelMuestraFecha.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestraFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(164)))), ((int)(((byte)(241)))));
            this.labelMuestraFecha.Location = new System.Drawing.Point(361, 313);
            this.labelMuestraFecha.Name = "labelMuestraFecha";
            this.labelMuestraFecha.Size = new System.Drawing.Size(96, 33);
            this.labelMuestraFecha.TabIndex = 12;
            this.labelMuestraFecha.Text = "label2";
            // 
            // labelMuestraHora
            // 
            this.labelMuestraHora.AutoSize = true;
            this.labelMuestraHora.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestraHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(164)))), ((int)(((byte)(241)))));
            this.labelMuestraHora.Location = new System.Drawing.Point(485, 255);
            this.labelMuestraHora.Name = "labelMuestraHora";
            this.labelMuestraHora.Size = new System.Drawing.Size(130, 44);
            this.labelMuestraHora.TabIndex = 11;
            this.labelMuestraHora.Text = "label2";
            // 
            // labelNombreApp
            // 
            this.labelNombreApp.AutoSize = true;
            this.labelNombreApp.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(103)))), ((int)(((byte)(229)))));
            this.labelNombreApp.Location = new System.Drawing.Point(392, 188);
            this.labelNombreApp.Name = "labelNombreApp";
            this.labelNombreApp.Size = new System.Drawing.Size(434, 44);
            this.labelNombreApp.TabIndex = 10;
            this.labelNombreApp.Text = "CHECKATT Managment";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1160, 623);
            this.Controls.Add(this.panelDesktop);
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
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxOpcionSeleccionada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConTodoMenusIzquierda;
        private System.Windows.Forms.Panel panelIzquierdaSuperiorLogo;
        private System.Windows.Forms.Panel panelSuperior;
        private PictureBox pictureBox1;
        private Label labelPantallaSeleccionada;
        private Label labelNombreUsuario;
        private Timer timer1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private FontAwesome.Sharp.IconButton iconButtonManageHorario;
        private FontAwesome.Sharp.IconButton iconButtonManageModuls;
        private FontAwesome.Sharp.IconButton iconButtonManageClass;
        private FontAwesome.Sharp.IconButton iconButtonManageTeacher;
        private FontAwesome.Sharp.IconButton iconButtonManageStudent;
        private FontAwesome.Sharp.IconButton iconButtonLogOut;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxOpcionSeleccionada;
        private Panel panelDesktop;
        private Label labelMuestraFecha;
        private Label labelMuestraHora;
        private Label labelNombreApp;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
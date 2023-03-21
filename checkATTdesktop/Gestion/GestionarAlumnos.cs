﻿using checkATTdesktop.Models;
using checkATTdesktop.ModiAdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace checkATTdesktop.Gestion
{
    public partial class GestionarAlumnos : Form
    {
        private Form currentChildForm;
        public GestionarAlumnos()
        {
            InitializeComponent();
        }
  

        private void textBoxBuscarAlumno_Enter(object sender, EventArgs e)
        {
            if (textBoxBuscarAlumno.Text == "Buscar...")
            {
                textBoxBuscarAlumno.Text = "";
                textBoxBuscarAlumno.ForeColor = Color.Black;
            }
        }

        private void textBoxBuscarAlumno_Leave(object sender, EventArgs e)
        {
            if (textBoxBuscarAlumno.Text == "")
            {
                textBoxBuscarAlumno.Text = "Buscar...";
                textBoxBuscarAlumno.ForeColor = Color.Black;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            textBoxBuscarAlumno.Text = "Buscar...";
        }

        private void buttonCrearAlumno_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCrearAlumno_Click_1(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModiAddStudent());
        }

        private void buttonModiAlumno_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModiAddStudent());
        }

        private void abrirFormularioHijo(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCrearModificarAlumno.Controls.Add(childForm);
            panelCrearModificarAlumno.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void GestionarAlumnos_Load(object sender, EventArgs e)
        {
            bindingSourceComboBoxClase.DataSource = ClaseOrm.Select();
            cargarAlumnos();   
        }

        private void comboBoxSeleccionarClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarAlumnos();
        }

        private void cargarAlumnos()
        {
            Clase _clase = (Clase)comboBoxSeleccionarClase.SelectedItem;
            bindingSourceDataGridAlumnos.DataSource = _clase.Alumno.ToList();
        }
    }
}

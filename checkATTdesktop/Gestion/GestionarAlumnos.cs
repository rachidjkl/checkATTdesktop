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


        private void buttonCrearAlumno_Click_1(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModiAddStudent());
            
        }

        private void buttonModiAlumno_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModiAddStudent((Alumno)dataGridViewAlumnos.CurrentRow.DataBoundItem));

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

        public void cargarAlumnos()
        {
            Clase _clase = (Clase)comboBoxSeleccionarClase.SelectedItem;
            if (_clase != null)
            {
                bindingSourceDataGridAlumnos.DataSource = _clase.Alumno.ToList();
            }           
        }

        private void buttonEliminarAlumno_Click(object sender, EventArgs e)
        {
            String missatge = "";
            Alumno alumno = (Alumno)dataGridViewAlumnos.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de borrar?", "Eliminar alumno", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                if (dataGridViewAlumnos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No has seleccionado ningún alumno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    missatge = AlumnosOrm.Delete((Alumno)dataGridViewAlumnos.SelectedRows[0].DataBoundItem);

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cargarAlumnos();
                    }
                }

            }
        }

        private void buttonMatricularAlumnosUF_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridViewAlumnos.SelectedRows;
            List<Alumno> alumnosSeleccionados = new List<Alumno>();

            alumnosSeleccionados = seleccionarAlumnos(alumnosSeleccionados);

            GestionarMatriculacionUF matricularUF = new GestionarMatriculacionUF(alumnosSeleccionados, (int)comboBoxSeleccionarClase.SelectedValue);
            matricularUF.ShowDialog();
            
        }

        private void dataGridViewAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Alumno alumno = (Alumno)dataGridViewAlumnos.Rows[e.RowIndex].DataBoundItem;
                e.Value = alumno.apellido1_alumno + " " + alumno.apellido2_alumno;
            }
        }

        private void checkBoxSelectAllStudents_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAllStudents.Checked)
            {
                foreach (DataGridViewRow row in dataGridViewAlumnos.Rows)
                {                   
                    row.Selected = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewAlumnos.Rows)
                {
                    row.Selected = false;
                }
            }
        }

        private List<Alumno> seleccionarAlumnos(List<Alumno> alumnosSeleccionados)
        {
            DataGridViewSelectedRowCollection rows = dataGridViewAlumnos.SelectedRows;

            foreach (DataGridViewRow row in rows)
            {
                Alumno _uf = (Alumno)row.DataBoundItem;

                alumnosSeleccionados.Add(_uf);
            }
            return alumnosSeleccionados;
        }

        private void dataGridViewAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Alumno alumno = (Alumno)dataGridViewAlumnos.Rows[e.RowIndex].DataBoundItem;
                e.Value = alumno.Usuarios_CEP.correo_cep;
            }
        }
    }
}

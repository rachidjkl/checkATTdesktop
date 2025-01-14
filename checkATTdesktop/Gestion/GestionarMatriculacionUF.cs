﻿using checkATTdesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace checkATTdesktop.Gestion
{
    public partial class GestionarMatriculacionUF : Form
    {
        public List<Alumno> alumnosSeleccionados { get; set; }
        int id_clase;

        public GestionarMatriculacionUF()
        {
            InitializeComponent();
        }

        public GestionarMatriculacionUF(List<Alumno> alumnosSeleccionados, int id_clase)
        {
            InitializeComponent();
            this.alumnosSeleccionados = alumnosSeleccionados;    
            this.id_clase = id_clase;
        }

        private void iconPictureBoxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionarMatriculacionUF_Load(object sender, EventArgs e)
        {
            bindingSourceComboBoxModulos.DataSource = ModulosOrm.SelectPers(id_clase);
            cargarUFs();
        }


        private void comboBoxModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarUFs();
        }


        public void cargarUFs()
        {
            Modulo _modulo = (Modulo)comboBoxModulos.SelectedItem;
            if (_modulo != null)
            {
                bindingSourceDataGridUF.DataSource = _modulo.UF.ToList();
            }

        }

        private void iconButtonAceptar_Click(object sender, EventArgs e)
        {
            String missatge = "";
            List<UF> ufSeleccionadas = new List<UF>();

            ufSeleccionadas = seleccionarUF(ufSeleccionadas);

            foreach (UF uf in ufSeleccionadas)
            {
                foreach (Alumno alumno in alumnosSeleccionados)
                {               
                    Matricula matriculacion = new Matricula();
                    matriculacion.id_uf = uf.id_uf;
                    matriculacion.id_alumno = alumno.id_alumno;
                    matriculacion.fecha_matricula = DateTime.Now;
                    matriculacion.horas_cursadas_uf = 0;
                    missatge += MatriculaOrm.Insert(matriculacion);

                }
            }
            if (missatge != "")
            {
                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Matriculacion correcta", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private List<UF> seleccionarUF(List<UF>ufSeleccionadas)
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            
            foreach (DataGridViewRow row in rows)
            {
                UF _uf = (UF)row.DataBoundItem;

                ufSeleccionadas.Add(_uf);
            }
            return ufSeleccionadas;
        }

        private void checkBoxSelectAllUF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAllUF.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Selected = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Selected = false;
                }
            }
        }
    }
}
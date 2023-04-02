using checkATTdesktop.Models;
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
        public GestionarMatriculacionUF()
        {
            InitializeComponent();
        }

        public GestionarMatriculacionUF(List<Alumno> alumnosSeleccionados)
        {
            InitializeComponent();
            this.alumnosSeleccionados = alumnosSeleccionados;

            //foreach (Alumno alumno in alumnosSeleccionados)
            //{
            //    // agrega el ID del alumno al ListBox
            //    listBox1.Items.Add(alumno.IdAlumno);
                
            //}            
        }

        private void iconPictureBoxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionarMatriculacionUF_Load(object sender, EventArgs e)
        {
            bindingSourceComboBoxModulos.DataSource = ModulosOrm.Select();
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
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            UF uf = (UF)dataGridView1.CurrentRow.DataBoundItem;

            foreach (Alumno alumno in alumnosSeleccionados)
            {               
                Matricula matriculacion = new Matricula();
                matriculacion.id_uf = uf.id_uf;
                matriculacion.id_alumno = alumno.id_alumno;
                matriculacion.fecha_matricula = DateTime.Now;
                matriculacion.horas_cursadas_uf = 0;
                missatge = MatriculaOrm.Insert(matriculacion);
                
                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Matriculacion correcta", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                }
            }
        }
    }
}
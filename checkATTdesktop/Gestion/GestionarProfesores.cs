using checkATTdesktop.Models;
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
    public partial class GestionarProfesores : Form
    {
        private Form currentChildForm;
        public GestionarProfesores()
        {
            InitializeComponent();
        }

        private void textBoxBuscarProfesor_Enter(object sender, EventArgs e)
        {
            if (textBoxBuscarProfesor.Text == "Buscar...")
            {
                textBoxBuscarProfesor.Text = "";
                textBoxBuscarProfesor.ForeColor = Color.Black;
            }
        }

        private void textBoxBuscarProfesor_Leave(object sender, EventArgs e)
        {
            if (textBoxBuscarProfesor.Text == "")
            {
                textBoxBuscarProfesor.Text = "Buscar...";
                textBoxBuscarProfesor.ForeColor = Color.Black;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            textBoxBuscarProfesor.Text = "Buscar...";
        }

        private void buttonCrearProfesor_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModiAddTeacher());
        }

        private void buttonModiProfesor_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModiAddTeacher());
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
            panelCrearModificarProfesores.Controls.Add(childForm);
            panelCrearModificarProfesores.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void GestionarProfesores_Load(object sender, EventArgs e)
        {
            bindingSourceDataGridProfesores.DataSource = ProfesoresOrm.Select();
        }

        private void dataGridViewProfesor_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            String missatge = "";

            if (dataGridViewProfesor.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    missatge = ProfesoresOrm.Delete((Profesor)dataGridViewProfesor.SelectedRows[0].DataBoundItem);

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }

            }
            {

            }
        }
    }
}

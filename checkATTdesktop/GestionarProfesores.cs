using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkATTdesktop
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

        private void buttonCrearAlumno_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModiAddTeacher());
        }

        private void buttonModiAlumno_Click(object sender, EventArgs e)
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

        
    }
}

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
    public partial class GestionarAlumnos : Form
    {
        private Form currentChildForm;
        public GestionarAlumnos()
        {
            InitializeComponent();
            rellenarGrid();
        }
  

        private void rellenarGrid()
        {
            List<User> usuarios = new List<User>();
            usuarios.Add(new User("Joel", "Marcos", "123456789", "645213798", "j@gmail.com", "calle"));
            usuarios.Add(new User("Jacinta", "Marcos", "123456789", "645213798", "j@gmail.com", "calle"));
            usuarios.Add(new User("Vcitor", "Foqueta", "123456789", "645213798", "j@gmail.com", "calle"));
            usuarios.Add(new User("Herrero", "En plan", "123456789", "645213798", "j@gmail.com", "calle"));

            foreach (User u in usuarios)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells[0].Value = u.Nombre;
                row.Cells[1].Value = u.Apellido;
                row.Cells[2].Value = u.DNI;
                row.Cells[3].Value = u.Telefono;
                row.Cells[4].Value = u.Correo;  
                row.Cells[5].Value = u.Direccion;
            }

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

    }
}

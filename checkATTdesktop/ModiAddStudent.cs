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
    public partial class ModiAddStudent : Form
    {

        private Form currentChildForm;
        public ModiAddStudent()
        {
            InitializeComponent();            
        }


        private void iconButtonAceptar_Click(object sender, EventArgs e)
        {
            todoRelleno();
        }

        private void todoRelleno()
        {
            bool relleno = true;

            if (textBoxCorreo.Text == "" || textBoxCorreoCentro.Text == "" || textBoxDireccion.Text == "" || textBoxDNI.Text == "" || 
                textBoxIncorporacion.Text == "" || textBoxNombre.Text == "" || textBoxPrimerApellido.Text == "" || textBoxSegundoApellido.Text == "" ||
                textBoxTelefono.Text == "" || comboBoxClase.SelectedIndex == -1 || comboBoxCurso.SelectedIndex == -1)
            {
                relleno = false;
                MessageBox.Show("Alguno de los campos estan vacios...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                relleno = true;
            }
        }

       
    }
}

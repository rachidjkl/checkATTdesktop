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
    public partial class ModiAddTeacher : Form
    {
        public ModiAddTeacher()
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
                textBoxIncorporacion.Text == "" || textBoxNombre.Text == "" || textBoxPrimerApellido.Text == "" ||
                textBoxSegundoApellido.Text == "" || textBoxTelefono.Text == "")
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

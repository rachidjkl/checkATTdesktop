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
    public partial class AddStudent : Form
    {

        private Form currentChildForm;
        public AddStudent()
        {
            InitializeComponent();
            
        }

        private void iconButton1Aceptar_Click(object sender, EventArgs e)
        {
            
        }


        private bool todoRelleno()
        {
            bool relleno = true;

            if (textBoxCorreo.Text == "" || textBoxCorreoCentro.Text == "" || textBoxDireccion.Text == "" || textBoxDNI.Text == "" || 
                textBoxIncorporacion.Text == "" || textBoxNombre.Text == "" || textBoxPrimerApellido.Text == "" || textBoxSegundoApellido.Text == "" ||
                textBoxTelefono.Text == "" || comboBoxClase.SelectedIndex == -1 || dateTimePickerNacimiento.Value == null)
            {
                relleno = false;
            }
            else
            {
                relleno = true;
            }
            return relleno;
        }

    }
}

using checkATTdesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkATTdesktop.ModiAdd
{
    public partial class ModiAddTeacher : Form
    {
        public ModiAddTeacher()
        {
            InitializeComponent();
        }

        private void iconButtonAceptar_Click(object sender, EventArgs e)
        {          
            if (todoRelleno())
            {
                Profesor profeToAdd = new Profesor();
                profeToAdd.nombre_profe = textBoxNombre.Text;
                profeToAdd.apellido1_profe = textBoxPrimerApellido.Text;
                profeToAdd.apellido2_profe = textBoxSegundoApellido.Text;
                profeToAdd.email_profe = textBoxCorreo.Text;
                profeToAdd.email_centro_profe = textBoxCorreoCentro.Text;
                profeToAdd.direccion_profe = textBoxDireccion.Text;
                profeToAdd.tel_profe = int.Parse(textBoxTelefono.Text);
                profeToAdd.dni_profe = (textBoxDNI.Text);
                profeToAdd.incorp_profe = dateTimePickerNacimiento.Value;
                profeToAdd.nacimiento_profe = dateTimePickerNacimiento.Value;

                ProfesoresOrm.Insert(profeToAdd);

                MessageBox.Show("Profesor añadido correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool todoRelleno()
        {
            bool relleno = true;

            if (textBoxCorreo.Text == "" || textBoxCorreoCentro.Text == "" || textBoxDireccion.Text == "" || textBoxDNI.Text == "" ||
                textBoxNombre.Text == "" || textBoxPrimerApellido.Text == "" ||
                textBoxSegundoApellido.Text == "" || textBoxTelefono.Text == "")
            {
                relleno = false;
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            return relleno;
        }        
    }
}

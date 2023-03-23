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
    public partial class ModiAddStudent : Form
    {

        private Form currentChildForm;
        public ModiAddStudent()
        {
            InitializeComponent();            
        }


        private void iconButtonAceptar_Click(object sender, EventArgs e)
        {
            if (todoRelleno())
            {
                Alumno alumnoToAdd = new Alumno(); 
                alumnoToAdd.dni_alumno = textBoxDNI.Text;
                alumnoToAdd.nombre_alumno = textBoxNombre.Text; 
                alumnoToAdd.apellido1_alumno = textBoxPrimerApellido.Text;
                alumnoToAdd.apellido2_alumno = textBoxSegundoApellido.Text;
                alumnoToAdd.direccion_alumno = textBoxDireccion.Text;
                alumnoToAdd.email_alumno = textBoxCorreo.Text;
                alumnoToAdd.email_centro_alumno= textBoxCorreoCentro.Text;
                alumnoToAdd.tel_alumno = int.Parse(textBoxTelefono.Text);
                alumnoToAdd.nacimiento_alumno = dateTimePickerNacimiento.Value;
                alumnoToAdd.horas_cursadas_totales_alumno = 0;
                alumnoToAdd.incorp_alumno = dateTimePickerIncorporacion.Value;
                alumnoToAdd.año_cursando_alumno = "22/23";
                alumnoToAdd.id_clase = comboBoxClase.SelectedValue.ToString();


                AlumnosOrm.Insert(alumnoToAdd);
                MessageBox.Show("Alumno añadido correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

       

        private  bool todoRelleno()
        {
            bool relleno = true;

            if (textBoxCorreo.Text == "" || textBoxCorreoCentro.Text == "" || textBoxDireccion.Text == "" || textBoxDNI.Text == "" || 
                textBoxNombre.Text == "" || textBoxPrimerApellido.Text == "" || textBoxSegundoApellido.Text == "" ||
                textBoxTelefono.Text == "" || comboBoxClase.SelectedIndex == -1 || comboBoxCurso.SelectedIndex == -1)
            {
                relleno = false;
                MessageBox.Show("Alguno de los campos estan vacios", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return relleno;
        }

        private void vaciarCampos()
        {
            textBoxCorreo.Text = "";
            textBoxCorreoCentro.Text = "";
            textBoxDireccion.Text = "";
            textBoxDNI.Text = "";
            textBoxNombre.Text = "";
            textBoxPrimerApellido.Text = "";
            textBoxSegundoApellido.Text = "";
            textBoxTelefono.Text = "";
            comboBoxClase.SelectedIndex = -1;
            comboBoxCurso.SelectedIndex = -1;

        }

        private void panelCrearAlumnoPorfa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModiAddStudent_Load(object sender, EventArgs e)
        {
            bindingSourceComboxCrearAlumno.DataSource = ClaseOrm.Select();
        }


    }
}

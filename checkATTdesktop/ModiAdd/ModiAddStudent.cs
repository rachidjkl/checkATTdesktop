using checkATTdesktop.Gestion;
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

       

        //variable global donde guardaremos el nickname del usuario que estamos modificando
        //si estamos crando un usuario este campo estará vacio
        private Alumno alumno = null;


        public ModiAddStudent()
        {
            InitializeComponent();            
        }

        public ModiAddStudent(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }


        private void iconButtonAceptar_Click(object sender, EventArgs e)
        {
            String missatge = "";
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
                alumnoToAdd.año_cursando_alumno = comboBoxCurso.SelectedItem.ToString();
                alumnoToAdd.id_clase = (int)comboBoxClase.SelectedValue;

                if (alumno != null)
                {
                    alumnoToAdd.id_alumno = alumno.id_alumno;
                    missatge = AlumnosOrm.Update(alumnoToAdd);   
                }
                else
                {
                    missatge = AlumnosOrm.Insert(alumnoToAdd);
                }
               

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (alumno == null)
                    {
                        MessageBox.Show("Alumno añadido correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vaciarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Alumno modificado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    
                }           
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


        private void ModiAddStudent_Load(object sender, EventArgs e)
        {
            bindingSourceClasesCombo.DataSource = ClaseOrm.Select();

            if (alumno != null)
            {
                textBoxNombre.Text = alumno.nombre_alumno.ToString();
                textBoxCorreo.Text = alumno.email_alumno.ToString();
                textBoxCorreoCentro.Text = alumno.email_centro_alumno.ToString();
                textBoxDireccion.Text = alumno.direccion_alumno.ToString();
                textBoxDNI.Text = alumno.dni_alumno.ToString();
                textBoxPrimerApellido.Text = alumno.apellido1_alumno.ToString();
                textBoxSegundoApellido.Text = alumno.apellido2_alumno.ToString();
                textBoxTelefono.Text = alumno.tel_alumno.ToString();
                comboBoxClase.SelectedValue = alumno.id_clase.ToString();
                dateTimePickerNacimiento.Value = alumno.nacimiento_alumno;
                comboBoxCurso.SelectedItem = alumno.año_cursando_alumno.ToString();

            }

        }


    }
}

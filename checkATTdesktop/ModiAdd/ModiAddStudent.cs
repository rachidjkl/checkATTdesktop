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
                Usuarios_CEP userAlumno = rellenarUsuarioCep();
                Alumno alumnoToAdd = rellenarAlumno();
              
                if (alumno != null)
                {
                    alumnoToAdd.id_alumno = alumno.id_alumno;
                    userAlumno.id_usuario_cep = alumno.id_user_alumno_cep;
                    missatge = UsersCepORM.Update(userAlumno);
                    missatge += AlumnosOrm.Update(alumnoToAdd);
                    showMessage(missatge);
                }
                else
                {
                    missatge = UsersCepORM.Insert(userAlumno);

                    if (missatge == "")
                    {
                        alumnoToAdd.id_user_alumno_cep = UsersCepORM.SelectUserCepId(textBoxCorreoCentro.Text);
                        missatge = AlumnosOrm.Insert(alumnoToAdd);
                    }
                    showMessage(missatge);

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

        public Usuarios_CEP rellenarUsuarioCep()
        {
            Usuarios_CEP usuarioCep = new Usuarios_CEP();
            usuarioCep.correo_cep = textBoxCorreoCentro.Text;
            usuarioCep.contra = textBoxDNI.Text;
            usuarioCep.tipo_usuario = 2;

            return usuarioCep;
        }

        public void showMessage(String missatge)
        {
            if (missatge != "")
            {
                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (alumno == null)
                {
                    MessageBox.Show("Alumno añadido correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    vaciarCampos();
                }
                else
                {
                    MessageBox.Show("Alumno modificado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        public Alumno rellenarAlumno()
        {
            Alumno alumno = new Alumno();
            alumno.dni_alumno = textBoxDNI.Text;
            alumno.nombre_alumno = textBoxNombre.Text;
            alumno.apellido1_alumno = textBoxPrimerApellido.Text;
            alumno.apellido2_alumno = textBoxSegundoApellido.Text;
            alumno.direccion_alumno = textBoxDireccion.Text;
            alumno.email_alumno = textBoxCorreo.Text;
            alumno.tel_alumno = int.Parse(textBoxTelefono.Text);
            alumno.nacimiento_alumno = dateTimePickerNacimiento.Value;
            alumno.horas_cursadas_totales_alumno = 0;
            alumno.incorp_alumno = dateTimePickerIncorporacion.Value;
            alumno.año_cursando_alumno = comboBoxCurso.SelectedItem.ToString();
            alumno.id_clase = (int)comboBoxClase.SelectedValue;

            return alumno;
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
                textBoxCorreoCentro.Text = UsersCepORM.SelectUserCepEmail(alumno.id_user_alumno_cep);
                textBoxDireccion.Text = alumno.direccion_alumno.ToString();
                textBoxDNI.Text = alumno.dni_alumno.ToString();
                textBoxPrimerApellido.Text = alumno.apellido1_alumno.ToString();
                textBoxSegundoApellido.Text = alumno.apellido2_alumno.ToString();
                textBoxTelefono.Text = alumno.tel_alumno.ToString();
                comboBoxClase.SelectedValue = alumno.id_clase;
                dateTimePickerNacimiento.Value = alumno.nacimiento_alumno;
                comboBoxCurso.SelectedItem = alumno.año_cursando_alumno.ToString();

            }

        }


    }
}

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
        //variable global donde guardaremos el nickname del usuario que estamos modificando
        //si estamos crando un usuario este campo estará vacio
        private Profesor profesor = null;

        public ModiAddTeacher()
        {
            InitializeComponent();
        }

        public ModiAddTeacher(Profesor profesor)
        {
            InitializeComponent();
            this.profesor = profesor;   
        }


        private void iconButtonAceptar_Click(object sender, EventArgs e)
        {
            String missatge = "";
            if (todoRelleno())
            {
                Usuarios_CEP userProfe = rellenarUsuarioCep();
                Profesor profe = rellenarProfesor();

                if (profesor != null)
                {
                    profe.id_profe = profesor.id_profe;
                    userProfe.id_usuario_cep = profesor.id_user_profe_cep;
                    missatge = UsersCepORM.Update(userProfe);
                    missatge += ProfesoresOrm.Update(profe);
                    showMessage(missatge);
                }
                else
                {
                    missatge = UsersCepORM.Insert(userProfe);

                    if (missatge == "")
                    {
                        profe.id_user_profe_cep = UsersCepORM.SelectUserCepId(textBoxCorreoCentro.Text);
                        missatge = ProfesoresOrm.Insert(profe);
                    }
                    showMessage(missatge);
                }


            }
        }

        public Profesor rellenarProfesor()
        {
            Profesor profeToAdd = new Profesor();
            profeToAdd.nombre_profe = textBoxNombre.Text;
            profeToAdd.apellido1_profe = textBoxPrimerApellido.Text;
            profeToAdd.apellido2_profe = textBoxSegundoApellido.Text;
            profeToAdd.email_profe = textBoxCorreo.Text;
            profeToAdd.direccion_profe = textBoxDireccion.Text;
            profeToAdd.tel_profe = int.Parse(textBoxTelefono.Text);
            profeToAdd.dni_profe = (textBoxDNI.Text);
            profeToAdd.incorp_profe = dateTimePickerNacimiento.Value;
            profeToAdd.nacimiento_profe = dateTimePickerNacimiento.Value;

            return profeToAdd;
        }

        public Usuarios_CEP rellenarUsuarioCep()
        {
            Usuarios_CEP usuarioCep = new Usuarios_CEP();
            usuarioCep.correo_cep = textBoxCorreoCentro.Text;
            usuarioCep.contra = textBoxDNI.Text;
            usuarioCep.tipo_usuario = 1;
          
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
                if (profesor == null)
                {
                    MessageBox.Show("Profesor añadido correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    vaciarCampos();
                }
                else
                {
                    MessageBox.Show("Profesor modificado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
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
        

        private void vaciarCampos()
        {
            textBoxCorreo.Text  =  "";
            textBoxCorreoCentro.Text = "";
            textBoxDireccion.Text = "";
            textBoxDNI.Text = "";
            textBoxNombre.Text = "";
            textBoxPrimerApellido.Text = "";
            textBoxSegundoApellido.Text = "";
            textBoxTelefono.Text = "";
        }

        private void ModiAddTeacher_Load(object sender, EventArgs e)
        {
            
            if (profesor != null)
            {
                textBoxNombre.Text = profesor.nombre_profe;
                textBoxCorreo.Text = profesor.email_profe;
                textBoxCorreoCentro.Text = UsersCepORM.SelectUserCepEmail(profesor.id_user_profe_cep); 
                textBoxDireccion.Text = profesor.direccion_profe;
                textBoxDNI.Text = profesor.dni_profe;
                textBoxPrimerApellido.Text = profesor.apellido1_profe;
                textBoxSegundoApellido.Text = profesor.apellido2_profe;
                textBoxTelefono.Text = profesor.tel_profe.ToString();
                dateTimePickerNacimiento.Value = profesor.nacimiento_profe;
                dateTimePickerIncorporacion.Value = profesor.incorp_profe;


            }
        }
    }
}

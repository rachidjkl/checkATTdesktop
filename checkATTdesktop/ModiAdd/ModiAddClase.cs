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
    public partial class ModiAddClase : Form
    {

        private Clase clase = null;

        public ModiAddClase()
        {
            InitializeComponent();
        }

        public ModiAddClase(Clase clase)
        {
            InitializeComponent();
            this.clase = clase;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCrearModiAddClase_Click(object sender, EventArgs e)
        {
            if (textBoxNombreClase.Text == "" || comboBoxTutor.SelectedIndex == -1)
            {
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
            }
            else
            {
                String missatge = "";
                Clase classtoAdd = new Clase();
                classtoAdd.nombre_clase = textBoxNombreClase.Text;
                classtoAdd.id_tutor_clase = (int)comboBoxTutor.SelectedValue;

                if (clase != null)
                {                                
                    classtoAdd.id_clase = clase.id_clase; //Cuando editamos cogemos el valor del id, para pasarselo al update
                    missatge = ClaseOrm.Update(classtoAdd);
                }
                else
                {

                    missatge = ClaseOrm.Insert(classtoAdd);
                }


                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    if (clase == null)
                    {
                        MessageBox.Show("Clase añadida correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vaciarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Clase modificada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }                    
                }

            }
        }

        private void ModiAddClase_Load(object sender, EventArgs e)
        {
            bindingSourceComboBoxProfes.DataSource = ProfesoresOrm.Select();
            if (clase != null)
            {
                textBoxNombreClase.Text = clase.nombre_clase;
                comboBoxTutor.SelectedValue = clase.id_tutor_clase;
                buttonCrearModiAddClase.Text = "Modificar";
            }
        }

        private void vaciarCampos()
        {
            textBoxNombreClase.Text = "";
            comboBoxTutor.SelectedIndex = -1;
        }
    }
}

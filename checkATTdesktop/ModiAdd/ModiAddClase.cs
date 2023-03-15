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
        public ModiAddClase()
        {
            InitializeComponent();
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
                            // MessageBoxIcon.Warning // for Warning  
                            //MessageBoxIcon.Error // for Error 
                            //MessageBoxIcon.Information  // for Information
                            //MessageBoxIcon.Question // for Question
            } else
            {

            }
        }
    }
}

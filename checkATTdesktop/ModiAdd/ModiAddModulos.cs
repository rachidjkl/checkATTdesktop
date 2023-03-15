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
    public partial class ModiAddModulos : Form
    {
        public ModiAddModulos()
        {
            InitializeComponent();
        }

        private void buttonEditarUF_Click(object sender, EventArgs e)
        {
            ModiAddUF editUF = new ModiAddUF();
            editUF.ShowDialog();
        }

        private void buttonCrearUF_Click(object sender, EventArgs e)
        {
            ModiAddUF addUF = new ModiAddUF();
            addUF.ShowDialog();
        }

        private void buttonCrearModulo_Click(object sender, EventArgs e)
        {
            if (textBoxNombreModulo.Text == "")
            {
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
/**
 * MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // MessageBoxIcon.Warning // for Warning  
                            //MessageBoxIcon.Error // for Error 
                            //MessageBoxIcon.Information  // for Information
                            //MessageBoxIcon.Question // for Question
**/
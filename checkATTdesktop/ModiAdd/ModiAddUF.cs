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
    public partial class ModiAddUF : Form
    {
        public ModiAddUF()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void buttonCrearModiAddUF_Click(object sender, EventArgs e)
        {
            if (textBox1NombreUF.Text == "" || textBoxHorasTotales.Text == "" || textBoxNumeroUF.Text == "")
            {
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


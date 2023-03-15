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
    public partial class ModiAddHorario : Form
    {
        public ModiAddHorario()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCrearModiAddHorario_Click(object sender, EventArgs e)
        {
            if (comboBoxClase.SelectedIndex == -1 || comboBoxDiaSemana.SelectedIndex == -1 || comboBoxModulo.SelectedIndex == -1)
            {
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {

            }
        }
    }
}



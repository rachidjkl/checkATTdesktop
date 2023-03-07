using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkATTdesktop
{
    public partial class GestionarClases : Form
    {
        public GestionarClases()
        {
            InitializeComponent();
        }

        private void buttonCrearClase_Click(object sender, EventArgs e)
        {
            ModiAddClase addClass = new ModiAddClase();
            addClass.ShowDialog();
        }

        private void buttonModiClase_Click(object sender, EventArgs e)
        {
            ModiAddClase addClass = new ModiAddClase();
            addClass.ShowDialog();
        }
    }
}

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
    }
}

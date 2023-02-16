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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            PantallaPrincipal mainMenu = new PantallaPrincipal();
            mainMenu.ShowDialog();

            this.Close();
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            textBoxUser.BackColor = Color.White;
            panelUsername.BackColor = Color.White;
            textBoxContra.BackColor = this.BackColor;
            panelContra.BackColor = this.BackColor;
        }

        private void textBoxContra_Click(object sender, EventArgs e)
        {
            textBoxUser.BackColor = this.BackColor;
            panelUsername.BackColor = this.BackColor;
            textBoxContra.BackColor = Color.White;
            panelContra.BackColor = Color.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkATTdesktop.LoginFolder
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void iconButtonAceptarRestablecerContraseña_Click(object sender, EventArgs e)
        {
            if (textBoxCorreoRestablecerContraseña.Text != "")
            {              
                MessageBox.Show("Hemos enviado una nueva contraseña al correo que nos has proporcionado", "Contraseña restablecida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No has introducido ningún correo", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error
);
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

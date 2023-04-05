using checkATTdesktop.Main;
using checkATTdesktop.Models;
using checkATTdesktop.ModiAdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkATTdesktop.LoginFolder
{
    public partial class Login : Form
    {
        UserLogin userLogin = new UserLogin();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool acces = true;

            acces = comprobacionLogin(textBoxUser.Text, textBoxContra.Text, acces);

            if (acces)
            {
                MessageBox.Show("Login correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                userLogin.Username = textBoxUser.Text;
                userLogin.Password = textBoxContra.Text;   

                WelcomeForm mainMenu = new WelcomeForm(userLogin);
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                          
        }

        private bool comprobacionLogin(String username, String password, bool acces)
        {

            if (username == "Administrador" || password == "admin12345")
            {
                acces = true;
            }
            else if (username == "Recepción" || password == "recepcio12345")
            {
                acces = true;
            }
            else 
            {
                acces = false;
            }

            return acces;
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

        private void button2_Click(object sender, EventArgs e)
        {
            ForgotPassword addClass = new ForgotPassword();
            addClass.ShowDialog();
        }
    }
}

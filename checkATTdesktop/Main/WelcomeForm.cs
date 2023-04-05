using checkATTdesktop.LoginFolder;
using checkATTdesktop.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkATTdesktop.Main
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm(UserLogin userLogin)
        {
            InitializeComponent();
            labelNombreUsuario.Text = userLogin.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            this.Close();
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timerFadeIn.Stop();
                FadeOut.Start(); 
            }
        }

        private void FadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (this.Opacity==0)
            {
                FadeOut.Stop();

                PantallaPrincipal main = new PantallaPrincipal(labelNombreUsuario.Text);
                main.Show();

                this.Hide();
            }
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timerFadeIn.Start();

        }
    }
}

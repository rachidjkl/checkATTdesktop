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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
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
            progressBar1.Value += 1;

            if (progressBar1.Value == 100)
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
                this.Close();
            }
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timerFadeIn.Start();

        }
    }
}

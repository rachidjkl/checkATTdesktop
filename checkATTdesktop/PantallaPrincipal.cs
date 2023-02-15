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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            timer1.Interval = 1000;
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;


            labelMuestraFecha.Text = now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            labelMuestraHora.Text = now.ToString("HH:mm:ss");
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

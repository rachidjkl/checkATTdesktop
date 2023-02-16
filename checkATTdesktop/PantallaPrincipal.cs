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
            labelMuestraFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            labelMuestraHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelMuestraFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            labelMuestraHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //Color panel izquierda
            panelColorAlumnos.BackColor = this.BackColor;
            panelColorClases.BackColor = this.BackColor;
            panelColorHome.BackColor = Color.Lime;
            panelColorModulos.BackColor = this.BackColor;
            panelColorProfes.BackColor = this.BackColor;

            
        }

        private void buttonGestionAlumnos_Click(object sender, EventArgs e)
        {
            //Color panel izquierda
            panelColorAlumnos.BackColor = Color.Lime;
            panelColorClases.BackColor = this.BackColor;
            panelColorHome.BackColor = this.BackColor;
            panelColorModulos.BackColor = this.BackColor;
            panelColorProfes.BackColor = this.BackColor;

        }

        private void buttonGestionProfes_Click(object sender, EventArgs e)
        {
            //Color panel izquierda
            panelColorAlumnos.BackColor = this.BackColor;
            panelColorClases.BackColor = this.BackColor;
            panelColorHome.BackColor = this.BackColor;
            panelColorModulos.BackColor = this.BackColor;
            panelColorProfes.BackColor = Color.Lime;

        }

        private void buttonGestionClases_Click(object sender, EventArgs e)
        {
            //Color panel izquierda
            panelColorAlumnos.BackColor = this.BackColor;
            panelColorClases.BackColor = Color.Lime;
            panelColorHome.BackColor = this.BackColor;
            panelColorModulos.BackColor = this.BackColor;
            panelColorProfes.BackColor = this.BackColor;

        }

        private void buttonGestionModulos_Click(object sender, EventArgs e)
        {
            //Color panel izquierda
            panelColorAlumnos.BackColor = this.BackColor;
            panelColorClases.BackColor = this.BackColor;
            panelColorHome.BackColor = this.BackColor;
            panelColorModulos.BackColor = Color.Lime;
            panelColorProfes.BackColor = this.BackColor;          

        }
    }
}

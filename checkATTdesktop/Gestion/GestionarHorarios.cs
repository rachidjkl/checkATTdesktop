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

namespace checkATTdesktop.Gestion
{
    public partial class GestionarHorarios : Form
    {
        public GestionarHorarios()
        {
            InitializeComponent();
        }

        private void buttonCrearHorario_Click(object sender, EventArgs e)
        {
            ModiAddHorario addHorario = new ModiAddHorario();
            addHorario.ShowDialog();
        }

        private void buttonModiHorario_Click(object sender, EventArgs e)
        {
            ModiAddHorario modiHorario = new ModiAddHorario();
            modiHorario.ShowDialog();
        }
    }
}

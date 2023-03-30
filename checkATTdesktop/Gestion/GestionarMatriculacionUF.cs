using checkATTdesktop.Models;
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
    public partial class GestionarMatriculacionUF : Form
    {
        public GestionarMatriculacionUF()
        {
            InitializeComponent();
        }

        private void iconPictureBoxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionarMatriculacionUF_Load(object sender, EventArgs e)
        {
            bindingSourceComboBoxModulos.DataSource = ModulosOrm.Select();
            cargarUFs();
        }


        private void comboBoxModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarUFs();
        }


        public void cargarUFs()
        {
            Modulo _modulo = (Modulo)comboBoxModulos.SelectedItem;
            if (_modulo != null)
            {
                bindingSourceDataGridUF.DataSource = _modulo.UF.ToList();
            }

        }
    }
}
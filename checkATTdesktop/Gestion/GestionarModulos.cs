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

namespace checkATTdesktop.Gestion
{
    public partial class GestionarModulos : Form
    {
        private Form currentChildForm;
        public GestionarModulos()
        {
            InitializeComponent();
        }      

        private void buttonCrearModulo_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModiAddModulos());
        }


        private void buttonModiModulo_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModiAddModulos());
        }

        private void abrirFormularioHijo(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCrearModulo.Controls.Add(childForm);
            panelCrearModulo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void GestionarModulos_Load(object sender, EventArgs e)
        {
            bindingSourceDataGridModulos.DataSource = ModulosOrm.SelectAll();
        }
    }
}

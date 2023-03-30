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

namespace checkATTdesktop.ModiAdd
{
    public partial class ModiAddModulos : Form
    {
        public static List<UF> uFs = new List<UF>();    
        public static UF ufCreate = null;

        public ModiAddModulos()
        {
            InitializeComponent();
        }



        private void buttonEditarUF_Click(object sender, EventArgs e)
        {
            UF uf = (UF)dataGridViewUFModulo.CurrentRow.DataBoundItem;
            uf.nombre_uf = textBoxNumeroUF.Text + "-" + textBox1NombreUF.Text;
            uf.horas_totales_uf = int.Parse(textBoxHorasTotales.Text);
            loadDataGrid();

        }

        private void buttonCrearUF_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (textBox1NombreUF.Text == "" || textBoxHorasTotales.Text == "" || textBoxNumeroUF.Text == "")
            {
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UF ufToAdd = new UF();
                ufToAdd.nombre_uf = textBoxNumeroUF.Text + "-" + textBox1NombreUF.Text;
                ufToAdd.horas_totales_uf = int.Parse(textBoxHorasTotales.Text);
                uFs.Add(ufToAdd);
                loadDataGrid();

            }
        }

        private void buttonCrearModulo_Click(object sender, EventArgs e)
        {
            if (textBoxNombreModulo.Text == "")
            {
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModiAddModulos_Load(object sender, EventArgs e)
        {
            bindingSourceClases.DataSource = ClaseOrm.Select();
            if (ufCreate != null)
            {
                uFs.Add(ufCreate);
                dataGridViewUFModulo.DataSource = null;
                dataGridViewUFModulo.DataSource = uFs;
                ufCreate = null;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBoxBorrar_Click(object sender, EventArgs e)
        {

        }

        private void loadDataGrid()
        {
            dataGridViewUFModulo.DataSource = null;
            dataGridViewUFModulo.DataSource = uFs;            
        }

        private void buttonEliminarUf_Click(object sender, EventArgs e)
        {
            UF uf = (UF)dataGridViewUFModulo.CurrentRow.DataBoundItem;
            uFs.Remove(uf); // Eliminar el objeto de la lista vinculada al DataGridView.
            loadDataGrid(); // Actualizar el DataGridView.
        }



        private void dataGridViewUFModulo_SelectionChanged(object sender, EventArgs e)
        {
            UF uf = (UF)dataGridViewUFModulo.CurrentRow.DataBoundItem;
            string[] partes = uf.nombre_uf.Split('-');

            textBox1NombreUF.Text = partes[1];
            textBoxNumeroUF.Text = partes[0];
            textBoxHorasTotales.Text = uf.horas_totales_uf.ToString();
        }
    }
}

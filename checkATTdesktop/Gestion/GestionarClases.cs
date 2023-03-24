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
    public partial class GestionarClases : Form
    {
        public GestionarClases()
        {
            InitializeComponent();
        }

        private void buttonCrearClase_Click(object sender, EventArgs e)
        {
            ModiAddClase addClass = new ModiAddClase();
            addClass.ShowDialog();
        }

        private void buttonModiClase_Click(object sender, EventArgs e)
        {
            ModiAddClase modiClass = new ModiAddClase();
            modiClass.ShowDialog();
        }

        private void GestionarClases_Load(object sender, EventArgs e)
        {
            bindingSourceDataGridClase.DataSource = ClaseOrm.Select();
        }

        private void dataGridViewClase_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Clase clase = (Clase)dataGridViewClase.Rows[e.RowIndex].DataBoundItem;
                e.Value = clase.Profesor.nombre_profe + " " + clase.Profesor.apellido1_profe + " " + clase.Profesor.apellido2_profe;
            }
        }
    }
}

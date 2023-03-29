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
            ModiAddHorario modiHorario = new ModiAddHorario((Horario)dataGridViewHorarios.CurrentRow.DataBoundItem);
            modiHorario.ShowDialog();
            
        }

        private void GestionarHorarios_Load(object sender, EventArgs e)
        {
            comboBoxDiaSemana.SelectedIndex = 1;
            bindingSourceComboBoxClase.DataSource = ClaseOrm.Select();
            cargarHorarios();
        }
       
        private void comboBoxSeleccionarClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarHorarios();
        }

        private void comboBoxDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarHorarios();
        }

        private void cargarHorarios()
        {
            Clase _clase = (Clase)comboBoxSeleccionarClase.SelectedItem;
            if (_clase != null)
            {
                bindingSourceDataGridHorario.DataSource = HorariosOrm.Select(_clase.id_clase, comboBoxDiaSemana.SelectedItem.ToString());
               
            }

        }

        private void dataGridViewHorarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Horario horario = (Horario)dataGridViewHorarios.Rows[e.RowIndex].DataBoundItem;
                e.Value = horario.Modulo.nombre_modulo;
            }
            else if (e.ColumnIndex == 3) 
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    TimeSpan tiempo = (TimeSpan)e.Value;
                    e.Value = tiempo.ToString("hh\\:mm"); 
                    e.FormattingApplied = true;
                }
            }else if (e.ColumnIndex == 4)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    TimeSpan tiempo = (TimeSpan)e.Value;
                    e.Value = tiempo.ToString("hh\\:mm"); 
                    e.FormattingApplied = true;
                }
            }
        }

    }
}

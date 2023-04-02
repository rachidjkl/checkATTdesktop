using checkATTdesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
            CalcularTotalHoras();

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
                CalcularTotalHoras();
            }

        }

        private void buttonCrearModulo_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (textBoxNombreModulo.Text == "")
            {
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //añadir modulo
                Modulo modulo = new Modulo();
                modulo.nombre_modulo = textBoxNombreModulo.Text;
                modulo.horas_totales_modulo = int.Parse(labelHorasTotalesModulos.Text);
                modulo.siglas_uf = textBoxSiglasModulo.Text;
                missatge += ModulosOrm.Insert(modulo);

                //añadir uf
                int idModulo = ModulosOrm.SelectModuloId(modulo.nombre_modulo, modulo.horas_totales_modulo);
                foreach (UF uf in uFs)
                {
                    uf.id_modulo_uf = idModulo;
                    missatge += UFsOrm.Insert(uf);
                }

                //añadir_clase modulo
                Clase_Modulo clase_Modulo = new Clase_Modulo();
                foreach (Clase clase in bindingSourceClases)
                {
                    clase_Modulo.id_clase1 = clase.id_clase;
                    clase_Modulo.id_modulo = idModulo;
                    missatge += ClaseModuloOrm.Insert(clase_Modulo);
                }

                showMessage(missatge);

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


        private void loadDataGrid()
        {
            dataGridViewUFModulo.DataSource = null;
            dataGridViewUFModulo.DataSource = uFs;            
        }

        private void buttonEliminarUf_Click(object sender, EventArgs e)
        {
            UF uf = (UF)dataGridViewUFModulo.CurrentRow.DataBoundItem;
            uFs.Remove(uf); // Eliminar el objeto de la lista vinculada al DataGridView.
            loadDataGrid(); // Actualizar el DataGridView.ç
            CalcularTotalHoras();
        }
        private void CalcularTotalHoras()
        {
            int total = 0;  
            foreach (UF uf in uFs)
            {
                total += uf.horas_totales_uf;
            }

            labelHorasTotalesModulos.Text = total.ToString();   

        }


        private void dataGridViewUFModulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUFModulo.SelectedRows.Count > 0)
            {
                UF uf = (UF)dataGridViewUFModulo.CurrentRow.DataBoundItem;
                string[] partes = uf.nombre_uf.Split('-');

                textBox1NombreUF.Text = partes[1];
                textBoxNumeroUF.Text = partes[0];
                textBoxHorasTotales.Text = uf.horas_totales_uf.ToString();
            }
        }


        private void iconPictureBoxAñadir_Click(object sender, EventArgs e)
        {
            if (comboBoxClases.SelectedItem != null)
            {
                bindingSourceListBoxClase.Add(comboBoxClases.SelectedItem);
            }
        }

        private void iconPictureBoxBorrar_Click(object sender, EventArgs e)
        {
            if (listBoxClases.SelectedItem != null)
            {
                bindingSourceListBoxClase.Remove(listBoxClases.SelectedItem);
            }
        }
        public void showMessage(String missatge)
        {
            if (missatge != "")
            {
                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ufCreate == null)
                {
                    MessageBox.Show("Modulo y ufs añadido correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    // vaciarCampos();
                }
                else
                {
                    MessageBox.Show("Modulo y ufs modificados correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }



    }
}

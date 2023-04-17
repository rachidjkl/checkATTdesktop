using checkATTdesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace checkATTdesktop.ModiAdd
{
    public partial class ModiAddModulos : Form
    {
        public Modulo modulo = null;
        public static List<UF> uFs = new List<UF>();
        public static List<UF> uFsAux = new List<UF>();
        public static List<Clase_Modulo> clase_Modulos = new List<Clase_Modulo>();
        public static List<Clase> clases = new List<Clase>();

        public ModiAddModulos()
        {
            InitializeComponent();
        }

        public ModiAddModulos(Modulo modulo)
        {
            InitializeComponent();
            this.modulo = modulo;
            buttonCrearModulo.Text = "Modificar";
        }

        private void buttonEditarUF_Click(object sender, EventArgs e)
        {
            UF uf = (UF)dataGridViewUFModulo.CurrentRow.DataBoundItem;
            uf.nombre_uf = textBoxNumeroUF.Text + "-" + textBox1NombreUF.Text;
            uf.horas_totales_uf = int.Parse(textBoxHorasTotales.Text);
            loadDataGrid();
            CalcularTotalHoras();
            dataGridViewUFModulo.ClearSelection();
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
                dataGridViewUFModulo.ClearSelection();
            }
        }

        private void buttonCrearModulo_Click(object sender, EventArgs e)
        {
            String missatge = "";
            int? idModulo = null;

            if (textBoxNombreModulo.Text == "")
            {
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //añadir modulo
                Modulo newModulo = new Modulo();
                newModulo.nombre_modulo = textBoxNombreModulo.Text;
                newModulo.horas_totales_modulo = int.Parse(labelHorasTotalesModulos.Text);
                newModulo.siglas_uf = textBoxSiglasModulo.Text;
                if (modulo != null)
                {
                    newModulo.id_modulo = modulo.id_modulo;
                    ModulosOrm.Update(newModulo);
                    idModulo = ModulosOrm.SelectModuloId(modulo.nombre_modulo, modulo.horas_totales_modulo);
                }
                else
                {
                    missatge += ModulosOrm.Insert(newModulo);
                    idModulo = ModulosOrm.SelectModuloId(newModulo.nombre_modulo, newModulo.horas_totales_modulo);
                }


                //añadir uf
                foreach (UF uf in uFs)
                {

                    uf.id_modulo_uf = idModulo;

                    if (modulo != null)
                    {
                        UF ufToCkeck = UFsOrm.SelectUf(modulo.id_modulo, uf.nombre_uf);
                        if (ufToCkeck == null)
                        {
                            missatge += UFsOrm.Insert(uf);
                        }
                        else
                        {
                            missatge += UFsOrm.Update(uf);
                        }
                    }
                    else
                    {
                        missatge += UFsOrm.Insert(uf);
                    }

                }
                foreach (UF uf in uFsAux)
                {
                    if (!uFs.Contains(uf))
                    {
                        missatge += UFsOrm.Delete(modulo.id_modulo, uf.nombre_uf);
                    }
                }




                //añadir_clase modulo
                Clase_Modulo clase_Modulo = new Clase_Modulo();
                foreach (Clase clase in bindingSourceListBoxClase)
                {
                    clase_Modulo.id_clase1 = clase.id_clase;
                    clase_Modulo.id_modulo = idModulo;

                    if (modulo != null)
                    {
                        Clase_Modulo claseModuloToCheck = ClaseModuloOrm.SelectClaseModulo(modulo.id_modulo, clase_Modulo.id_clase1.GetValueOrDefault());
                        if (claseModuloToCheck == null)
                        {
                            missatge += ClaseModuloOrm.Insert(clase_Modulo);
                        }
                        else
                        {
                            clase_Modulo.id_clase_modulo = claseModuloToCheck.id_clase_modulo;
                            missatge += ClaseModuloOrm.Update(clase_Modulo);
                        }


                    }
                    else
                    {
                        missatge += ClaseModuloOrm.Insert(clase_Modulo);
                    }

                }

                foreach (Clase clase in clases)
                {
                    if (!bindingSourceListBoxClase.Contains(clase))
                    {
                        missatge += ClaseModuloOrm.Delete(clase.id_clase, modulo.id_modulo);
                    }

                }

                showMessage(missatge);

            }
        }

        private void ModiAddModulos_Load(object sender, EventArgs e)
        {
            uFs.Clear();
            uFsAux.Clear();
            clase_Modulos.Clear();
            clases.Clear();
            bindingSourceClases.DataSource = ClaseOrm.Select();
            if (modulo != null)
            {
                uFs = UFsOrm.Select(modulo.id_modulo);
                uFsAux = new List<UF>(uFs);
                loadDataGrid();

                clase_Modulos = ClaseModuloOrm.Select(modulo.id_modulo);
                foreach (Clase_Modulo claseModulo in clase_Modulos)
                {
                    Clase claseToAdd = ClaseOrm.SelectOneClase(claseModulo.id_clase1.GetValueOrDefault());
                    bindingSourceListBoxClase.Add(claseToAdd);
                    clases.Add(claseToAdd);
                }

                textBoxNombreModulo.Text = modulo.nombre_modulo;
                textBoxSiglasModulo.Text = modulo.siglas_uf;
                labelHorasTotalesModulos.Text = modulo.horas_totales_modulo.ToString();
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
            dataGridViewUFModulo.ClearSelection();
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
                if (!bindingSourceListBoxClase.Contains(comboBoxClases.SelectedItem))
                {
                    bindingSourceListBoxClase.Add(comboBoxClases.SelectedItem);
                }

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
                if (modulo == null)
                {
                    MessageBox.Show("Modulo y ufs añadido correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Modulo y ufs modificados correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                uFs.Clear();
                uFsAux.Clear();
                clase_Modulos.Clear();
                clases.Clear();
                this.Close();
            }
        }



    }
}
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
    public partial class ModiAddUF : Form
    {

        //variable global donde guardaremos el nickname del usuario que estamos modificando
        //si estamos crando un usuario este campo estará vacio
        private UF uf = null;
        public ModiAddUF()
        {
            InitializeComponent();
        }

        public ModiAddUF(UF uf)
        {
            InitializeComponent();
            this.uf = uf;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void buttonCrearModiAddUF_Click(object sender, EventArgs e)
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

                if (uf != null)
                {
                    ufToAdd.id_uf = uf.id_uf;
                    missatge = UFsOrm.Update(ufToAdd);
                }
                else
                {
                    ModiAddModulos.ufCreate = ufToAdd;  
                    this.Close();
                    //missatge = UFsOrm.Insert(ufToAdd);
                }
            }
        }

        private void ModiAddUF_Load(object sender, EventArgs e)
        {
            if (uf != null)
            {
            string[] partes = uf.nombre_uf.Split('-');

            textBox1NombreUF.Text = partes[1];
            textBoxNumeroUF.Text = partes[0];
            textBoxHorasTotales.Text = uf.horas_totales_uf.ToString();
        }
        }
            
    }
}


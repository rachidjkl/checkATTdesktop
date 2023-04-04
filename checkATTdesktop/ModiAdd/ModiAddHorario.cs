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
    public partial class ModiAddHorario : Form
    {
        //variable global donde guardaremos el nickname del usuario que estamos modificando
        //si estamos crando un usuario este campo estará vacio
        private Horario horario = null;

        public ModiAddHorario()
        {
            InitializeComponent();
        }

        public ModiAddHorario(Horario horario)
        {
            InitializeComponent();
            this.horario = horario;     
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCrearModiAddHorario_Click(object sender, EventArgs e)
        {
            String missatge = "";
            if (comboBoxClase.SelectedIndex == -1 || comboBoxDiaSemana.SelectedIndex == -1 || comboBoxModulo.SelectedIndex == -1)
            {
                MessageBox.Show("Alguno de los campos estan vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Horario horarioToAdd = new Horario();
                horarioToAdd.hora_inicio = dateTimePickerHoraInicio.Value.TimeOfDay;
                horarioToAdd.hora_fin = dateTimePickerHoraFin.Value.TimeOfDay;
                horarioToAdd.id_clase = (int)comboBoxClase.SelectedValue;
                horarioToAdd.id_modulo = (int)comboBoxModulo.SelectedValue;
                horarioToAdd.dia_semana_horario = comboBoxDiaSemana.SelectedItem.ToString();

                if (horario != null)
                {
                    horarioToAdd.id_horario = horario.id_horario;
                    missatge = HorariosOrm.Update(horarioToAdd);
                }
                else
                {
                    missatge = HorariosOrm.Insert(horarioToAdd);
                }

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (horario == null)
                    {
                        MessageBox.Show("Horario añadido correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vaciarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Horario modificado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
            }
        }

        private void ModiAddHorario_Load(object sender, EventArgs e)
        {
            moduloBindingSource.DataSource = ModulosOrm.SelectAll();
            claseBindingSource.DataSource = ClaseOrm.Select();

            if (horario != null)
            {
                dateTimePickerHoraInicio.Value = DateTime.Today + horario.hora_inicio;
                dateTimePickerHoraFin.Value = DateTime.Today + horario.hora_fin;
                comboBoxClase.SelectedValue = horario.id_clase;
                comboBoxModulo.SelectedValue = horario.id_modulo;
                comboBoxDiaSemana.SelectedItem = horario.dia_semana_horario;
            }
        }

        private void vaciarCampos()
        {
            DateTime def = new DateTime(2023, 03, 28, 00, 0, 0);

            dateTimePickerHoraInicio.Value = def;
            dateTimePickerHoraFin.Value = def;

        }
    }
}



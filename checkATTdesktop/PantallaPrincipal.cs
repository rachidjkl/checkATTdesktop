using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace checkATTdesktop
{
    public partial class PantallaPrincipal : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        
        public PantallaPrincipal()
        {
            InitializeComponent();
            timer1.Interval = 1000;   
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelConTodoMenusIzquierda.Controls.Add(leftBorderBtn);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelMuestraFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            labelMuestraHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelMuestraFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            labelMuestraHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void iconButtonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            optionSelected(sender, Color.White);
            currentChildForm.Close();
            Reset();
        }

        private void iconButtonManageStudent_Click(object sender, EventArgs e)
        {
            optionSelected(sender, Color.White);
            abrirFormularioHijo(new GestionarAlumnos());
        }

        private void iconButtonManageTeacher_Click(object sender, EventArgs e)
        {
            optionSelected(sender, Color.White);
        }

        private void iconButtonManageClass_Click(object sender, EventArgs e)
        {
            optionSelected(sender, Color.White);
        }

        private void iconButtonManageModuls_Click(object sender, EventArgs e)
        {
            optionSelected(sender, Color.White);
        }

        private void iconButtonManageHorario_Click(object sender, EventArgs e)
        {
            optionSelected(sender, Color.White);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentChildForm.Close(); 
            Reset();
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
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }




        //Metodo para resetar botones
        private void Reset()
        {          
            optionUnselected();
            leftBorderBtn.Visible = false;
            iconPictureBoxOpcionSeleccionada.IconChar = IconChar.Home;
            iconPictureBoxOpcionSeleccionada.IconColor = Color.White;
            labelPantallaSeleccionada.Text = "Home"; 
        }

        //Metodo para resaltar opción seleccionada
        private void optionSelected(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                optionUnselected();
                currentBtn = (IconButton)senderBtn;
                //CON ESTO SE CAMBIA EL COLOR DE FONDO DEL BOTON SELECCIONADO
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                //CON ESTO SE CAMBIA EL COLOR DEL TEXTO DEL BOTON SELECCIONADO
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icono de la pantalla seleccionada
                iconPictureBoxOpcionSeleccionada.IconChar = currentBtn.IconChar;
                iconPictureBoxOpcionSeleccionada.IconColor = color;

                labelPantallaSeleccionada.Text = currentBtn.Text;   

            }
        }
        //Metodo para desactivar resaltado del boton
        private void optionUnselected()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(49, 103, 229);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Mover el panel por el panel superior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

using FontAwesome.Sharp;
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

namespace Sistema_De_Casillero
{
    public partial class Dashboard : Form
    {
        //campos
        private IconButton btnActual;
        private Panel btnBordeIzquierdo;
        private Form formSecundarioActual;

        public Dashboard()
        {
            InitializeComponent();
            btnBordeIzquierdo = new Panel();
            btnBordeIzquierdo.Size = new Size(7, 60);
            panelMenu.Controls.Add(btnBordeIzquierdo);

            //Formulario
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private struct ColoresRGB
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void BtnActivo(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                BtnInactivo();
                btnActual = (IconButton)senderBtn;
                btnActual.BackColor = Color.FromArgb(37, 36, 81);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;

                //Borde izquierdo
                btnBordeIzquierdo.BackColor = color;
                btnBordeIzquierdo.Location = new Point(0, btnActual.Location.Y);
                btnBordeIzquierdo.Visible = true;
                btnBordeIzquierdo.BringToFront();

                //Icono actual formulario
                iconActualFormulario.IconChar = btnActual.IconChar;
                iconActualFormulario.IconColor = color;
            }
        }

        private void BtnInactivo()
        {
            if (btnActual != null)
            {
                btnActual.BackColor = Color.FromArgb(31, 30, 68);
                btnActual.ForeColor = Color.White;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.White;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void AbrirFormularioSecundario(Form formSecundario)
        {
            if (formSecundarioActual != null)
            {
                //para abrir solo un formulario
                formSecundarioActual.Close();
            }
            formSecundarioActual = formSecundario;
            formSecundario.TopLevel = false;
            formSecundario.FormBorderStyle = FormBorderStyle.None;
            formSecundario.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formSecundario);
            panelEscritorio.Tag = formSecundario;
            formSecundario.BringToFront();
            formSecundario.Show();

        }

        //BOTONES
        private void btnPaquetes_Click_1(object sender, EventArgs e)
        {
            lblTituloFormulario.Text = "Paquetes";
            BtnActivo(sender, ColoresRGB.color1);
            AbrirFormularioSecundario(new frmPaquetes());
        }

        private void btnCategorias_Click_1(object sender, EventArgs e)
        {
            lblTituloFormulario.Text = "Categoría";
            BtnActivo(sender, ColoresRGB.color2);
            AbrirFormularioSecundario(new frmCategorias());
        }

        private void BtnPaquete_Click(object sender, EventArgs e)
        {
            lblTituloFormulario.Text = "Estantes";
            BtnActivo(sender, ColoresRGB.color3);
            AbrirFormularioSecundario(new frmEstantes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblTituloFormulario.Text = "Usuarios";
            BtnActivo(sender, ColoresRGB.color4);
            AbrirFormularioSecundario(new frmUsuarios());
        }

        private void logoInicio_Click(object sender, EventArgs e)
        {
            formSecundarioActual.Close();
            Reiniciar();
        }

        private void Reiniciar()
        {
            BtnInactivo();
            btnBordeIzquierdo.Visible = false;
            iconActualFormulario.IconChar = IconChar.Home;
            iconActualFormulario.IconColor = Color.White;
            lblTituloFormulario.Text = "Inicio";
        }

        
        //*arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}

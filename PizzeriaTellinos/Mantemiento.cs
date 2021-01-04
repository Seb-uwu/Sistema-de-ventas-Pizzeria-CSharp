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

namespace PizzeriaTellinos
{
    public partial class Mantemiento : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Mantemiento()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro de Salir?", "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MenuTop2_MouseClick(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);
        }
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnPizzas_Click(object sender, EventArgs e)
        {
            Pizzas pizza = new Pizzas();
            pizza.Show();
            Close();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            Bebidas bebida = new Bebidas();
            bebida.Show();
            Close();
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Show();
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Show();
            Close();
        }
    }
}

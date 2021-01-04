using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace PizzeriaTellinos
{
    public partial class Reportes : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Reportes()
        {
            InitializeComponent();
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


        private void MenuTop_MouseMove(object sender, MouseEventArgs e)
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

        
        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            reporte_de_clientes reporte = new reporte_de_clientes();
            reporte.Show();
            this.Hide();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Menu frmmenú = new Menu();
            frmmenú.Show();
            this.Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Mantemiento mantenimiento = new Mantemiento();
            mantenimiento.Show();
            this.Hide();

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}

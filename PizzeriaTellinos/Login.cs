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
using PizzeriaTellinos.Properties;
using System.Data;
using System.Data.SqlClient;


namespace PizzeriaTellinos
{

    public partial class Login : Form
    {
        int cont = 0;
        Conexion con = new Conexion();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();
            txtusuario.MaxLength = 15;
            txtcontraseña.MaxLength = 15;
        }


        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro de Salir?", "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MenuTop_MouseMove(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Contraseña;
            Usuario = txtusuario.Text;
            Contraseña = txtcontraseña.Text;


            if (Usuario == "administrador" && Contraseña == "123")
            {
                //llamada al formulario numero 2
                MessageBox.Show("Bienvenido al Sistema", "Aviso del Sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);

                //Ver Reportes de Clientes y Pedidos
                Reportes reportes = new Reportes();
                reportes.Show();
                this.Hide();

            }
            else if (Usuario == "empleado" && Contraseña == "123")
            {
                //llamada al formulario numero 2
                MessageBox.Show("Bienvenido al Sistema", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Ver Reportes de Clientes y Pedidos
                Menu_empleado empleado = new Menu_empleado();
                empleado.Show();
                this.Hide();

            }
            else
            {
                txtusuario.Clear();
                txtcontraseña.Clear();
                cont++;
                if (cont == 1)
                    MessageBox.Show("Te Quedan 3 Oportunidades", "Aviso", MessageBoxButtons.OK);
                if (cont == 2)
                    MessageBox.Show("Te Quedan 2 Oportunidades", "Aviso", MessageBoxButtons.OK);
                if (cont == 3)
                    MessageBox.Show("Te Queda 1 Oportunidad", "Aviso", MessageBoxButtons.OK);
            }
            if (cont == 4)
            {
                MessageBox.Show("Has Superado el Limite de Intentos, Gracias por su Comprensión", "Aviso del Sistema", MessageBoxButtons.OK);
                Close();
            }
        }

        private void chkmostrarcontraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmostrarcontraseña.Checked == true)
            {
                txtcontraseña.UseSystemPasswordChar = false;
                this.chkmostrarcontraseña.Image = Resources.OjoAbierto;
            }
            else
            {
                txtcontraseña.UseSystemPasswordChar = true;
                this.chkmostrarcontraseña.Image = Resources.OjoCerrado;
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }
        
    }
}

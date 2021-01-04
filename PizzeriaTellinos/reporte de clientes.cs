using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace PizzeriaTellinos
{
    public partial class reporte_de_clientes : Form
    {
        //Barra de Tareas
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();

        //clase para leer el txt//
        leer l = new leer();
        string url = "D://clientes.txt";
        DateTime hoy = DateTime.Now;
        string fecha, hora;
        string nclientes;
        string importetotal;
        public reporte_de_clientes()
        {
            InitializeComponent();
          
        }

        private void salida_registro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }

        private void limpia_registros_Click(object sender, EventArgs e)
        {
            nclientes = numerototalform.Text;
            importetotal = importetotalform.Text;
            fecha = hoy.ToShortDateString();
            hora = hoy.ToShortTimeString();
            if (File.Exists("D:/registro_diario.txt"))
            {

                StreamWriter Archivos = File.AppendText("D://registro_diario.txt");
                Archivos.Write("Fecha de registro:  " + fecha);
                Archivos.Write(" Numero de clientes: " + numerototalform);
                Archivos.WriteLine(" Importe total del día: " + importetotalform);
                Archivos.Close();

            }
            else
            {
                StreamWriter Archivos = new StreamWriter("D:/registro_diario.txt");
                Archivos.Write("Fecha de registro:  " + fecha);
                Archivos.Write(" Numero de clientes: " + nclientes);
                Archivos.WriteLine(" Importe total del día: " + importetotal);
                Archivos.Close();
            }

            //limpiamos todo los dgv los label e incluso nuestro archivo plano//
            tabla_reporte_clientes.Rows.Clear();
            importetotalform.Text = "";
            numerototalform.Text = "";
            File.Delete(url);   
        }

        private void calculototal_Click(object sender, EventArgs e)
        {
            int importetotal = 0;
            foreach (DataGridViewRow row in tabla_reporte_clientes.Rows)
            {
                importetotal += Convert.ToInt16(row.Cells["iMPORTE1"].Value);
            }
            importetotalform.Text = Convert.ToString("S/." + importetotal);
            //el txt de numero de clientes//
            numerototalform.Text = Convert.ToString(tabla_reporte_clientes.RowCount);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro de Salir?", "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void reporte_de_clientes_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aun falta");
        }

    }
}

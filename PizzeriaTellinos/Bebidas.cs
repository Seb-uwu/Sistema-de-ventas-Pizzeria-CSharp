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

    public partial class Bebidas : Form
    {
        int Id;
        //string editar;
        Conexion con = new Conexion();
        


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Bebidas()
        {
            InitializeComponent();
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

        private void Atras_Click(object sender, EventArgs e)
        {
            Mantemiento frmmante = new Mantemiento();
            frmmante.Show();
            this.Hide();
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

       

        private void limpiar()
        {
            this.txtcodigo_bebidas.Clear();
            this.txtBebidas.Clear();
            this.txtPrecioBebidas.Clear();
            this.cboTamañoBebidas.SelectedIndex = -1;
            this.txtCantidad.Clear();                                                                                
            this.cboEstado.SelectedIndex = -1;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            con.Conectar();

            String consulta = "insert into Bebidas (Cod_Bebidas,Nombre_Bebidas,Precio_Bebidas,Cantidad,Tamaño_Bebidas,Estado) values ('" + txtcodigo_bebidas.Text + "','" 
                + txtBebidas.Text 
                + "','" + txtPrecioBebidas.Text
                + "','" + txtCantidad.Text 
                + "','" + cboTamañoBebidas.Text 
                + "'," + cboEstado.Text + ");";

            con.EjecutarSql(consulta);

            con.Desconectar();
            this.actualizargrid();
            limpiar();
        }
        public void actualizargrid()
        {
            con.ActualizarGrid1(this.dgvBebidas, "Select * from Bebidas");
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar_tabla();
        }
        private void editar_tabla()
        {
            Id = int.Parse(this.dgvBebidas.CurrentRow.Cells[0].Value.ToString());
            txtcodigo_bebidas.Text = dgvBebidas.CurrentRow.Cells[1].Value.ToString();
            txtBebidas.Text = dgvBebidas.CurrentRow.Cells[2].Value.ToString();
            txtPrecioBebidas.Text = dgvBebidas.CurrentRow.Cells[3].Value.ToString();
            txtCantidad.Text = dgvBebidas.CurrentRow.Cells[4].Value.ToString();
            cboTamañoBebidas.Text = dgvBebidas.CurrentRow.Cells[5].Value.ToString();
            cboEstado.Text = dgvBebidas.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Id = int.Parse(this.dgvBebidas.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("Desea Eliminar el Regitro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from Bebidas where Id_Bebidas='" + Id + "';";
                con.EjecutarSql(consulta);
                this.actualizargrid();
                con.Desconectar();
            }
            else
            {
                return;
            }
            limpiar();
        }
        private void Bebidas_Load(object sender, EventArgs e)
        {
            //editar = true;
            con.ActualizarGrid1(this.dgvBebidas, "Select * from Bebidas");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "NUEVO")
            {
                btnNuevo.Text = "CANCELAR";
                groupBox1.Enabled = true;
                btnAñadir.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                txtNomUsuario.Enabled = true;
                dgvBebidas.Enabled = true;
            }
            else
            {
                btnNuevo.Text = "NUEVO";

                groupBox1.Enabled = false;
                btnAñadir.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = false;
                txtNomUsuario.Enabled = false;
                dgvBebidas.Enabled = false;
                limpiar();

            }
        }

        private void dgvBebidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(this.dgvBebidas.CurrentRow.Cells[0].Value.ToString());
            txtcodigo_bebidas.Text = dgvBebidas.CurrentRow.Cells[1].Value.ToString();
            txtBebidas.Text = dgvBebidas.CurrentRow.Cells[2].Value.ToString();
            txtPrecioBebidas.Text = dgvBebidas.CurrentRow.Cells[3].Value.ToString();
            txtCantidad.Text = dgvBebidas.CurrentRow.Cells[4].Value.ToString();
            cboTamañoBebidas.Text = dgvBebidas.CurrentRow.Cells[5].Value.ToString();
            cboEstado.Text = dgvBebidas.CurrentRow.Cells[6].Value.ToString();
        }
    }
}

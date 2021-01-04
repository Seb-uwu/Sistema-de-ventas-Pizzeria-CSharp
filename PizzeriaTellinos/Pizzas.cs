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
    public partial class Pizzas : Form
    {
        int Id;
        Boolean editar;

        Conexion con = new Conexion();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Pizzas()
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


        private void txtPrecioPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
           else if (e.KeyChar == '\b') //permite borrar// 
               e.Handled = false;
           else
               e.Handled = true;
        }

        private void txtPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '\b') //permite borrar// 
                e.Handled = false;
           else
                e.Handled = true;
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Mantemiento frmmante = new Mantemiento();
            frmmante.Show();
            this.Hide();
        }

        private void Pizzas_Load(object sender, EventArgs e)
        {
            cboTamañoPizza.Items.Add("FAMILIAR");
            cboTamañoPizza.Items.Add("MEDIANA");
            cboTamañoPizza.Items.Add("PERSONAL");
            con.ActualizarGrid(this.dgvPizzas, "Select * from Pizzas");
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            con.Conectar();

            String consulta = "insert into Pizzas (Cod_Pizza,Nombre_Pizza,Precio_Pizza,Tamaño_Pizza,Cantidad,Estado) values ('" + txtcodigo_pizza.Text +
                "','" + txtPizza.Text + 
                "','" + txtPrecioPizza.Text + 
                "','" + cboTamañoPizza.Text +
                "','" + txtCantidad.Text + 
                "'," + cboEstado.Text + ");";

            con.EjecutarSql(consulta);

            con.Desconectar();
            this.actualizargrid();
            limpiar();

        }
        private void limpiar()
        {
            this.txtcodigo_pizza.Clear();
            this.txtPrecioPizza.Clear();
            this.txtPizza.Clear();
            this.txtCantidad.Clear();
            this.cboTamañoPizza.SelectedIndex = -1;
            this.cboEstado.SelectedIndex = -1;

        }
        public void actualizargrid()
        {
            con.ActualizarGrid3(this.dgvPizzas, "Select * from Pizzas");
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
                txtNomUsuario.Enabled = false;
                dgvPizzas.Enabled = true;
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
                dgvPizzas.Enabled = false;
                limpiar();

            }
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Id = int.Parse(this.dgvPizzas.CurrentRow.Cells[0].Value.ToString());
            txtcodigo_pizza.Text = dgvPizzas.CurrentRow.Cells[1].Value.ToString();
            txtPizza.Text = dgvPizzas.CurrentRow.Cells[2].Value.ToString();
            txtPrecioPizza.Text = dgvPizzas.CurrentRow.Cells[3].Value.ToString();
            cboTamañoPizza.Text = dgvPizzas.CurrentRow.Cells[4].Value.ToString();
            txtCantidad.Text = dgvPizzas.CurrentRow.Cells[5].Value.ToString();
            cboEstado.Text = dgvPizzas.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Id = int.Parse(this.dgvPizzas.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("Desea Eliminar el Regitro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from Pizzas where Id_Pizza='" + Id + "';";
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvPizzas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(this.dgvPizzas.CurrentRow.Cells[0].Value.ToString());
            txtcodigo_pizza.Text = dgvPizzas.CurrentRow.Cells[1].Value.ToString();
            txtPizza.Text = dgvPizzas.CurrentRow.Cells[2].Value.ToString();
            txtPrecioPizza.Text = dgvPizzas.CurrentRow.Cells[3].Value.ToString();
            cboTamañoPizza.Text = dgvPizzas.CurrentRow.Cells[4].Value.ToString();
            txtCantidad.Text = dgvPizzas.CurrentRow.Cells[5].Value.ToString();
            cboEstado.Text = dgvPizzas.CurrentRow.Cells[6].Value.ToString();
        }

        private void txtPrecioPizza_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}

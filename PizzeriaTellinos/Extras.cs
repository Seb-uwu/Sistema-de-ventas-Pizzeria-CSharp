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
    public partial class Extras : Form
    {
        Boolean editar;
        int Id;
        Conexion con = new Conexion();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Extras()
        {
            InitializeComponent();
        }
       
        public void actualizargrid()
        {
            con.ActualizarGrid2(this.dgvExtras, "Select * from Extras");
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                con.Conectar();
                string consulta = "update Extras set Codigo_Extra='" + txtcodigo_extra.Text + "',Nombre_Extra='" + txtExtras.Text + "',Precio_Extra='" + txtPrecioExtras.Text +  "',Cantidad='" + txtCantidad.Text + "',Estado=" + cboEstado.Text + "where Id_Extra=" + Id + ";"; 
                con.EjecutarSql(consulta);
                this.actualizargrid();
                con.Desconectar();
                this.limpiar();
                editar = false;
            }
            else
            {
                con.Conectar();

                String consulta = "insert into Extras (Codigo_Extra,Nombre_Extra,Precio_Extra,Cantidad,Estado) values ('" + txtcodigo_extra.Text +"','" + txtExtras.Text +"','" + txtPrecioExtras.Text +"','" + txtCantidad.Text +"'," + cboEstado.Text + ");";
                con.EjecutarSql(consulta);
                con.Desconectar();
                this.actualizargrid();
                limpiar();
            }

        }
        private void limpiar()
        {
            this.txtcodigo_extra.Clear();
            this.txtExtras.Clear();
            this.txtPrecioExtras.Clear();
            this.txtCantidad.Clear();
            this.cboEstado.SelectedIndex = -1;
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '\b') //permite borrar// 
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtPrecioExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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

        private void dgvExtras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Id = int.Parse(this.dgvExtras.CurrentRow.Cells[0].Value.ToString());
            txtcodigo_extra.Text = dgvExtras.CurrentRow.Cells[1].Value.ToString();
            txtExtras.Text = dgvExtras.CurrentRow.Cells[2].Value.ToString();
            txtPrecioExtras.Text = dgvExtras.CurrentRow.Cells[3].Value.ToString();
            txtCantidad.Text = dgvExtras.CurrentRow.Cells[4].Value.ToString();
            cboEstado.Text = dgvExtras.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Id = int.Parse(this.dgvExtras.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("Desea eliminar el regitro??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from Extras where Id_Extras='" + Id + "';";
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

        private void Extras_Load(object sender, EventArgs e)
        {
            con.ActualizarGrid2(this.dgvExtras, "Select * from Extras");
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
                txtNomUsuario.Enabled = false;
                dgvExtras.Enabled = true;
            }
            else
            {
                btnNuevo.Text = "NUEVO";
                groupBox1.Enabled = false;
                btnAñadir.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                txtNomUsuario.Enabled = false;
                dgvExtras.Enabled = false;
                limpiar();

            }
        }

        private void dgvExtras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(this.dgvExtras.CurrentRow.Cells[0].Value.ToString());
            txtcodigo_extra.Text = dgvExtras.CurrentRow.Cells[1].Value.ToString();
            txtExtras.Text = dgvExtras.CurrentRow.Cells[2].Value.ToString();
            txtPrecioExtras.Text = dgvExtras.CurrentRow.Cells[3].Value.ToString();
            txtCantidad.Text = dgvExtras.CurrentRow.Cells[4].Value.ToString();
            cboEstado.Text = dgvExtras.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '\b') //permite borrar// 
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtNomUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            //No Permite Numeros
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }  
        }
    }
}

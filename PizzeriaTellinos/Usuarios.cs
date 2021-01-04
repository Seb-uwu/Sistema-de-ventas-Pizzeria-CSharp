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
    public partial class Usuarios : Form
    {
        Boolean editar;
        int Id;
        Conexion con = new Conexion();

        //Barra de Tareas
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Usuarios()
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            con.ActualizarGrid(this.dgvUsuarios, "Select * from Usuario");
            editar = true;
            btnagregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            groupBox1.Enabled = false;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.ActualizarGrid(this.dgvUsuarios, "select * from Usuario where Usuario='" + txtBuscar.Text+"%");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           Id = int.Parse(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("Desea Eliminar el Regitro?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from Usuario where Id_Usuario='" + Id + "';";
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar = true;
            Id =int.Parse(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtDniRuc.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtNombres.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtApellidos.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtCorreo.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            txtContacto.Text = dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
            cboTipo.Text = dgvUsuarios.CurrentRow.Cells[8].Value.ToString();
            cboEstado.Text = dgvUsuarios.CurrentRow.Cells[9].Value.ToString();         
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "NUEVO")
            {
                btnNuevo.Text = "CANCELAR";
                groupBox1.Enabled = true;
                btnagregar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                txtBuscar.Enabled = true;
                dgvUsuarios.Enabled = true;
            }
            else
            {
                btnNuevo.Text = "NUEVO";
                groupBox1.Enabled = false;
                btnagregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                txtBuscar.Enabled = false;
                dgvUsuarios.Enabled = false;
                limpiar();

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                con.Conectar();
                string consulta = "update Usuario set Usuario='" + txtUsuario.Text + "',Contraseña='"+ txtContraseña.Text + "',Dni_Ruc='" + txtDniRuc.Text + "',Nombres='" + txtNombres.Text + "',Apellidos='" + txtApellidos.Text+ "',Correo='" + txtCorreo.Text + "',Contacto='" + txtContacto.Text + "',Tipo_Usuario='" + cboTipo.Text + "',Estado=" + cboEstado.Text + "where Id_Usuario=" + Id + ";";

                con.EjecutarSql(consulta);
                this.actualizargrid();
                con.Desconectar();
                this.limpiar();
                editar = false;
            }
            else
            {
                con.Conectar();
                String consulta = "insert into Usuario (Usuario,Contraseña,Dni_Ruc,Nombres,Apellidos,Correo,Contacto,Tipo_Usuario,Estado) values ('" + txtUsuario.Text + "','" + txtContraseña.Text + "','" + txtDniRuc.Text + "','" + txtNombres.Text + "','" + txtApellidos.Text + "','" + txtCorreo.Text + "','" + txtContacto.Text + "','" + cboTipo.Text + "'," + cboEstado.Text + ");";

                con.EjecutarSql(consulta);

                con.Desconectar();
                this.actualizargrid();
                limpiar(); 
            }
            
        }
        public void actualizargrid()
        {
            con.ActualizarGrid(this.dgvUsuarios, "Select * from Usuario");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        public void limpiar()
        {
            txtUsuario.Text = "";
            txtBuscar.Text = "";
            txtNombres.Text = "";
            txtDniRuc.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtContacto.Text = "";
            txtApellidos.Text = "";
            cboTipo.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtDniRuc.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtNombres.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtApellidos.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtCorreo.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            txtContacto.Text = dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
            cboTipo.Text = dgvUsuarios.CurrentRow.Cells[8].Value.ToString();
            cboEstado.Text = dgvUsuarios.CurrentRow.Cells[9].Value.ToString();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            con.ActualizarGrid(this.dgvUsuarios, "Select * from Usuario where Usuario like '"+txtBuscar.Text+"%';");
        }

        private void txtDniRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '\b') //permite borrar// 
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '\b') //permite borrar// 
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}

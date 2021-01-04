using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzeriaTellinos
{
    public partial class Empleado : Form
    {
        DateTime hoy = DateTime.Now;
        int Id_venta;
        int Id;
        Boolean editar;
        Conexion con = new Conexion();
        public Empleado()
        {
            con.Conectar();
            InitializeComponent();
            comboBox1.Items.Add("PIZZAS");
            comboBox1.Items.Add("EXTRAS");
            comboBox1.Items.Add("BEBIDAS");
            dgvPizzas.Visible = false;
            dgvExtras.Visible = false;
            dgvBebidas.Visible = false;
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dgvPizzas.Visible = true;
                lblmensaje.Visible = false;
                dgvExtras.Visible = false;
                dgvBebidas.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dgvExtras.Visible = true;
                lblmensaje.Visible = false;
                dgvBebidas.Visible = false;
                dgvPizzas.Visible = false;
            }
            else
            {
                dgvBebidas.Visible = true;
                lblmensaje.Visible = false;
                dgvExtras.Visible = false;
                dgvPizzas.Visible = false;
            }
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            con.ActualizarGrid3(this.dgvPizzas, "Select * from Pizzas");
            con.ActualizarGrid2(this.dgvExtras, "Select * from Extras");
            con.ActualizarGrid1(this.dgvBebidas, "Select * from Bebidas");
            Id_venta = 1;
            txtnumero.Text = Convert.ToString(Id_venta);
            txtfecha.Text = hoy.ToShortDateString();
        }

        private void dgvExtras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTNOMBRE.Text = dgvExtras.CurrentRow.Cells[2].Value.ToString();
            TXTPRECIO.Text = dgvExtras.CurrentRow.Cells[3].Value.ToString();
            TXTTAMAÑO.Text = dgvExtras.CurrentRow.Cells[5].Value.ToString();
            
        }
     
      

        private void dgvBebidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTNOMBRE.Text = dgvBebidas.CurrentRow.Cells[2].Value.ToString();
            TXTPRECIO.Text = dgvBebidas.CurrentRow.Cells[3].Value.ToString();
            TXTTAMAÑO.Text = dgvBebidas.CurrentRow.Cells[5].Value.ToString();

        }

        private void dgvPizzas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTNOMBRE.Text = dgvPizzas.CurrentRow.Cells[2].Value.ToString();
            TXTPRECIO.Text = dgvPizzas.CurrentRow.Cells[3].Value.ToString();
            TXTTAMAÑO.Text = dgvPizzas.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (editar)
            {
                con.Conectar();
                string consulta = "update Detalle_Ventas set cod_id='" + txtnumero.Text + "',producto='" + TXTNOMBRE.Text + "',Precio_unitario'" + TXTPRECIO.Text + "',cantidad='" + TXTCANTIDAD.Text + "',Precio_total="+ txttotal+"where cod_dVenta=" + Id + ";";

                con.EjecutarSql(consulta);
               
                con.Desconectar();
                this.limpiar();
                editar = false;
            }
            else
            {
                con.Conectar();
                String consulta = "insert into Detalle_Ventas (cod_id,producto,Precio_unitario,cantidad,Precio_total) values ('" + txtnumero.Text + "','" + TXTNOMBRE.Text + "','" + TXTPRECIO.Text + "','" + TXTCANTIDAD.Text + "'," + txttotal.Text + ");";

                con.EjecutarSql(consulta);

                con.Desconectar();
                
                limpiar();
            }
        }

        private void TXTCANTIDAD_TextChanged(object sender, EventArgs e)
        {
            int can;
            decimal pre_uni;
            decimal total;
            can = Convert.ToInt16(TXTCANTIDAD.Text);
            pre_uni = Convert.ToDecimal(TXTPRECIO.Text);
            total = pre_uni * can;
            txttotal.Text = Convert.ToString(total);
        }
        private void limpiar()
        {
            TXTNOMBRE.Clear();
            TXTPRECIO.Clear();
            txttotal.Clear();
            TXTCANTIDAD.Clear();
            TXTTAMAÑO.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Id = int.Parse(this.dgvde_ventas.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("Desea Eliminar el Regitro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from Detalle_Ventas where cod_dVenta='" + Id + "';";
                con.EjecutarSql(consulta);
              
                con.Desconectar();
            }
            else
            {
                return;
            }
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar = true;
            Id = int.Parse(this.dgvde_ventas.CurrentRow.Cells[0].Value.ToString());
            TXTNOMBRE.Text = dgvde_ventas.CurrentRow.Cells[2].Value.ToString();
            TXTPRECIO.Text = dgvde_ventas.CurrentRow.Cells[3].Value.ToString();
            TXTCANTIDAD.Text = dgvde_ventas.CurrentRow.Cells[4].Value.ToString();
            txttotal.Text = dgvde_ventas.CurrentRow.Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu_empleado emp = new Menu_empleado();
            emp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            comboBox1.SelectedIndex = -1;
            dgvde_ventas.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Conectar();
            String consulta = "insert into Ventas (Nombre_Cliente,Importe,Fecha) values ('" + txtcliente.Text + "','" + txttotal_ventas.Text + "'," + txtfecha.Text + ");";

            con.EjecutarSql(consulta);

            con.Desconectar();

            limpiar();
        }
        //arreglar esto//
        private void txttotal_ventas_TextChanged(object sender, EventArgs e)
        {
            int pagar;
            foreach (DataGridViewRow row in dgvde_ventas.Rows)
            {
                pagar += Convert.ToInt16(row.Cells[6].Value);
            }
            txttotal_ventas.Text = Convert.ToString("S/." + pagar);
        }
    }
}

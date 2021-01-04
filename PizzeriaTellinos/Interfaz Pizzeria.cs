using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
namespace PizzeriaTellinos
{
    public partial class ProgramaPizzeria : Form
    {
        //Ventana Minimizar-Maximizar-Cerrar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        //Variables
        //variables para cargar el dgv y panel datos ......
        string Cliente, Metodo, Pedido;
        int Total;
        int ncantidad;
        int Precio;
        int PrecioC;
        DateTime hoy = DateTime.Now;
        int npedido=1;
        int totalpagar=0;

        //variables para cargar del dgv al txt .......
        string Pedido1;
        string Preciounidad1;
        string PrecioTotal1;

        public ProgramaPizzeria()
        {
            InitializeComponent();
            btnNuevo.Enabled = true;
            btnConfirmar.Enabled = false;
            btnQuitarPedido.Enabled = false;
            rbEfectivo.Enabled = false;
            rbTarjeta.Enabled = false;
            btccp.Enabled = false;
        }

        private void ProgramaPizzeria_Load_1(object sender, EventArgs e)
        {
         
            //ComboBox Pizza
            cboPizza.Items.Add("Pizza Americana");
            cboPizza.Items.Add("Pizza Barbacoa");
            cboPizza.Items.Add("Pizza Hawaiana");
            cboPizza.Items.Add("Pizza de Borde de Queso");
            cboPizza.Items.Add("Pizza Vegetariana");
            cboPizza.Items.Add("Pizza de Pepperoni");
            //cboPizza.Sorted = true;

            //ComboBox Bebidas
            cboBebidas.Items.Add("Gaseosa Inca kola");
            cboBebidas.Items.Add("Gaseosa Pepsi");
            cboBebidas.Items.Add("Gaseosa Coca Cola");
            cboBebidas.Items.Add("Gaseosa Sprite");
            cboBebidas.Items.Add("Limonada");
            cboBebidas.Items.Add("Chicha Morada");
            cboBebidas.Items.Add("Café");
            cboBebidas.Items.Add("Ninguno");
            //cboBebidas.Sorted = true;


            //ComboBox Extras
            cboExtras.Items.Add("Nachos");
            cboExtras.Items.Add("Lasaña");
            cboExtras.Items.Add("Pan al Ajo");
            cboExtras.Items.Add("Tequeños");
            cboExtras.Items.Add("Calzone");
            cboExtras.Items.Add("Papas fritas");
            cboExtras.Items.Add("Ninguno");
            //cboExtras.Sorted = true;

            //Combox Tamaño pizza
            cboTamañoPizza.Items.Add("Personal");
            cboTamañoPizza.Items.Add("Mediana");
            cboTamañoPizza.Items.Add("Familiar");

            //Combox Tamaño bebida
            cboTamañoBebidas.Items.Add("500 ML");
            cboTamañoBebidas.Items.Add("1.5 LT");
            cboTamañoCafe.Items.Add("Taza");

        }

        private void cboPizza_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            //COMBOBOX PIZZAS AL SELECCIONAR//
            if (cboPizza.SelectedIndex == 0)
            {
                PizzaHawaiana.Visible = false;
                PizzaBarbacoa.Visible = false;
                PizzaBordeQueso.Visible = false;
                PizzaPepperoni.Visible = false;
                PizzaVegetariana.Visible = false;

                lblMensajePizza.Visible = true;
                lblMensajePizza.Text = "Pizza Americana";
                PizzaAmericana.Visible = true;
                txtCantidadPizza.Text = "1";
                
            }

            if (cboPizza.SelectedIndex == 1)
            {
                PizzaAmericana.Visible = false;
                PizzaBordeQueso.Visible = false;
                PizzaHawaiana.Visible = false;
                PizzaPepperoni.Visible = false;
                PizzaVegetariana.Visible = false;

                lblMensajePizza.Visible = true;
                lblMensajePizza.Text = "Pizza Barbacoa";
                PizzaBarbacoa.Visible = true;
                txtCantidadPizza.Text = "1";
            }

            if (cboPizza.SelectedIndex == 2)
            {
                PizzaAmericana.Visible = false;
                PizzaBarbacoa.Visible = false;
                PizzaBordeQueso.Visible = false;
                PizzaPepperoni.Visible = false;
                PizzaVegetariana.Visible = false;

                lblMensajePizza.Visible = true;
                lblMensajePizza.Text = "Pizza Hawaiana";
                PizzaHawaiana.Visible = true;
                txtCantidadPizza.Text = "1";
            }

            if (cboPizza.SelectedIndex == 3)
            {
                PizzaAmericana.Visible = false;
                PizzaBarbacoa.Visible = false;
                PizzaHawaiana.Visible = false;
                PizzaPepperoni.Visible = false;
                PizzaVegetariana.Visible = false;

                lblMensajePizza.Visible = true;
                lblMensajePizza.Text = "Pizza de Queso";
                PizzaBordeQueso.Visible = true;
                txtCantidadPizza.Text = "1";
            }

            if (cboPizza.SelectedIndex == 4)
            {
                PizzaAmericana.Visible = false;
                PizzaHawaiana.Visible = false;
                PizzaBordeQueso.Visible = false;
                PizzaBarbacoa.Visible = false;
                PizzaPepperoni.Visible = false;

                lblMensajePizza.Visible = true;
                lblMensajePizza.Text = "Pizza Vegetariana";
                PizzaVegetariana.Visible = true;
                txtCantidadPizza.Text = "1";
            }

            if (cboPizza.SelectedIndex == 5)
            {
                PizzaAmericana.Visible = false;
                PizzaHawaiana.Visible = false;
                PizzaBordeQueso.Visible = false;
                PizzaBarbacoa.Visible = false;
                PizzaVegetariana.Visible = false;

                lblMensajePizza.Visible = true;
                lblMensajePizza.Text = "Pizza Pepperoni";
                PizzaPepperoni.Visible = true;
                txtCantidadPizza.Text = "1";
            }
        }

        private void cboBebidas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //COMBOBOX BEBIDAS AL SELECCIONAR//
            if (cboBebidas.SelectedIndex == 0)
            {
                cboTamañoBebidas.Enabled = true;
                GaseosaPepsi.Visible = false;
                GaseosaCocaCola.Visible = false;
                GaseosaSprite.Visible = false;
                Limonada.Visible = false;
                ChichaMorada.Visible = false;
                Cafe.Visible = false;
                cboTamañoCafe.Enabled = false;
                cboTamañoCafe.Visible = false;
                cboTamañoBebidas.Enabled = true;
                cboTamañoBebidas.Visible = true;

                lblMensajeBebidas.Visible = true;
                lblMensajeBebidas.Text = "Gaseosa Inca Kola";
                GaseosaInkaKola.Visible = true;
                //HABILITAR CANTIDAD//
                txtCantidadBebidas.Enabled = true;
                btnAgregarBebidas.Enabled = true;
                txtCantidadBebidas.Text = "1";
            }

            if (cboBebidas.SelectedIndex == 1)
            {
                cboTamañoBebidas.Enabled = true;
                GaseosaInkaKola.Visible = false;
                GaseosaCocaCola.Visible = false;
                GaseosaSprite.Visible = false;
                Limonada.Visible = false;
                ChichaMorada.Visible = false;
                Cafe.Visible = false;
                cboTamañoCafe.Enabled = false;
                cboTamañoCafe.Visible = false;
                cboTamañoBebidas.Enabled = true;
                cboTamañoBebidas.Visible = true;

                lblMensajeBebidas.Visible = true;
                lblMensajeBebidas.Text = "Gaseosa Pepsi";
                GaseosaPepsi.Visible = true;
                //HABILITAR CANTIDAD//
                txtCantidadBebidas.Enabled = true;
                btnAgregarBebidas.Enabled = true;
                txtCantidadBebidas.Text = "1";
            }

            if (cboBebidas.SelectedIndex == 2)
            {
                cboTamañoBebidas.Enabled = true;
                GaseosaPepsi.Visible = false;
                GaseosaInkaKola.Visible = false;
                GaseosaSprite.Visible = false;
                Limonada.Visible = false;
                ChichaMorada.Visible = false;
                Cafe.Visible = false;
                cboTamañoCafe.Enabled = false;
                cboTamañoCafe.Visible = false;
                cboTamañoBebidas.Enabled = true;
                cboTamañoBebidas.Visible = true;

                lblMensajeBebidas.Visible = true;
                lblMensajeBebidas.Text = "Gaseosa Coca Cola";
                GaseosaCocaCola.Visible = true;
                //HABILITAR CANTIDAD//
                txtCantidadBebidas.Enabled = true;
                btnAgregarBebidas.Enabled = true;
                txtCantidadBebidas.Text = "1";
            }

            if (cboBebidas.SelectedIndex == 3)
            {
                cboTamañoBebidas.Enabled = true;
                GaseosaPepsi.Visible = false;
                GaseosaCocaCola.Visible = false;
                GaseosaInkaKola.Visible = false;
                Limonada.Visible = false;
                ChichaMorada.Visible = false;
                Cafe.Visible = false;
                cboTamañoCafe.Enabled = false;
                cboTamañoCafe.Visible = false;
                cboTamañoBebidas.Enabled = true;
                cboTamañoBebidas.Visible = true;

                lblMensajeBebidas.Visible = true;
                lblMensajeBebidas.Text = "Gaseosa Sprite";
                GaseosaSprite.Visible = true;
                //HABILITAR CANTIDAD//
                txtCantidadBebidas.Enabled = true;
                btnAgregarBebidas.Enabled = true;
                txtCantidadBebidas.Text = "1";
            }

            if (cboBebidas.SelectedIndex == 4)
            {
                cboTamañoBebidas.Enabled = true;
                GaseosaPepsi.Visible = false;
                GaseosaCocaCola.Visible = false;
                GaseosaSprite.Visible = false;
                GaseosaInkaKola.Visible = false;
                ChichaMorada.Visible = false;
                Cafe.Visible = false;
                cboTamañoCafe.Enabled = false;
                cboTamañoCafe.Visible = false;
                cboTamañoBebidas.Enabled = true;
                cboTamañoBebidas.Visible = true;

                lblMensajeBebidas.Visible = true;
                lblMensajeBebidas.Text = "Limonada";
                Limonada.Visible = true;
                //HABILITAR CANTIDAD//
                txtCantidadBebidas.Enabled = true;
                btnAgregarBebidas.Enabled = true;
                txtCantidadBebidas.Text = "1";
            }

            if (cboBebidas.SelectedIndex == 5)
            {
                cboTamañoBebidas.Enabled = true;
                GaseosaPepsi.Visible = false;
                GaseosaCocaCola.Visible = false;
                GaseosaSprite.Visible = false;
                Limonada.Visible = false;
                GaseosaInkaKola.Visible = false;
                Cafe.Visible = false;
                cboTamañoCafe.Enabled = false;
                cboTamañoCafe.Visible = false;
                cboTamañoBebidas.Enabled = true;
                cboTamañoBebidas.Visible = true;

                lblMensajeBebidas.Visible = true;
                lblMensajeBebidas.Text = "Chicha Morada";
                ChichaMorada.Visible = true;
                //HABILITAR CANTIDAD//
                txtCantidadBebidas.Enabled = true;
                btnAgregarBebidas.Enabled = true;
                txtCantidadBebidas.Text = "1";
            }

            if (cboBebidas.SelectedIndex == 6)
            {
                GaseosaPepsi.Visible = false;
                GaseosaCocaCola.Visible = false;
                GaseosaSprite.Visible = false;
                Limonada.Visible = false;
                ChichaMorada.Visible = false;
                GaseosaInkaKola.Visible = false;

                cboTamañoBebidas.Enabled = false;
                cboTamañoBebidas.Visible = false;
                cboTamañoCafe.Enabled = true;
                cboTamañoCafe.Visible = true;
                lblMensajeBebidas.Text = "Café";
                cboTamañoBebidas.Enabled = false;
                //cboTamañoBebidas.SelectedIndex = -1;
                lblTamBebida.Visible = false;
                Cafe.Visible = true;
                //HABILITAR CANTIDAD//
                txtCantidadBebidas.Enabled = true;
                btnAgregarBebidas.Enabled = true;
                txtCantidadBebidas.Text = "1";
            }
            if (cboBebidas.SelectedIndex == 7)
            {
                GaseosaPepsi.Visible = false;
                GaseosaCocaCola.Visible = false;
                GaseosaSprite.Visible = false;
                Limonada.Visible = false;
                ChichaMorada.Visible = false;
                GaseosaInkaKola.Visible = false;
                lblTamBebida.Visible = false;
                Cafe.Visible = false;
                //Mensaje
                lblMensajeBebidas.Visible = false;  

                //Desabilitar         
                cboTamañoBebidas.Enabled = false;
                cboTamañoBebidas.SelectedIndex = -1;
                txtCantidadBebidas.Text = "";
                txtCantidadBebidas.Enabled = false;
                btnAgregarBebidas.Enabled = false;


            }
        }

        private void cboExtras_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //COMBOBOX EXTRAS AL SELECCIONAR//
            if (cboExtras.SelectedIndex == 0)
            {
                Lasaña.Visible = false;
                PanalAjo.Visible = false;
                Tequeños.Visible = false;
                Calzone.Visible = false;
                PapasFritas.Visible = false;

                lblExtra.Text = "Nachos";
                lblExtra.Visible = true;
                Nachos.Visible = true;
                lble.Text = "S/ 5";

                //HABILITAR CANTIDAD//
                txtCantidadExtras.Enabled = true;
                btnAgregarExtras.Enabled = true;
                txtCantidadExtras.Text = "1";
            }

            if (cboExtras.SelectedIndex == 1)
            {
                Nachos.Visible = false;
                PanalAjo.Visible = false;
                Tequeños.Visible = false;
                Calzone.Visible = false;
                PapasFritas.Visible = false;

                lblExtra.Visible = true;
                lblExtra.Text = "Lasaña";
                Lasaña.Visible = true;
                lble.Text = "S/ 5";

                //HABILITAR CANTIDAD//
                txtCantidadExtras.Enabled = true;
                btnAgregarExtras.Enabled = true;
                txtCantidadExtras.Text = "1";
            }

            if (cboExtras.SelectedIndex == 2)
            {
                Lasaña.Visible = false;
                Nachos.Visible = false;
                Tequeños.Visible = false;
                Calzone.Visible = false;
                PapasFritas.Visible = false;

                lblExtra.Visible = true;
                lblExtra.Text = "Pan al Ajo";
                PanalAjo.Visible = true;
                lble.Text = "S/ 6";

                //HABILITAR CANTIDAD//
                txtCantidadExtras.Enabled = true;
                btnAgregarExtras.Enabled = true;
                txtCantidadExtras.Text = "1";
            }

            if (cboExtras.SelectedIndex == 3)
            {
                Lasaña.Visible = false;
                PanalAjo.Visible = false;
                Nachos.Visible = false;
                Calzone.Visible = false;
                PapasFritas.Visible = false;

                lblExtra.Visible = true;
                lblExtra.Text = "Tequeños";
                Tequeños.Visible = true;
                lble.Text = "S/ 6";

                //HABILITAR CANTIDAD//
                txtCantidadExtras.Enabled = true;
                btnAgregarExtras.Enabled = true;
                txtCantidadExtras.Text = "1";
            }

            if (cboExtras.SelectedIndex == 4)
            {
                Lasaña.Visible = false;
                PanalAjo.Visible = false;
                Tequeños.Visible = false;
                Nachos.Visible = false;
                PapasFritas.Visible = false;

                lblExtra.Visible = true;
                lblExtra.Text = "Calzone";
                Calzone.Visible = true;
                lble.Text = "S/ 7";

                //HABILITAR CANTIDAD//
                txtCantidadExtras.Enabled = true;
                btnAgregarExtras.Enabled = true;
                txtCantidadExtras.Text = "1";
            }

            if (cboExtras.SelectedIndex == 5)
            {
                Lasaña.Visible = false;
                PanalAjo.Visible = false;
                Tequeños.Visible = false;
                Calzone.Visible = false;
                Nachos.Visible = false;

                lblExtra.Visible = true;            
                lblExtra.Text = "Papas Fritas";
                PapasFritas.Visible = true;
                lble.Text = "S/ 7";
                txtCantidadExtras.Text = "1";
            }
            if (cboExtras.SelectedIndex == 6)
            {
                Lasaña.Visible = false;
                PanalAjo.Visible = false;
                Tequeños.Visible = false;
                Calzone.Visible = false;
                Nachos.Visible = false;
                PapasFritas.Visible = false;
                lble.Text = "";
                lblExtra.Visible = false; 
                //DESHABILITAR CANTIDAD//
                txtCantidadExtras.Text = "";
                txtCantidadExtras.Enabled = false;
                btnAgregarExtras.Enabled = false;
            }
        }

        private void cboTamañoPizza_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //COMBOBOX TAMAÑO PIZZA//
            switch (cboTamañoPizza.SelectedIndex)
            {
                case 0:
                    lblTamPizza.Text = "Personal";
                    lblTamPizza.Visible = true;
                    lblp.Text = "S/ 13";
                    break;
                case 1:
                    lblTamPizza.Text = "Mediana";
                    lblTamPizza.Visible = true;
                    lblp.Text = "S/ 27";
                    break;
                case 2:
                    lblTamPizza.Text = "Familiar";
                    lblTamPizza.Visible = true;
                    lblp.Text = "S/ 50";
                    break;
            }
        }

        private void cboTamañoBebidas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboBebidas.SelectedIndex == 6)
            {
                cboTamañoBebidas.Enabled = false;
            }
            //COMBOBOX TAMAÑO BEBIDAS//
            else
            {
                switch (cboTamañoBebidas.SelectedIndex)
                {
                    case 0:
                        cboTamañoBebidas.Enabled = true;
                        lblTamBebida.Text = "500 ml";
                        lblTamBebida.Visible = true;
                        lblb.Text = "S/ 2";
                        break;
                    case 1:
                        cboTamañoBebidas.Enabled = true;
                        lblTamBebida.Text = "1.5 LT";
                        lblTamBebida.Visible = true;
                        lblb.Text = "S/ 5";
                        break;
                }
            }
        }

        public static void Drag_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            TablaPizza.ClearSelection();
            if (btnNuevo.Text == "Nuevo Pedido")
            {
                
                txtCliente.Enabled = true;
                btnNuevo.Text = "Cancelar Pedido";
                PanelDatos.Enabled = true;
                panel1.Enabled = false;
                btnAgregarPizza.Enabled = true;
                btnAgregarExtras.Enabled = true;
                btnAgregarBebidas.Enabled = true;
                btccp.Enabled = false;
            }
            else
            {
                PanelDatos.Enabled = false;
                btnNuevo.Text = "Nuevo Pedido";
                rbEfectivo.Checked = false;
                rbTarjeta.Checked = false;
                TablaPizza.Rows.Clear();
                limpiar();
                lblp.Text = "";
                lblb.Text = "";
                lble.Text = "";
                
                txtNomCliente.Clear();
                txtMetodoPago.Clear();
                txtTotalPagar.Clear();
            }
        }
        public void limpiar()
        {
            //datos cliente//
            txtNomCliente.Clear();
            txtMetodoPago.Clear();
            txtTotalPagar.Clear();
            //pizza
            txtCliente.Clear();
            cboPizza.SelectedIndex = -1;
            cboTamañoPizza.SelectedIndex = -1;

            txtCantidadPizza.Text = "";

            lblMensajePizza.Visible = false;
            lblTamPizza.Visible = false;
            PizzaAmericana.Visible = false;
            PizzaBarbacoa.Visible = false;
            PizzaBordeQueso.Visible = false;
            PizzaHawaiana.Visible = false;
            PizzaPepperoni.Visible = false;
            PizzaVegetariana.Visible = false;

            //bebidas
            cboBebidas.SelectedIndex = -1;
            cboBebidas.SelectedIndex = -1;

            txtCantidadBebidas.Text = "";

            lblMensajeBebidas.Visible = false;
            lblTamBebida.Visible = false;
            ChichaMorada.Visible = false;
            Limonada.Visible = false;
            GaseosaCocaCola.Visible = false;
            GaseosaInkaKola.Visible = false;
            GaseosaPepsi.Visible = false;
            GaseosaSprite.Visible = false;
            Cafe.Visible = false;

            //extras
            cboExtras.SelectedIndex = -1;

            txtCantidadExtras.Text = "";

            lblExtra.Visible = false;
            Lasaña.Visible = false;
            PanalAjo.Visible = false;
            Tequeños.Visible = false;
            Nachos.Visible = false;
            Calzone.Visible = false;
            PapasFritas.Visible = false;
        }

        private void btnAgregarPizza_Click_1(object sender, EventArgs e)
        {

            txtNomCliente.Enabled = true;
            TablaPizza.Enabled = true;
            btnConfirmar.Enabled = true;
            btnQuitarPedido.Enabled = true;
            Cliente = txtCliente.Text;

            //debe de tener el nombre del cliente//
            if (Cliente == "")
            {
                MessageBoxButtons Boton = MessageBoxButtons.OK;
                MessageBoxIcon Icono = MessageBoxIcon.Asterisk;
                MessageBox.Show("Debe de ingresar nombre de cliente!!!", "", Boton, Icono);
            }
            else
            {
                if (cboPizza.SelectedIndex == -1 && cboTamañoPizza.SelectedIndex == -1)
                {
                    MessageBox.Show("debe de seleccionar su pizza con su tamaño de preferencia");
                }
                else if (cboPizza.SelectedIndex == -1)
                {
                    MessageBox.Show("debe seleccionar su pizza de preferencia");
                }
                else if (cboTamañoPizza.SelectedIndex == -1)
                {
                    MessageBox.Show("debe seleccionar el tamaño de pizza que desee");
                }
                else 
                {
                    ncantidad = Convert.ToInt16(txtCantidadPizza.Text);

                    Pedido = cboPizza.SelectedItem + " / " + cboTamañoPizza.SelectedItem + " x " + ncantidad;

                    Precio = cboTamañoPizza.SelectedIndex;
                    switch (Precio)
                    {
                        case 0:
                            Precio = 13;
                            break;
                        case 1:
                            Precio = 27;
                            break;
                        case 2:
                            Precio = 50;
                            break;
                    }
                    //Precio
                    if (Precio == 50)
                    {
                        Total = 50 * ncantidad;
                    }
                    else if (Precio == 27)
                    {
                        Total = 27 * ncantidad;
                    }
                    else
                    {
                        Total = 13 * ncantidad;
                    }

                    TablaPizza.Rows.Add(Pedido, "S/. " + Precio, +Total);
                    // guardar_pedidos();
                    txtCliente.Text = Cliente;
                    txtNomCliente.Text = Cliente;
                    txtCliente.Enabled = false;
                    cboPizza.SelectedIndex = -1;
                    cboTamañoPizza.SelectedIndex = -1;
                    txtCantidadPizza.Text = "";
                    lblMensajePizza.Visible = false;
                    lblTamPizza.Visible = false;
                    PizzaAmericana.Visible = false;
                    PizzaBarbacoa.Visible = false;
                    PizzaBordeQueso.Visible = false;
                    PizzaHawaiana.Visible = false;
                    PizzaPepperoni.Visible = false;
                    PizzaVegetariana.Visible = false;
                    lblp.Text = "";
                }
            }
        }
        private void btnAgregarBebidas_Click_1(object sender, EventArgs e)
        {
            txtNomCliente.Enabled = true;
            TablaPizza.Enabled = true;
            btnConfirmar.Enabled = true;
            btnQuitarPedido.Enabled = true;
            Cliente = txtCliente.Text;

            //debe de tener el nombre del cliente//
            if (Cliente == "")
            {
                MessageBoxButtons Boton = MessageBoxButtons.OK;
                MessageBoxIcon Icono = MessageBoxIcon.Asterisk;
                MessageBox.Show("Debe de ingresar el nombre del cliente!!!", "", Boton, Icono);
            }
            else
            {
                if (cboBebidas.SelectedIndex == -1 && cboTamañoBebidas.SelectedIndex == -1 && cboTamañoCafe.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe de seleccionar su bebida con su tamaño de preferencia");
                }
                else if (cboBebidas.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar su bebida de preferencia");
                }
                else if (cboTamañoBebidas.SelectedIndex == -1 && cboTamañoCafe.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el tamaño de bebida que desee");
                }               
                else
	            {

	
                    ncantidad = Convert.ToInt16(txtCantidadBebidas.Text);
                    Pedido = cboBebidas.SelectedItem + " / " + cboTamañoBebidas.SelectedItem + " x " + ncantidad;

                    Precio = cboTamañoBebidas.SelectedIndex;
                    PrecioC = cboTamañoCafe.SelectedIndex;
                    if (cboTamañoBebidas.SelectedIndex == -1)
                    {
                        Precio = 2;
                    }
                    else
                    {
                        switch (Precio)
                        {
                            case 0:
                                Precio = 2;
                                break;
                            case 1:
                                Precio = 5;
                                break;
                        }
                    }

                    if (Precio == 2)
                    {
                        Total = 2 * ncantidad;
                    }
                    else if (Precio == 1)
                    {
                        Total = 1 * ncantidad;
                    }
                    else
                    {
                        Total = 5 * ncantidad;
                    }

                    TablaPizza.Rows.Add(Pedido, "S/. " + Precio, +Total);
                    // guardar_pedidos();
                    txtCliente.Text = Cliente;
                    txtNomCliente.Text = Cliente;
                    txtCliente.Enabled = false;
                    cboBebidas.SelectedIndex = -1;
                    cboTamañoBebidas.SelectedIndex = -1;
                    txtCantidadBebidas.Text = "";
                    lblMensajeBebidas.Visible = false;
                    lblTamBebida.Visible = false;
                    ChichaMorada.Visible = false;
                    Limonada.Visible = false;
                    GaseosaCocaCola.Visible = false;
                    GaseosaInkaKola.Visible = false;
                    GaseosaPepsi.Visible = false;
                    GaseosaSprite.Visible = false;
                    Cafe.Visible = false;
                    lblb.Text = "";
                    cboTamañoCafe.SelectedIndex = -1;
                }
            }
        }
        private void btnAgregarExtras_Click_1(object sender, EventArgs e)
        {
            TablaPizza.Enabled = true;
            btnConfirmar.Enabled = true;
            btnQuitarPedido.Enabled = true;
            txtCliente.Text = Cliente;

            //debe de tener el nombre del cliente//
            if (Cliente == "")
            {
                MessageBoxButtons Boton = MessageBoxButtons.OK;
                MessageBoxIcon Icono = MessageBoxIcon.Asterisk;
                MessageBox.Show("Debe de ingresar nombre de cliente!!!", "", Boton, Icono);
            }
            else
            {
                if (cboExtras.SelectedIndex == -1)
                {
                    MessageBox.Show("debe de seleccionar su extra de preferencia");
                }
                else
                {

                    txtNomCliente.Enabled = true;
                    ncantidad = Convert.ToInt16(txtCantidadExtras.Text);
                    Pedido = cboExtras.SelectedItem + " x " + ncantidad;

                    Precio = cboExtras.SelectedIndex;

                    switch (Precio)
                    {
                        case 0:
                            Precio = 5;
                            break;
                        case 1:
                            Precio = 5;
                            break;
                        case 2:
                            Precio = 6;
                            break;
                        case 3:
                            Precio = 6;
                            break;
                        case 4:
                            Precio = 7;
                            break;
                        case 5:
                            Precio = 7;
                            break;
                        case 6:
                            Precio = 8;
                            break;

                    }

                    if (Precio == 5)
                    {
                        Total = 5 * ncantidad;
                    }
                    else if (Precio == 5)
                    {
                        Total = 5 * ncantidad;
                    }
                    else if (Precio == 6)
                    {
                        Total = 6 * ncantidad;
                    }
                    else if (Precio == 6)
                    {
                        Total = 6 * ncantidad;
                    }
                    else if (Precio == 7)
                    {
                        Total = 7 * ncantidad;
                    }
                    else if (Precio == 7)
                    {
                        Total = 7 * ncantidad;
                    }
                    else
                    {
                        Total = 8 * ncantidad;
                    }

                    TablaPizza.Rows.Add(Pedido, "S/. " + Precio, +Total);
                    //guardar_pedidos();
                    txtCliente.Text = Cliente;
                    txtNomCliente.Text = Cliente;
                    txtCliente.Enabled = false;
                    cboExtras.SelectedIndex = -1;
                    txtCantidadExtras.Text = "";
                    lblExtra.Visible = false;
                    Lasaña.Visible = false;
                    PanalAjo.Visible = false;
                    Tequeños.Visible = false;
                    Nachos.Visible = false;
                    Calzone.Visible = false;
                    PapasFritas.Visible = false;
                    lble.Text = "";
                }
            }
        }
        private void btnQuitarPedido_Click_1(object sender, EventArgs e)
        {
            if (TablaPizza.Enabled == true)
            {
                int indice = TablaPizza.CurrentRow.Index;
                TablaPizza.Rows.RemoveAt(indice);              
            }
            else
            {
                MessageBoxButtons Boton = MessageBoxButtons.OK;
                MessageBoxIcon Icono = MessageBoxIcon.Asterisk;
                MessageBox.Show("No hay items en su pedido", "", Boton, Icono);
            } 
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {

           
            if (rbTarjeta.Checked==true || rbEfectivo.Checked==true)
            {
                
                if (rbTarjeta.Checked == true)
                {
                    Metodo = "Tarjeta";
                    txtMetodoPago.Text = Metodo;
                    foreach (DataGridViewRow row in TablaPizza.Rows)
                    {
                        totalpagar += Convert.ToInt16(row.Cells["columna1"].Value);
                    }
                    txtTotalPagar.Text = Convert.ToString("S/." +totalpagar);
                }
                else
                {
                    Metodo="Efectivo";
                    txtMetodoPago.Text = Metodo;
                    foreach (DataGridViewRow row in TablaPizza.Rows)
                    {
                        totalpagar += Convert.ToInt16(row.Cells["columna1"].Value);
                    }
                    txtTotalPagar.Text = Convert.ToString("S/." + totalpagar);
                }
                lblhoy.Text = hoy.ToShortDateString();
                lblmñn.Text = hoy.ToShortTimeString();
                string fecha;
                fecha = lblmñn.Text;
                string hora;
                hora = lblhoy.Text;
                //grabado de boleta tellinos//
                if (File.Exists("D:/BoletaTellinos.txt"))
                {

                    StreamWriter Archivos = File.AppendText("D://BoletaTellinos.txt");
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("Cliente: "+ Cliente);
                    Archivos.WriteLine("-----------------------------");
                    Archivos.WriteLine("Metodo de pago: "+Metodo);
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("Total a pagar: S/" + totalpagar);
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("Fecha/Hora: ");
                    Archivos.WriteLine( hora + "  " + fecha);
                    Archivos.Close();
                }
                else
                {
                    StreamWriter Archivos = new StreamWriter("D:/BoletaTellinos.txt");
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("Cliente: " + Cliente);
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("Metodo de pago: " + Metodo);
                    Archivos.WriteLine("----------------------------- ");
                   Archivos.WriteLine("Total a pagar: S/" + totalpagar);
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("----------------------------- ");
                    Archivos.WriteLine("Fecha/Hora: ");
                    Archivos.WriteLine(hora + "  " + fecha);
                    Archivos.Close();
                }
                //llenaremos en otro archivo nuestro registro de clientes en arc planos//
                if (File.Exists("D:/clientes.txt"))
                {

                    StreamWriter Archivos = File.AppendText("D://clientes.txt");                   
                    Archivos.Write(npedido + ",");
                    Archivos.Write(Cliente + ",");
                    Archivos.Write(Metodo + ",");
                    Archivos.Write(totalpagar + ",");
                    Archivos.WriteLine(hora);
                    Archivos.Close();

                }
                else
                {
                    StreamWriter Archivos = new StreamWriter("D:/clientes.txt");
                    Archivos.Write(npedido + ",");
                    Archivos.Write(Cliente + ",");
                    Archivos.Write(Metodo + ",");
                    Archivos.Write(totalpagar + ",");
                    Archivos.WriteLine(hora);
                    Archivos.Close();
                }
                npedido++;
                //esto es para terminar el proceso del grabado del arc plano boleta tellinos //
                btnConfirmar.Enabled = false;
                MessageBox.Show("Pedido realizado correctamente, Gracias!!!!");
                limpiar();
                TablaPizza.Rows.Clear();
                PanelDatos.Enabled = false;
                btnQuitarPedido.Enabled = false;               
                btnNuevo.Text = "Nuevo Pedido";
                lblhoy.Text = "";
                lblmñn.Text = "";
                rbEfectivo.Checked = false;
                rbTarjeta.Checked = false;
                btnNuevo.Enabled = true;
                totalpagar = 0;
                
            }
            else
            {
                if (File.Exists("D:/BoletaTellinos.txt"))
                {

                    StreamWriter Archivos = File.AppendText("D://BoletaTellinos.txt");
                    Archivos.WriteLine("-----------------------------");
                    Archivos.WriteLine("|||||||TELLINO'S PIZZA|||||||");
                    Archivos.WriteLine("-----------------------------");
                    Archivos.WriteLine("N° pedido: " + npedido);
                    Archivos.Close();
                }
                else
                {
                    StreamWriter Archivo = new StreamWriter("D:/BoletaTellinos.txt");
                    Archivo.WriteLine("-----------------------------");
                    Archivo.WriteLine("|||||||TELLINO'S PIZZA|||||||");
                    Archivo.WriteLine("-----------------------------");
                    Archivo.WriteLine("N° pedido: " + npedido);
                    Archivo.Close();
                }
               
                MessageBoxButtons Boton = MessageBoxButtons.OK;
                MessageBoxIcon Icono = MessageBoxIcon.Asterisk;
                MessageBox.Show("Para poder terminar el pedido debe elegir algun metodo de pago", "", Boton, Icono);
                MetododePago.Enabled = true;
                rbEfectivo.Enabled = true;
                rbTarjeta.Enabled = true;
                MessageBoxButtons Boton1 = MessageBoxButtons.OK;
                MessageBoxIcon Icono1 = MessageBoxIcon.Asterisk;
                MessageBox.Show("debe de presionar CONFIRMAR ITEM", "", Boton1, Icono1);
                btccp.Enabled = true;
                btnNuevo.Enabled = false;
                btnQuitarPedido.Enabled = false;
                btnAgregarBebidas.Enabled = false;
                btnAgregarExtras.Enabled = false;
                btnAgregarPizza.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }

        
        

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                e.Handled = true;
            }
            else if (char.IsSeparator(e.KeyChar))
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

        private void MenuTop_MouseMove_1(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);
        }


        private void Restaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelPedido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro de Salir?", "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TablaPizza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido1 = TablaPizza.Rows[e.RowIndex].Cells["Pedidos"].Value.ToString();
            Preciounidad1 = TablaPizza.Rows[e.RowIndex].Cells["PrecioUnidad"].Value.ToString();
            PrecioTotal1 = TablaPizza.Rows[e.RowIndex].Cells["columna1"].Value.ToString();
        }
        private void btccp_Click(object sender, EventArgs e)
        {
            if (Pedido1 == "")
            {
                MessageBoxButtons Boton = MessageBoxButtons.OK;
                MessageBoxIcon Icono = MessageBoxIcon.Asterisk;
                MessageBox.Show("Seleccione una Fila", "", Boton, Icono);
            }
            else
            {
                guardar_pedidos();
                MessageBoxButtons Boton = MessageBoxButtons.OK;
                MessageBoxIcon Icono = MessageBoxIcon.Asterisk;
                MessageBox.Show("Su Item fue Marcado", "", Boton, Icono);
            }
            btnConfirmar.Enabled = true;
        }

      

        private void Maximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }
        //envia al txt los pedidos confirmados
        public void guardar_pedidos()
        {

            if (File.Exists("D:/BoletaTellinos.txt"))
            {

                StreamWriter Archivos = File.AppendText("D://BoletaTellinos.txt");
                Archivos.WriteLine("Pedido: "+Pedido1);
                Archivos.WriteLine("Precio/unidad: " + Preciounidad1);
                
                Archivos.WriteLine("Total: S/" + PrecioTotal1);
                Archivos.WriteLine("-----------------------------");
                Archivos.Close();
            }
            else
            {
                StreamWriter Archivo = new StreamWriter("D:/BoletaTellinos.txt");
                Archivo.WriteLine("Pedido: " + Pedido1);
                Archivo.WriteLine("Precio/unidad: " + Preciounidad1);
                Archivo.WriteLine("Total: S/" + PrecioTotal1);
                Archivo.WriteLine("-----------------------------");
                Archivo.Close();
            }
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu frmmenú = new Menu();
            frmmenú.Show();            
            this.Hide();
        }

        private void TablaPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtras_MouseClick(object sender, MouseEventArgs e)
        {
            Menu frmmenú = new Menu();
            frmmenú.Show();
            this.Hide();
        }

        private void cboTamañoCafe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '\b') //permite borrar// 
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadBebidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '\b') //permite borrar// 
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCantidadExtras_KeyPress(object sender, KeyPressEventArgs e)
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

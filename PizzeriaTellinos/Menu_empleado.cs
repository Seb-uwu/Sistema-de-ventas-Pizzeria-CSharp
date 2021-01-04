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
    public partial class Menu_empleado : Form
    {
        public Menu_empleado()
        {
            InitializeComponent();
        }

        private void Menu_empleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Show();
            this.Hide();
        }

        private void btndocumento_venta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aún no hemos implementado esta parte del programa .........");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}

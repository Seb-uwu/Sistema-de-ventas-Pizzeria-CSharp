using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PizzeriaTellinos
{
    public class Conexion
    {
        SqlConnection conn;

        public void Conectar()
        {
            conn = new SqlConnection("Data Source=ROSENDO-PC;Initial Catalog=Pizzeria;Integrated Security=True");
            conn.Open();
        }

        public void Desconectar()
        {
            conn.Close();
        }
        public void EjecutarSql(String consulta)
        {
            SqlCommand con = new SqlCommand(consulta,conn);

            int FilasAfectadas = con.ExecuteNonQuery();

            if (FilasAfectadas >0)
                MessageBox.Show("Operacion Realizada Correctamente", "La Base de Datos a sido Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            else
                MessageBox.Show("No se a Conectado a la Base de Datos", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
        }
        public void ActualizarGrid(DataGridView dg, String Consulta)
        {
            this.Conectar();
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Consulta,conn);
            da.Fill(ds, "Usuario");
            dg.DataSource = ds;
            dg.DataMember = "Usuario";

            this.Desconectar();

        }
        
        public void ActualizarGrid1(DataGridView dg, String Consulta)
        {
            this.Conectar();
            System.Data.DataSet ds1 = new System.Data.DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter(Consulta, conn);
            da1.Fill(ds1, "Bebidas");
            dg.DataSource = ds1;
            dg.DataMember = "Bebidas";

            this.Desconectar();

        }
        public void ActualizarGrid2(DataGridView dg, String Consulta)
        {
            this.Conectar();
            System.Data.DataSet ds2 = new System.Data.DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter(Consulta, conn);
            da2.Fill(ds2, "Extras");
            dg.DataSource = ds2;
            dg.DataMember = "Extras";

            this.Desconectar();

        }
        public void ActualizarGrid3(DataGridView dg, String Consulta)
        {
            this.Conectar();
            System.Data.DataSet ds2 = new System.Data.DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter(Consulta, conn);
            da2.Fill(ds2, "Pizzas");
            dg.DataSource = ds2;
            dg.DataMember = "Pizzas";

            this.Desconectar();

        }

        //public void logear(string usuario, string contraseña)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("Select Usuario,Tipo_Usuario from Usuario where Usuario=@Usuario AND Contraseña=@Contraseña",conn);
        //        cmd.Parameters.AddWithValue("Usuario", usuario);
        //        cmd.Parameters.AddWithValue("Contraseña", contraseña);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);

        //        if (dt.Rows.Count ==1)
        //        {
        //            this.Hide();
        //            if (dt.Rows[0][1].ToString()=="ADMINISTRADOR")
        //            {
        //                new Administrador(dt.Rows[0][0].ToString()).Show();
                        
        //            }
        //            else if (dt.Rows[0][1].ToString() == "EMPLEADO")
        //            {
        //                new Empleado(dt.Rows[0][0].ToString()).Show();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Usuario o Contraseña Incorrectos");
        //        }
        //    }
        //    catch(Exception e){
        //        MessageBox.Show(e.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

    }
}

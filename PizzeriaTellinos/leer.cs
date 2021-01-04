using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PizzeriaTellinos
{
    class leer
    {
        //leemos el archivo
        public void lecturaArchivo(DataGridView tabla, char caracter, string ruta) {

            StreamReader objReader = new StreamReader(ruta);
            string linea = "";
            int fila = 0;
            tabla.Rows.Clear();
            tabla.AllowUserToAddRows = false;

            do
            {
                linea = objReader.ReadLine();
                if ((linea != null))
                {
                  
                        agregarFila(tabla, linea, caracter, fila);
                    
                }                
            } while (!(linea == null));
                objReader.Close();           
        }
        public static void nombrarTitulo(DataGridView tabla, string[] titulos) {
            int x = 0;
            for (x = 0; x <= tabla.ColumnCount - 1; x++)
            {
                tabla.Columns[x].HeaderText = titulos[x];
            }
        }
        public static void agregarFila(DataGridView tabla, string linea, char caracter, int fila) {
            string[] arreglo = linea.Split(caracter);
            tabla.Rows.Add(arreglo);
        }
    }
}

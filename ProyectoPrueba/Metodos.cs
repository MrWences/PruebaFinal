using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPrueba
{
     class Metodos
    {

       public SqlConnection con;


        public void Conexion()
        {
            try
            {
                con = new SqlConnection(@"Data Source=localhost,1433;user id=sa;password=zxc123456;Initial Catalog=PruebaRelacional;");
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No tienes acceso a esta base de datos");
            }
        }

        public static void soloLetas(KeyPressEventArgs i)
        {
            if (Char.IsLetter(i.KeyChar))
            {
                i.Handled = false;
            } 
            else if (Char.IsSeparator(i.KeyChar))
            {
                i.Handled = false;
            }
            else if (Char.IsControl(i.KeyChar))
            {
                i.Handled = false;
            }
            else
            {
                i.Handled = true;
            }
        }

        public static void soloNumeros(KeyPressEventArgs i)
        {
            if (Char.IsDigit(i.KeyChar))
            {
                i.Handled = false;
            }
            else if (Char.IsSeparator(i.KeyChar))
            {
                i.Handled = false;
            }
            else if (Char.IsControl(i.KeyChar))
            {
                i.Handled = false;
            }
            else
            {
                i.Handled = true;
            }
        }
    }
}

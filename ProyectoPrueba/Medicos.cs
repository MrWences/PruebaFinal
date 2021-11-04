using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoPrueba
{
    public partial class Medicos : Form
    {
        Metodos m = new Metodos();
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adap;
        DataTable dt;

        
        int ID;

        
        public Medicos()
        {
            InitializeComponent();
        }
        
        // Mostras infor en la tabla.
        public void mostrarInfo()
        {
            cmd = new SqlCommand("SELECT * FROM Medicos", m.con);
            adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;
            dt = new DataTable();
            adap.Fill(dt);
            tableMedicos.DataSource = dt;
        }

        public void formatoEmail()
        {
            
        }

        // Limpiar formulario una vez mandado los datos a la base de datos.
        public void limpiarFormulario()
        {
            txt_Nombres.Clear();
            txt_Apellidos.Clear();
            txt_Direccion.Clear();
            txt_Edad.Clear();
            rb_SexoH.Checked = false;
            rb_SexoM.Checked = false;
            txt_Telefono.Clear();
            txt_Email.Clear();
        }

        // Solo numeros en apartado telefono y edad.
        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.soloNumeros(e);
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.soloNumeros(e);
        }

        private void Medicos_Load(object sender, EventArgs e)
        {
            m.Conexion();
            mostrarInfo();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string sexo = string.Empty;
            try
            {
                if (txt_Nombres.Text.Trim() == string.Empty || txt_Apellidos.Text.Trim() == string.Empty || txt_Email.Text.Trim() == string.Empty || txt_Direccion.Text.Trim() == string.Empty || txt_Edad.Text.Trim() == string.Empty || rb_SexoH.Checked == false && rb_SexoM.Checked == false || txt_Telefono.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor llene todos los campos");
                }
                else
                {

                    if (txt_Email.Text.Contains("@"))
                    {

                        if (rb_SexoH.Checked)
                        {
                            sexo = "H";
                        }
                        else
                        {
                            sexo = "M";
                        }

                        cmd = new SqlCommand("INSERT INTO Medicos(Nombres, Apellidos, Direccion, Edad, Sexo, Telefono, Email) VALUES('" + txt_Nombres.Text + "','" + txt_Apellidos.Text + "','" + txt_Direccion.Text + "'," + txt_Edad.Text + ",'" + sexo + "'," + txt_Telefono.Text + ",'" + txt_Email.Text + "')", m.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medico agregado!");
                        mostrarInfo();
                        limpiarFormulario();

                    }
                    else
                    {
                        MessageBox.Show("Escriba correctamente su correo");
                    }


                }
            }
            catch
            {
                MessageBox.Show("El medico " + txt_Nombres.Text + " ya esta registrado");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
           try
            {
                string sexo = string.Empty;
                if (rb_SexoH.Checked)
                {
                    sexo = "H";
                }
                else
                {
                    sexo = "M";
                }

                cmd = new SqlCommand("UPDATE Medicos set Nombres='" + txt_Nombres.Text + "', Apellidos='" + txt_Apellidos.Text + "', Direccion='" + txt_Direccion.Text + "', Edad=" + txt_Edad.Text + ", Sexo='" + sexo + "', Telefono=" + txt_Telefono.Text + ", Email='" + txt_Email.Text + "' WHERE MedicoID=" + ID + "", m.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medico Actualizado!");
                mostrarInfo();
                limpiarFormulario();
                ID = -1;
            }
             catch
            {
                MessageBox.Show("Selecciona un medico de la tabla para actualizar");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if(ID > 0)
            {
               
                    cmd = new SqlCommand("DELETE FROM Medicos WHERE MedicoID='" + ID + "'", m.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medico Eliminado!");
                    mostrarInfo();
                    limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Selecciona un medico de la tabla para eliminar");
            }
           
        }

        private void tableMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(tableMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Nombres.Text = tableMedicos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Apellidos.Text = tableMedicos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Direccion.Text = tableMedicos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Edad.Text = tableMedicos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Telefono.Text = tableMedicos.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_Email.Text = tableMedicos.Rows[e.RowIndex].Cells[7].Value.ToString();

            if(tableMedicos.Rows[e.RowIndex].Cells[5].Value.ToString() == "H")
            {
                rb_SexoH.Checked = true;
            } else
            {
                rb_SexoM.Checked = true;
            }
        }

        private void txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.soloLetas(e);
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.soloLetas(e);
        }
    }
}

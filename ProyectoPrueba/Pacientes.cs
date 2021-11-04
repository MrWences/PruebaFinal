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
    public partial class Pacientes : Form
    {
        Metodos m = new Metodos();
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adap;
        DataTable dt;

        int ID;
        public Pacientes()
        {
            InitializeComponent();
        }

        // Metodos
        public void mostrarInfo()
        {
            cmd = new SqlCommand("SELECT * FROM Pacientes", m.con);
            adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;
            dt = new DataTable();
            adap.Fill(dt);
            tablePacientes.DataSource = dt;
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

        private void Pacientes_Load(object sender, EventArgs e)
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

                        cmd = new SqlCommand("INSERT INTO Pacientes(Nombres, Apellidos, Direccion, Edad, Sexo, Telefono, Email) VALUES('" + txt_Nombres.Text + "','" + txt_Apellidos.Text + "','" + txt_Direccion.Text + "'," + txt_Edad.Text + ",'" + sexo + "'," + txt_Telefono.Text + ",'" + txt_Email.Text + "')", m.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Paciente agregado!");
                        mostrarInfo();
                        limpiarFormulario();

                    }
                    else
                    {
                        MessageBox.Show("Escriba correctamente su correo");
                    }


                }
            } catch
            {
                MessageBox.Show("El paciente " + txt_Nombres.Text + " ya esta registrado");
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

                cmd = new SqlCommand("UPDATE Pacientes set Nombres='" + txt_Nombres.Text + "', Apellidos='" + txt_Apellidos.Text + "', Direccion='" + txt_Direccion.Text + "', Edad=" + txt_Edad.Text + ", Sexo='" + sexo + "', Telefono=" + txt_Telefono.Text + ", Email='" + txt_Email.Text + "' WHERE PacienteID=" + ID + "", m.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente  Actualizado!");
                mostrarInfo();
                limpiarFormulario();
            }
            catch
            {
                MessageBox.Show("Selecciona un paciente de la tabla para actualizar");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(ID > 0)
            {
                cmd = new SqlCommand("DELETE FROM Pacientes WHERE PacienteID='" + ID + "'", m.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente Eliminado!");
                mostrarInfo();
                limpiarFormulario();
            } 
            else
            {
                MessageBox.Show("Seleccione un paciente de la tabla para eliminar");
               
            }
            
        }

        private void tablePacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(tablePacientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Nombres.Text = tablePacientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Apellidos.Text = tablePacientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Direccion.Text = tablePacientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Edad.Text = tablePacientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Telefono.Text = tablePacientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_Email.Text = tablePacientes.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (tablePacientes.Rows[e.RowIndex].Cells[5].Value.ToString() == "H")
            {
                rb_SexoH.Checked = true;
            }
            else
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

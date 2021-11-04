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
    public partial class Agendar : Form
    {
        Metodos m = new Metodos();
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        SqlDataAdapter adap;
        DataTable dt;


        int ID;
        
        public Agendar()
        {
            InitializeComponent();
        }

        private void Agendar_Load(object sender, EventArgs e)
        {
            m.Conexion();
            llenarPacientes();
            llenarMedicos();
            mostrarInfo();
        }

        public void llenarPacientes()
        {
            try
            {
                cmd = new SqlCommand("SELECT Nombres FROM Pacientes", m.con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb_Paciente.Items.Add(dr["Nombres"].ToString());
                }
                cb_Paciente.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void llenarMedicos()
        {
            try
            {
                cmd = new SqlCommand("SELECT Nombres FROM Medicos", m.con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb_Medico.Items.Add(dr["Nombres"].ToString());
                }
                cb_Medico.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dt_FechaHora_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void mostrarInfo()
        {
            cmd = new SqlCommand("SELECT * FROM Cita", m.con);
            adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;
            dt = new DataTable();
            adap.Fill(dt);
            tableCitas.DataSource = dt;
        }

        private void buttonAgendar_Click(object sender, EventArgs e)
        {
            DateTime value = dt_FechaHora.Value;

            string day = value.Day.ToString();
            string mes = value.Month.ToString();
            string año = value.Year.ToString();
            string hora = value.Hour.ToString();
            string minuto = value.Minute.ToString();
            string fechaCompleta;

            fechaCompleta = day + "-" + mes + "-" + año + " " + hora + ":" + minuto;

                cmd = new SqlCommand("INSERT INTO Cita(nombreMed, nombrePac, fechaCita) VALUES('" + cb_Medico.Text + "','" + cb_Paciente.Text + "','" + fechaCompleta + "')", m.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cita agregada!");
                mostrarInfo();
        }

        private void tableCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(tableCitas.Rows[e.RowIndex].Cells[0].Value.ToString());
            cb_Medico.Text = tableCitas.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_Paciente.Text = tableCitas.Rows[e.RowIndex].Cells[2].Value.ToString();
            dt_FechaHora.Text = tableCitas.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE FROM Cita WHERE CitaID='" + ID + "'", m.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cita Eliminada!");
            mostrarInfo();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            DateTime value = dt_FechaHora.Value;

            string day = value.Day.ToString();
            string mes = value.Month.ToString();
            string año = value.Year.ToString();
            string hora = value.Hour.ToString();
            string minuto = value.Minute.ToString();
            string fechaCompleta;

            fechaCompleta = day + "-" + mes + "-" + año + " " + hora + ":" + minuto;

            cmd = new SqlCommand("UPDATE Cita set nombreMed='" + cb_Medico.Text + "', nombrePac='" + cb_Paciente.Text + "', fechaCita='" + fechaCompleta + "' WHERE CitaID='" + ID + "'", m.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cita Actualizada!");
            mostrarInfo();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            Pacientes vP = new Pacientes();
            vP.ShowDialog();
        }

        private void buttonMedicos_Click(object sender, EventArgs e)
        {
            Medicos vM = new Medicos();
            vM.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgendar_Click(object sender, EventArgs e)
        {
            Agendar vA = new Agendar();
            vA.ShowDialog();
        }
    }
}

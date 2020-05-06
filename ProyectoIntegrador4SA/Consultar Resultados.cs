using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4SA
{
    public partial class Consultar_Resultados : Form
    {
        public Consultar_Resultados()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador ();
            admin.Show();
            this.Hide();
        }

        private void Consultar_Resultados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

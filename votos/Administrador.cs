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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }


        private void Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Consul_Resul_Click(object sender, EventArgs e)
        {
            Consultar_Resultados consul_res = new Consultar_Resultados();
            this.Hide();
            consul_res.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_Candidatos vot = new Agregar_Candidatos();
            this.Hide();
            vot.Show();
        }

        private void New_Us_Click(object sender, EventArgs e)
        {
            Agregar_Usu Agre_Us = new Agregar_Usu();
            this.Hide();
            Agre_Us.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form Inic = new Inicio();
            Inic.Show();
            this.Hide();
        }
    }
}

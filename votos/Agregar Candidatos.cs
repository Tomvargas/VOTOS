using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoIntegrador4SA
{
    public partial class Agregar_Candidatos : Form
    {
        

        private void Back_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.Show();
            this.Hide();
        }

        private void Agregar_Candidatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void Registrar_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

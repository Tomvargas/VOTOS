using System;
using System.Windows.Forms;

namespace ProyectoIntegrador4SA
{
    public partial class Agregar_Candidatos : Form
    {
        public Agregar_Candidatos()
        {
            InitializeComponent();
            CBDignidad.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            CBLista.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        

        private void Back_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.Show();
            this.Hide();
        }

        private void Agregar_Candidatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {

        }
    }
}

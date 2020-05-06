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
using MyLibrary;

namespace ProyectoIntegrador4SA
{
    public partial class Agregar_Usu : Form
    {
        public Agregar_Usu()
        {
            InitializeComponent();
            CBTip_Us.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Agregar_Usu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.Show();
            this.Hide();
        }

        public void VaciarCajasDeTexto()
        {
            CIUsuario.Clear();
            NomUsu.Clear();
            Usu.Clear();
            Contrase.Clear();
        }

     
        private void Agregar_Click(object sender, EventArgs e)
        { /*
            void NewUser(string CI, string nom, string user, string pass, string acount)
            {

                var users = new List<string>();
                users.Add(CI);
                users.Add(nom);
                users.Add(user);
                users.Add(pass);
                users.Add(acount);

            }

            NewUser(CIUsuario.Text, NomUsu.Text, Usu.Text, Contrase.Text, CBTip_Us.Text);
            */
        }

        private void Agregar_Usu_Load(object sender, EventArgs e)
        {

        }
    }
}

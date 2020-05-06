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
        {
            if (CIUsuario.Text.Length == 10)
            {
                if ((NomUsu.Text.All(Char.IsLetter)))
                {
                    if ((Usu.Text.All(Char.IsLetter)))
                    {
                        if (CBTip_Us.Text =="Administrador" || CBTip_Us.Text =="Usuario Normal")
                        {
                            int typeUser;
                            if(CBTip_Us.Text == "Administrador")
                            {
                                typeUser = 1;
                            }
                            else
                            {
                                typeUser = 0;
                            }
                            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OKDP4CQ;Initial Catalog=SOFTINT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES ('"+Usu.Text+"','"+Contrase.Text+ "',"+typeUser+",'"+CIUsuario.Text+"','"+NomUsu.Text+"')",con);
                            int i = cmd.ExecuteNonQuery();
                            if (i != 0)
                            {
                                MessageBox.Show("Usuario Registrado.");
                                Administrador admin = new Administrador();
                                admin.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Algo resultó mal, intenta de nuevo.");
                                Administrador admin = new Administrador();
                                admin.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("tipo de usuario no válido.");
                            CBTip_Us.Text = "Seleccionar";
                        }
                    }
                    else { MessageBox.Show("Usuario no válido."); Usu.Clear(); }
                }
                else{MessageBox.Show("Apellido no válido."); NomUsu.Clear(); }
            }
            else{ MessageBox.Show("CI no válido."); CIUsuario.Clear(); }
 }

        private void Agregar_Usu_Load(object sender, EventArgs e)
        {

        }

        private void CBTip_Us_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoIntegrador4SA
{


    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            psw.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            int typeUser;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-OKDP4CQ;Initial Catalog=SOFTINT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from Users where Us_user=@user and Us_pass=@pass", con);
                cmd.Parameters.AddWithValue("@user", usr.Text);
                cmd.Parameters.AddWithValue("@pass", psw.Text);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // get the results of each column
                        typeUser = (int)reader["Us_type"];

                        if (typeUser == 1)
                        {
                            Administrador adm = new Administrador();
                            this.Hide();
                            adm.Show();
                        }
                        else
                        {
                            if (typeUser == 0)
                            {
                                Usuario user = new Usuario();
                                this.Hide();
                                user.Show();
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectas");
                    usr.Clear();
                    psw.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error!!");
                usr.Clear();
                psw.Clear();
            }

        }

        
        private void Inicio_Load(object sender, EventArgs e)
        {
            Acceder.Enabled = false;
            psw.Enabled = false;
        }


        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void validaciones()
        {
            if (usr.Text.Trim() != string.Empty && usr.Text.All(Char.IsLetter))
            {
                Acceder.Enabled = true;
                psw.Enabled = true;
                errorProvider1.SetError(usr, "");
            }
            else
            {
                if (!(usr.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(usr, "En este campo solo se admiten letras");
                    psw.Enabled = false;
                }
               
                Acceder.Enabled = false;
                usr.Focus();
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validaciones();
        }
    }

        
    }


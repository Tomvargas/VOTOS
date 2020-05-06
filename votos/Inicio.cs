using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
namespace ProyectoIntegrador4SA
{
   

    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (textBox1.Text  == "admin" && "12345" == textBox2.Text)
                {
                      MessageBox.Show("Se ha ingresado como Administrador");
                        Administrador Admin = new Administrador();
                        this.Hide();
                        Admin.Show();
                        
                    
                    
                }
                else {
                    if (textBox1.Text == "user" && "12345" == textBox2.Text)
                {
                        MessageBox.Show("Se ha ingresado como Usuario");
                        Usuario us = new Usuario();
                        this.Hide();
                        us.Show();
                    }
                    else
                    {
                        if(textBox1.Text == "albert" && "12345" == textBox2.Text)// usuarios agregados
                        {
                            Usuario us = new Usuario();
                            this.Hide();
                            us.Show();
                        }
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrectas");
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        

        private void Inicio_Load(object sender, EventArgs e)
        {
            Acceder.Enabled = false;
            textBox2.Enabled = false;
        }


        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void validaciones()
        {
            if (textBox1.Text.Trim() != string.Empty && textBox1.Text.All(Char.IsLetter))
            {
                Acceder.Enabled = true;
                textBox2.Enabled = true;
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                if (!(textBox1.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(textBox1, "En este campo solo se admiten letras");
                    textBox2.Enabled = false;
                }
               
                Acceder.Enabled = false;
                textBox1.Focus();
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validaciones();
        }
    }

        
    }


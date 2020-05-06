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
    public partial class Identificar_Sufragante : Form
    {
        public Identificar_Sufragante()
        {
            InitializeComponent();
        }


        private void Identificar_Sufragante_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form Docen = new Usuario();
            this.Hide();
            Docen.Show();

  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sufragio sf = new Sufragio();
            this.Hide();
            sf.Show();
        }

        private void Identificar_Sufragante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

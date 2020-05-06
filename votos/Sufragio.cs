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
    public partial class Sufragio : Form
    {
        public Sufragio()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Form ids = new Identificar_Sufragante();
            this.Hide();

            ids.Show();
        }

        private void Sufragar_Click(object sender, EventArgs e)
        {

        }
    }
}

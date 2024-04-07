using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_POEV_OILM
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void proyectoCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pCalculadora = new frmMatrices();
            pCalculadora.Show();
            this.Hide();
        }

        private void proyectoBatallaNavalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form pBatallaN = new frmBatallaNaval();
            pBatallaN.Show();
            this.Hide();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

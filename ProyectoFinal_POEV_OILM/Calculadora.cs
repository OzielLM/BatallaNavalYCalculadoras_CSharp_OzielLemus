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
    public partial class frmMatrices : Form
    {

        public frmMatrices()
        {
            InitializeComponent();
        }

        private void calculadoraDeUnidadesDeMediciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cum = new frmMedicionM();
            cum.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form pr = new frmPrincipal();
            pr.Show();
            this.Close();
        }

        double[,] m1;
        double[,] m2;
        double[,] mR;
        int f1;
        int c1;
        int f2;
        int c2;
        private void btnDatosM1_Click(object sender, EventArgs e)
        {
            f1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce las filas de la matriz 1 (En valor entero)", "Matriz 1"));
            c1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce las columnas de la matriz 1 (En valor entero)", "Matriz 1"));

            m1 = new double[f1, c1];

            for (int i = 0; i < f1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    m1[i,j] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Introduce el valor de ({i},{j})","Matriz 1"));
                }
            }

            string fila;
            for (int i = 0; i < f1; i++)
            {
                fila = "";
                for (int j = 0; j < c1; j++)
                {
                    fila += "[" + m1[i,j] + "] ";
                }
                lstMatriz1.Items.Add(fila);
            }
        }

        private void btnDatosM2_Click(object sender, EventArgs e)
        {
            f2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce las filas de la matriz 2 (En valor entero)", "Matriz 2"));
            c2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce las columnas de la matriz 2 (En valor entero)", "Matriz 2"));

            m2 = new double[f2, c2];

            for (int i = 0; i < f2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    m2[i, j] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Introduce el valor de ({i},{j})", "Matriz 2"));
                }
            }

            string fila;
            for (int i = 0; i < f2; i++)
            {
                fila = "";
                for (int j = 0; j < c2; j++)
                {
                    fila += "[" + m2[i, j] + "] ";
                }
                lstMatriz2.Items.Add(fila);
            }

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnMulti.Enabled = true;
            btnDatosM1.Enabled = false;
            btnDatosM2.Enabled = false;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if(f1 == f2 && c1 == c2)
            {
                lblSigno.Text = "+";
                mR = new double[f2, c2];
                for (int i = 0; i < f2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        mR[i, j] = m1[i, j] + m2[i, j];
                    }
                }
                btnResultado.Enabled = true;
                btnSuma.Enabled = false;
                btnResta.Enabled = false;
                btnMulti.Enabled = false;
            }
            else
            {
                MessageBox.Show("Las filas y columnas de la primera matriz no coincide con la segunda matriz, por favor introduzca nuevas filas y nuevas columnas que coincidan");
                btnDatosM1.Enabled = true;
                btnDatosM2.Enabled = true;
                btnSuma.Enabled = false;
                btnResta.Enabled = false;
                btnMulti.Enabled = false;
                btnResultado.Enabled = false;
                lblSigno.Text = ".";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (f1 == f2 && c1 == c2)
            {
                lblSigno.Text = "-";
                mR = new double[f2, c2];
                for (int i = 0; i < f2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        mR[i, j] = m1[i, j] - m2[i, j];
                    }
                }
                btnResultado.Enabled = true;
                btnSuma.Enabled = false;
                btnResta.Enabled = false;
                btnMulti.Enabled = false;
            }
            else
            {
                MessageBox.Show("Las filas y columnas de la primera matriz no coincide con la segunda matriz, por favor introduzca nuevas filas y nuevas columnas que coincidan");
                btnDatosM1.Enabled = true;
                btnDatosM2.Enabled = true;
                btnSuma.Enabled = false;
                btnResta.Enabled = false;
                btnMulti.Enabled = false;
                btnResultado.Enabled = false;
                lblSigno.Text = ".";
                lstMatriz1.Items.Clear();
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (c1 == f2)
            {
                lblSigno.Text = "x";
                mR = new double[f1, c2];
                for (int i = 0; i < f1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        for (int k = 0; k < c1; k++)
                        {
                            mR[i,j] += m1[i,k] * m2[k,j];
                        }
                    }
                }
                btnResultado.Enabled = true;
                btnSuma.Enabled = false;
                btnResta.Enabled = false;
                btnMulti.Enabled = false;
            }
            else
            {
                MessageBox.Show("Las columna de la matriz 1 no coincide con las filas segunda matriz, por favor introduce nuevas filas y nuevas columnas que coincidan");
                btnDatosM1.Enabled = true;
                btnDatosM2.Enabled = true;
                btnSuma.Enabled = false;
                btnResta.Enabled = false;
                btnMulti.Enabled = false;
                btnResultado.Enabled = false;
                lblSigno.Text = ".";
                lstMatriz2.Items.Clear();
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            string fila;
            for (int i = 0; i < f1; i++)
            {
                fila = "";
                for (int j = 0; j < c2; j++)
                {
                    fila += "[" + mR[i, j] + "] ";
                }
                lstMatrizR.Items.Add(fila);
            }
            btnResultado.Enabled = false;
            btnReiniciar.Enabled = true;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lstMatriz1.Items.Clear();
            lstMatriz2.Items.Clear();
            lstMatrizR.Items.Clear();
            btnDatosM1.Enabled = true;
            btnDatosM2.Enabled = true;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnMulti.Enabled = false;
            btnResultado.Enabled = false;
            btnReiniciar.Enabled = false;
            lblSigno.Text = ".";
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

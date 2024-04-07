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
    public partial class frmMedicionL : Form
    {
        double texto1;
        double texto2;
        public frmMedicionL()
        {
            InitializeComponent();
        }

        private void masaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form m = new frmMedicionM();
            m.Show();
            this.Hide();
        }

        private void calculadoraDeMatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cm = new frmMatrices();
            cm.Show();
            this.Hide();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pr = new frmPrincipal();
            pr.Show();
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNum1.Text += "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtNum1.Text += ".";
            btnPunto.Enabled = false;
        }

        private void cmbNum1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Equals(null))
            {
                texto1 = 0;
                texto1 = double.Parse(txtNum1.Text);
            }
            else
            {
                if (txtNum1.Text.Equals("."))
                {
                    MessageBox.Show("Se introdujo un punto antes de un número, por favor introduzca un numero antes o despues del punto");
                    btnPunto.Enabled = true;
                    txtNum1.Text = "";
                    txtNum2.Text = "";
                }
                else
                {
                    texto1 = double.Parse(txtNum1.Text);
                }
            }

            if (cmbNum1.SelectedIndex == 0 || cmbNum1.Text.Equals("Centimetro"))
            {
                if (cmbNum2.SelectedIndex == 0 || cmbNum2.Text.Equals("Centimetro"))
                {
                    texto2 = texto1;
                }
                else
                {
                    if (cmbNum2.SelectedIndex == 1 || cmbNum2.Text.Equals("Metro"))
                    {
                        texto2 = (texto1 * 0.01);
                    }
                    else
                    {
                        if (cmbNum2.SelectedIndex == 2 || cmbNum2.Text.Equals("Kilometro"))
                        {
                            texto2 = (texto1 * 0.00001);
                        }
                    }
                }
            }
            else
            {
                if (cmbNum1.SelectedIndex == 1 || cmbNum1.Text.Equals("Metro"))
                {
                    if (cmbNum2.SelectedIndex == 0 || cmbNum2.Text.Equals("Centimetro"))
                    {
                        texto2 = (texto1 * 100);
                    }
                    else
                    {
                        if (cmbNum2.SelectedIndex == 1 || cmbNum2.Text.Equals("Metro"))
                        {
                            texto2 = texto1;
                        }
                        else
                        {
                            if (cmbNum2.SelectedIndex == 2 || cmbNum2.Text.Equals("Kilometro"))
                            {
                                texto2 = (texto1 * 0.001);
                            }
                        }
                    }
                }
                else
                {
                    if (cmbNum1.SelectedIndex == 2 || cmbNum1.Text.Equals("Kilometro"))
                    {
                        if (cmbNum2.SelectedIndex == 0 || cmbNum2.Text.Equals("Centimetro"))
                        {
                            texto2 = (texto1 * 100000);
                        }
                        else
                        {
                            if (cmbNum2.SelectedIndex == 1 || cmbNum2.Text.Equals("Metro"))
                            {
                                texto2 = (texto1 * 1000);
                            }
                            else
                            {
                                if (cmbNum2.SelectedIndex == 2 || cmbNum2.Text.Equals("Kilometro"))
                                {
                                    texto2 = texto1;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecciono o Escribe una opcion que no se encuentra, por favor seleccione una de las opciones establecidas");
                    }
                }
            }
            txtNum2.Text = texto2.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            texto1 = 0;
            texto2 = 0;
            btnPunto.Enabled = true;
        }
    }
}

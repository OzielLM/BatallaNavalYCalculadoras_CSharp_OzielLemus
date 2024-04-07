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
    public partial class frmBatallaNaval : Form
    {
        public frmBatallaNaval()
        {
            InitializeComponent();
        }

        Button[] batallanaval;
        Image barcop1 = Image.FromFile("barco p1.png");
        Image barcop2 = Image.FromFile("barco p2.png");
        Image isla = Image.FromFile("Isla.png");
        Image fosaM = Image.FromFile("fosa-marna.png");
        int puntuacion;
        int cont;
        private void frmBatallaNaval_Load(object sender, EventArgs e)
        {
            batallanaval = new Button[36];
            batallanaval[0] = btn1;
            batallanaval[1] = btn2;
            batallanaval[2] = btn3;
            batallanaval[3] = btn4;
            batallanaval[4] = btn5;
            batallanaval[5] = btn6;
            batallanaval[6] = btn7;
            batallanaval[7] = btn8;
            batallanaval[8] = btn9;
            batallanaval[9] = btn10;
            batallanaval[10] = btn11;
            batallanaval[11] = btn12;
            batallanaval[12] = btn13;
            batallanaval[13] = btn14;
            batallanaval[14] = btn15;
            batallanaval[15] = btn16;
            batallanaval[16] = btn17;
            batallanaval[17] = btn18;
            batallanaval[18] = btn19;
            batallanaval[19] = btn20;
            batallanaval[20] = btn21;
            batallanaval[21] = btn22;
            batallanaval[22] = btn23;
            batallanaval[23] = btn24;
            batallanaval[24] = btn25;
            batallanaval[25] = btn26;
            batallanaval[26] = btn27;
            batallanaval[27] = btn28;
            batallanaval[28] = btn29;
            batallanaval[29] = btn30;
            batallanaval[30] = btn31;
            batallanaval[31] = btn32;
            batallanaval[32] = btn33;
            batallanaval[33] = btn34;
            batallanaval[34] = btn35;
            batallanaval[35] = btn36;

            juegoNuevo(batallanaval);
        }

        public void juegoNuevo(Button[] b)
        {
            puntuacion = 100;
            lblPuntuacion.Text = "Puntuacion: " + puntuacion.ToString();

            for (int i = 0; i < 36; i++)
            {
                b[i].Enabled = true;
            }

            for (int i = 0; i < 36; i++)
            {
                b[i].Text = " ";
                b[i].BackColor = Color.Aqua;
                b[i].ForeColor = Color.Aqua;
            }

            Random rm = new Random();
            int[] nr = new int[6];

            for (int i = 0; i < 6; i++)
            {
                nr[i] = rm.Next(0, 35);
            }

            int barcoAdelante1;
            int barcoAdelante2;
            int barcoAdelante3;
            if (nr[0] == 0 || nr[0] == 6 || nr[0] == 12 || nr[0] == 18 || nr[0] == 24 || nr[0] == 30)
            {
                barcoAdelante1 = nr[0] + 1;
            }
            else
            {
                if (nr[0] == 5 || nr[0] == 11 || nr[0] == 17 || nr[0] == 23 || nr[0] == 29 || nr[0] == 35)
                {
                    nr[0] -= 1;
                    barcoAdelante1 = nr[0] + 1;
                }
                else
                {
                    barcoAdelante1 = nr[0] + 1;
                }
            }

            if((nr[1] == nr[0] || nr[1] == barcoAdelante1) && (nr[1] == 0 || nr[1] == 6 || nr[1] == 12 || nr[1] == 18 || nr[1] == 24 || nr[1] == 30))
            {
                nr[1] += 2;
                barcoAdelante2 = nr[1] + 1;
            }
            else
            {
                if (nr[1] == 0 || nr[1] == 6 || nr[1] == 12 || nr[1] == 18 || nr[1] == 24 || nr[1] == 30)
                {
                    barcoAdelante2 = nr[1] + 1;
                }
                else
                {
                    if (nr[1] == 5 || nr[1] == 11 || nr[1] == 17 || nr[1] == 23 || nr[1] == 29 || nr[1] == 35)
                    {
                        nr[1] -= 1;
                        barcoAdelante2 = nr[1] + 1;
                    }
                    else
                    {
                        barcoAdelante2 = nr[1] + 1;
                    }
                }
            }
            
            if((nr[2] == nr[0] || nr[2] == barcoAdelante1 || nr[2] == nr[1] || nr[2] == barcoAdelante2) && nr[2] == 0 || nr[2] == 6 || nr[2] == 12 || nr[2] == 18 || nr[2] == 24 || nr[2] == 30)
            {
                nr[2] += 2;
                barcoAdelante3 = nr[2] + 1;
            }
            else
            {
                if (nr[2] == 0 || nr[2] == 6 || nr[2] == 12 || nr[2] == 18 || nr[2] == 24 || nr[2] == 30)
                {
                    barcoAdelante3 = nr[2] + 1;
                }
                else
                {
                    if (nr[2] == 5 || nr[2] == 11 || nr[2] == 17 || nr[2] == 23 || nr[2] == 29 || nr[2] == 35)
                    {
                        nr[2] -= 1;
                        barcoAdelante3 = nr[2] + 1;
                    }
                    else
                    {
                        barcoAdelante3 = nr[2] + 1;
                    }
                }
            }

            for (int i = 1; i <= 2; i++)
            {
                if ((nr[3] == barcoAdelante1 && barcoAdelante1 == 35) || (nr[3] == barcoAdelante2 && barcoAdelante2 == 35) || (nr[3] == barcoAdelante3 && barcoAdelante3 == 35))
                {
                    nr[3] -= 2;
                }
                else
                {
                    if (nr[3] == nr[0] || nr[3] == barcoAdelante1 || nr[3] == nr[1] || nr[3] == barcoAdelante2 || nr[3] == nr[2] || nr[2] == barcoAdelante3)
                    {
                        nr[3] += 2;
                    }
                }
            }

            for (int i = 1; i <= 3; i++)
            {
                if ((nr[4] == barcoAdelante1 && barcoAdelante1 == 35) || (nr[4] == barcoAdelante2 && barcoAdelante2 == 35) || (nr[4] == barcoAdelante3 && barcoAdelante3 == 35) || (nr[4] == nr[3] && nr[3] == 35))
                {
                    nr[4] -= 2;
                }
                else
                {
                    if (nr[4] == nr[0] || nr[4] == barcoAdelante1 || nr[4] == nr[1] || nr[4] == barcoAdelante2 || nr[4] == nr[2] || nr[4] == barcoAdelante3 || nr[4] == nr[3])
                    {
                        nr[4] += 2;
                    }
                }
            }

            for (int i = 1; i <= 4; i++)
            {
                if ((nr[5] == barcoAdelante1 && barcoAdelante1 == 35) || (nr[5] == barcoAdelante2 && barcoAdelante2 == 35) || (nr[5] == barcoAdelante3 && barcoAdelante3 == 35) || (nr[5] == nr[3] && nr[3] == 35) || (nr[5] == nr[4] && nr[4] == 35))
                {
                    nr[5] -= 2;
                }
                else
                {
                    if (nr[5] == nr[0] || nr[5] == barcoAdelante1 || nr[5] == nr[1] || nr[5] == barcoAdelante2 || nr[5] == nr[2] || nr[5] == barcoAdelante3 || nr[5] == nr[3] || nr[5] == nr[4])
                    {
                        nr[5] += 2;
                    }
                }
            }
            

            b[nr[0]].Text = "<Barco";
            b[barcoAdelante1].Text = "Barco>";
            b[nr[1]].Text = "<Barco";
            b[barcoAdelante2].Text = "Barco>";
            b[nr[2]].Text = "<Barco";
            b[barcoAdelante3].Text = "Barco>";
            b[nr[3]].Text = "Fosa";
            b[nr[4]].Text = "Isla";
            b[nr[5]].Text = "Isla";

            cont = 0;

            for (int i = 0; i < 36; i++)
            {
                b[i].BackgroundImage = null;
            }
        }

        private void batallaNaval(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "<Barco")
            {
                puntuacion += 30;
                lblPuntuacion.Text = "Puntuacion: " + puntuacion.ToString();
                b.BackgroundImageLayout = ImageLayout.Zoom;
                b.BackgroundImage = barcop1;
                b.Text = "";
                b.Enabled = false;
                cont++;
            }
            else
            {
                if (b.Text == "Barco>")
                {
                    puntuacion += 30;
                    lblPuntuacion.Text = "Puntuacion: " + puntuacion.ToString();
                    b.BackgroundImageLayout = ImageLayout.Zoom;
                    b.BackgroundImage = barcop2;
                    b.Text = "";
                    b.Enabled = false;
                    cont++;
                }
                else
                {
                    if (b.Text == "Isla")
                    {
                        puntuacion += 50;
                        lblPuntuacion.Text = "Puntuacion: " + puntuacion.ToString();
                        b.BackgroundImageLayout = ImageLayout.Zoom;
                        b.BackgroundImage = isla;
                        b.Text = "";
                        b.Enabled = false;
                    }
                    else
                    {
                        if (b.Text == "Fosa")
                        {
                            puntuacion = 0;
                            MessageBox.Show("Juego Terminado");
                            lblPuntuacion.Text = "Puntuacion: " + puntuacion.ToString();
                            b.BackgroundImageLayout = ImageLayout.Zoom;
                            b.BackgroundImage = fosaM;
                            b.Text = "";
                            gameOver();
                        }
                        else
                        {
                            puntuacion -= 20;
                            b.Enabled = false;
                            lblPuntuacion.Text = "Puntuacion: " + puntuacion.ToString();
                            gameOver();
                        }
                    }
                }
            }
            if (cont == 6)
            {
                MessageBox.Show("Ganaste");
            }
        }

        public void gameOver()
        {
            if (puntuacion <= 0)
            {
                MessageBox.Show("Juego Terminado");
                for (int i = 0; i < 36; i++)
                {
                    batallanaval[i].Enabled = false;
                }
            }
        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            juegoNuevo(batallanaval);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pr = new frmPrincipal();
            pr.Show();
            this.Close();
        }
    }
}

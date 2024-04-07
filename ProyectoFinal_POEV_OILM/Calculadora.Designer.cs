
namespace ProyectoFinal_POEV_OILM
{
    partial class frmMatrices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.calculadoraDeUnidadesDeMediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lstMatriz1 = new System.Windows.Forms.ListBox();
            this.lstMatriz2 = new System.Windows.Forms.ListBox();
            this.lstMatrizR = new System.Windows.Forms.ListBox();
            this.btnDatosM1 = new System.Windows.Forms.Button();
            this.btnDatosM2 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblSigno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraDeUnidadesDeMediciónToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cerrarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(813, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // calculadoraDeUnidadesDeMediciónToolStripMenuItem
            // 
            this.calculadoraDeUnidadesDeMediciónToolStripMenuItem.Name = "calculadoraDeUnidadesDeMediciónToolStripMenuItem";
            this.calculadoraDeUnidadesDeMediciónToolStripMenuItem.Size = new System.Drawing.Size(224, 20);
            this.calculadoraDeUnidadesDeMediciónToolStripMenuItem.Text = "Calculadora de Unidades de Medición";
            this.calculadoraDeUnidadesDeMediciónToolStripMenuItem.Click += new System.EventHandler(this.calculadoraDeUnidadesDeMediciónToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Volver";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // lstMatriz1
            // 
            this.lstMatriz1.FormattingEnabled = true;
            this.lstMatriz1.Location = new System.Drawing.Point(12, 30);
            this.lstMatriz1.Name = "lstMatriz1";
            this.lstMatriz1.Size = new System.Drawing.Size(201, 147);
            this.lstMatriz1.TabIndex = 1;
            // 
            // lstMatriz2
            // 
            this.lstMatriz2.FormattingEnabled = true;
            this.lstMatriz2.Location = new System.Drawing.Point(293, 30);
            this.lstMatriz2.Name = "lstMatriz2";
            this.lstMatriz2.Size = new System.Drawing.Size(201, 147);
            this.lstMatriz2.TabIndex = 2;
            // 
            // lstMatrizR
            // 
            this.lstMatrizR.FormattingEnabled = true;
            this.lstMatrizR.Location = new System.Drawing.Point(597, 30);
            this.lstMatrizR.Name = "lstMatrizR";
            this.lstMatrizR.Size = new System.Drawing.Size(201, 147);
            this.lstMatrizR.TabIndex = 3;
            // 
            // btnDatosM1
            // 
            this.btnDatosM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosM1.Location = new System.Drawing.Point(185, 197);
            this.btnDatosM1.Name = "btnDatosM1";
            this.btnDatosM1.Size = new System.Drawing.Size(258, 86);
            this.btnDatosM1.TabIndex = 4;
            this.btnDatosM1.Text = "Agregar Datos Matriz 1";
            this.btnDatosM1.UseVisualStyleBackColor = true;
            this.btnDatosM1.Click += new System.EventHandler(this.btnDatosM1_Click);
            // 
            // btnDatosM2
            // 
            this.btnDatosM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosM2.Location = new System.Drawing.Point(185, 289);
            this.btnDatosM2.Name = "btnDatosM2";
            this.btnDatosM2.Size = new System.Drawing.Size(258, 86);
            this.btnDatosM2.TabIndex = 5;
            this.btnDatosM2.Text = "Agregar Datos Matriz 2";
            this.btnDatosM2.UseVisualStyleBackColor = true;
            this.btnDatosM2.Click += new System.EventHandler(this.btnDatosM2_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Enabled = false;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(458, 197);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(113, 61);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Enabled = false;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(458, 264);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(113, 61);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Enabled = false;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(458, 331);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(113, 61);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Enabled = false;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(458, 398);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(113, 61);
            this.btnResultado.TabIndex = 9;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno.Location = new System.Drawing.Point(247, 95);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(16, 24);
            this.lblSigno.TabIndex = 10;
            this.lblSigno.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "=";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(185, 381);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(258, 78);
            this.btnReiniciar.TabIndex = 12;
            this.btnReiniciar.Text = "Reiniciar Valores";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // frmMatrices
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 474);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnDatosM2);
            this.Controls.Add(this.btnDatosM1);
            this.Controls.Add(this.lstMatrizR);
            this.Controls.Add(this.lstMatriz2);
            this.Controls.Add(this.lstMatriz1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "frmMatrices";
            this.Text = "Calculadora de Matrices";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraDeUnidadesDeMedicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem calculadoraDeUnidadesDeMediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox lstMatriz1;
        private System.Windows.Forms.ListBox lstMatriz2;
        private System.Windows.Forms.ListBox lstMatrizR;
        private System.Windows.Forms.Button btnDatosM1;
        private System.Windows.Forms.Button btnDatosM2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}
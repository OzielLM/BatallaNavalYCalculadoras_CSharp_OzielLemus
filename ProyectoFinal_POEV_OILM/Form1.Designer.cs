
namespace ProyectoFinal_POEV_OILM
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proyectoCalculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoBatallaNavalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDatos = new System.Windows.Forms.Label();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectoCalculadoraToolStripMenuItem,
            this.proyectoBatallaNavalToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proyectoCalculadoraToolStripMenuItem
            // 
            this.proyectoCalculadoraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyectoCalculadoraToolStripMenuItem.Name = "proyectoCalculadoraToolStripMenuItem";
            this.proyectoCalculadoraToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.proyectoCalculadoraToolStripMenuItem.Text = "Proyecto: Calculadora";
            this.proyectoCalculadoraToolStripMenuItem.Click += new System.EventHandler(this.proyectoCalculadoraToolStripMenuItem_Click);
            // 
            // proyectoBatallaNavalToolStripMenuItem
            // 
            this.proyectoBatallaNavalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyectoBatallaNavalToolStripMenuItem.Name = "proyectoBatallaNavalToolStripMenuItem";
            this.proyectoBatallaNavalToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.proyectoBatallaNavalToolStripMenuItem.Text = "Proyecto: Batalla Naval";
            this.proyectoBatallaNavalToolStripMenuItem.Click += new System.EventHandler(this.proyectoBatallaNavalToolStripMenuItem_Click_1);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(24, 49);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(382, 85);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Oziel Imanol Lemus Montelongo\r\nMatricula: 72634\r\nIngenieria en Software y Sistema" +
    "s Computacionales\r\nProyecto final\r\nProgramacion Orientada a Entornos Virtuales\r\n" +
    "";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 153);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.Text = "Proyecto Final";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proyectoCalculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectoBatallaNavalToolStripMenuItem;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}


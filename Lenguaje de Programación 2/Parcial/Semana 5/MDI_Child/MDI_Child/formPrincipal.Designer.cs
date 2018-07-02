namespace MDI_Child
{
    partial class formPrincipal
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
            this.móduloDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.móduloDeLogísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.móduloDeVentasToolStripMenuItem,
            this.móduloDeLogísticaToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(849, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // móduloDeVentasToolStripMenuItem
            // 
            this.móduloDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarVentasToolStripMenuItem});
            this.móduloDeVentasToolStripMenuItem.Name = "móduloDeVentasToolStripMenuItem";
            this.móduloDeVentasToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.móduloDeVentasToolStripMenuItem.Text = "Módulo de Ventas";
            // 
            // gestionarVentasToolStripMenuItem
            // 
            this.gestionarVentasToolStripMenuItem.Name = "gestionarVentasToolStripMenuItem";
            this.gestionarVentasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gestionarVentasToolStripMenuItem.Text = "Gestionar Ventas";
            this.gestionarVentasToolStripMenuItem.Click += new System.EventHandler(this.gestionarVentasToolStripMenuItem_Click);
            // 
            // móduloDeLogísticaToolStripMenuItem
            // 
            this.móduloDeLogísticaToolStripMenuItem.Name = "móduloDeLogísticaToolStripMenuItem";
            this.móduloDeLogísticaToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.móduloDeLogísticaToolStripMenuItem.Text = "Módulo de Logística";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 356);
            this.panel1.TabIndex = 2;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 389);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formPrincipal";
            this.Text = "Formulario Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem móduloDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem móduloDeLogísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}


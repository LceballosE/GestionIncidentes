namespace ModuloReportes
{
    partial class ContenedorPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.requerimientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requerimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesAvanzadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbUsuario = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.buscarToolStripMenuItem,
            this.opcionesAvanzadasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(922, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requerimientoToolStripMenuItem1,
            this.usuarioToolStripMenuItem1});
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            // 
            // requerimientoToolStripMenuItem1
            // 
            this.requerimientoToolStripMenuItem1.Name = "requerimientoToolStripMenuItem1";
            this.requerimientoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.requerimientoToolStripMenuItem1.Text = "Requerimiento";
            this.requerimientoToolStripMenuItem1.Click += new System.EventHandler(this.requerimientoToolStripMenuItem1_Click);
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuario";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analistaToolStripMenuItem,
            this.requerimientoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // analistaToolStripMenuItem
            // 
            this.analistaToolStripMenuItem.Name = "analistaToolStripMenuItem";
            this.analistaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analistaToolStripMenuItem.Text = "Analista";
            this.analistaToolStripMenuItem.Click += new System.EventHandler(this.analistaToolStripMenuItem_Click);
            // 
            // requerimientoToolStripMenuItem
            // 
            this.requerimientoToolStripMenuItem.Name = "requerimientoToolStripMenuItem";
            this.requerimientoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.requerimientoToolStripMenuItem.Text = "Requerimiento";
            this.requerimientoToolStripMenuItem.Click += new System.EventHandler(this.requerimientoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // opcionesAvanzadasToolStripMenuItem
            // 
            this.opcionesAvanzadasToolStripMenuItem.Name = "opcionesAvanzadasToolStripMenuItem";
            this.opcionesAvanzadasToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.opcionesAvanzadasToolStripMenuItem.Text = "Busqueda Avanzadas";
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(750, 6);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(160, 18);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "......................................";
            // 
            // ContenedorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(922, 526);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ContenedorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContenedorPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContenedorPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.ContenedorPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requerimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem requerimientoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcionesAvanzadasToolStripMenuItem;
        private System.Windows.Forms.Label lbUsuario;
    }
}




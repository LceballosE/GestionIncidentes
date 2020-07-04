namespace ModuloReportes
{
    partial class ConfigUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigUsuario));
            this.Lbtitulo = new System.Windows.Forms.Label();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.BtnCambiarPass = new System.Windows.Forms.Button();
            this.BtnModuloRep = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelformularios.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelformularios
            // 
            this.panelformularios.Controls.Add(this.pictureBox1);
            this.panelformularios.Controls.Add(this.pictureBox2);
            this.panelformularios.Controls.Add(this.Lbtitulo);
            this.panelformularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformularios.Location = new System.Drawing.Point(200, 40);
            this.panelformularios.Size = new System.Drawing.Size(650, 610);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.BtnCerrarSesion);
            this.panelMenu.Controls.Add(this.BtnCambiarPass);
            this.panelMenu.Controls.Add(this.lbUsuario);
            this.panelMenu.Controls.Add(this.BtnModuloRep);
            // 
            // Lbtitulo
            // 
            this.Lbtitulo.AutoSize = true;
            this.Lbtitulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbtitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbtitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbtitulo.Location = new System.Drawing.Point(222, 61);
            this.Lbtitulo.Name = "Lbtitulo";
            this.Lbtitulo.Size = new System.Drawing.Size(161, 27);
            this.Lbtitulo.TabIndex = 7;
            this.Lbtitulo.Text = "Configuración";
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarSesion.Image")));
            this.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(3, 491);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(196, 62);
            this.BtnCerrarSesion.TabIndex = 18;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // BtnCambiarPass
            // 
            this.BtnCambiarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCambiarPass.FlatAppearance.BorderSize = 0;
            this.BtnCambiarPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BtnCambiarPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnCambiarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarPass.ForeColor = System.Drawing.Color.White;
            this.BtnCambiarPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCambiarPass.Location = new System.Drawing.Point(4, 175);
            this.BtnCambiarPass.Name = "BtnCambiarPass";
            this.BtnCambiarPass.Size = new System.Drawing.Size(196, 62);
            this.BtnCambiarPass.TabIndex = 17;
            this.BtnCambiarPass.Text = "Cambiar Contraseña";
            this.BtnCambiarPass.UseVisualStyleBackColor = true;
            this.BtnCambiarPass.Click += new System.EventHandler(this.BtnCambiarPass_Click);
            // 
            // BtnModuloRep
            // 
            this.BtnModuloRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnModuloRep.FlatAppearance.BorderSize = 0;
            this.BtnModuloRep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BtnModuloRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnModuloRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModuloRep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModuloRep.ForeColor = System.Drawing.Color.White;
            this.BtnModuloRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModuloRep.Location = new System.Drawing.Point(1, 253);
            this.BtnModuloRep.Name = "BtnModuloRep";
            this.BtnModuloRep.Size = new System.Drawing.Size(196, 62);
            this.BtnModuloRep.TabIndex = 16;
            this.BtnModuloRep.Text = "Modulo de Gestión";
            this.BtnModuloRep.UseVisualStyleBackColor = true;
            this.BtnModuloRep.Click += new System.EventHandler(this.BtnModuloRep_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(3, 29);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(238, 24);
            this.lbUsuario.TabIndex = 15;
            this.lbUsuario.Text = "......................................";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(503, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 32);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ConfigUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Name = "ConfigUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigUsuario";
            this.Load += new System.EventHandler(this.ConfigUsuario_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelformularios.ResumeLayout(false);
            this.panelformularios.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbtitulo;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button BtnCambiarPass;
        private System.Windows.Forms.Button BtnModuloRep;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
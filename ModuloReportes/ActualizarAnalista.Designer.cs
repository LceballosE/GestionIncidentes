namespace ModuloReportes
{
    partial class ActualizarAnalista
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TxtNombre = new MiLibreria.Errotextbox();
            this.TxtApellido = new MiLibreria.Errotextbox();
            this.TxtUsuarioRed = new MiLibreria.Errotextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtContraseña = new MiLibreria.Errotextbox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nombre";
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.LbTitulo.Location = new System.Drawing.Point(190, 83);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(386, 32);
            this.LbTitulo.TabIndex = 30;
            this.LbTitulo.Text = "Actualizar datos del analista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Usuario de Red";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(258, 501);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 42);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(313, 180);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(234, 26);
            this.TxtNombre.TabIndex = 46;
            this.TxtNombre.validar = true;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(313, 253);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(234, 26);
            this.TxtApellido.TabIndex = 47;
            this.TxtApellido.validar = true;
            // 
            // TxtUsuarioRed
            // 
            this.TxtUsuarioRed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioRed.Location = new System.Drawing.Point(313, 317);
            this.TxtUsuarioRed.Name = "TxtUsuarioRed";
            this.TxtUsuarioRed.Size = new System.Drawing.Size(234, 26);
            this.TxtUsuarioRed.TabIndex = 48;
            this.TxtUsuarioRed.validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(313, 383);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(234, 26);
            this.TxtContraseña.TabIndex = 49;
            this.TxtContraseña.validar = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(437, 501);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 42);
            this.BtnCancelar.TabIndex = 50;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ActualizarAnalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuarioRed);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarAnalista";
            this.Text = "ActualizarUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private MiLibreria.Errotextbox TxtNombre;
        private MiLibreria.Errotextbox TxtApellido;
        private MiLibreria.Errotextbox TxtUsuarioRed;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private MiLibreria.Errotextbox TxtContraseña;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
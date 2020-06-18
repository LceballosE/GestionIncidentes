namespace ModuloReportes
{
    partial class  ActualizarRequerimiento
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
            this.LbTitulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parrDescripcion = new System.Windows.Forms.RichTextBox();
            this.dateFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listUsuario = new MiLibreria.ErrorComboBox();
            this.listTipoCaso = new MiLibreria.ErrorComboBox();
            this.listEstado = new MiLibreria.ErrorComboBox();
            this.listPrioridad = new MiLibreria.ErrorComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.LbTitulo.Location = new System.Drawing.Point(221, 39);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(417, 32);
            this.LbTitulo.TabIndex = 13;
            this.LbTitulo.Text = "Información del Requerimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fecha Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tipo caso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Prioridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Descripción";
            // 
            // parrDescripcion
            // 
            this.parrDescripcion.Location = new System.Drawing.Point(301, 323);
            this.parrDescripcion.Name = "parrDescripcion";
            this.parrDescripcion.Size = new System.Drawing.Size(231, 98);
            this.parrDescripcion.TabIndex = 54;
            this.parrDescripcion.Text = "";
            // 
            // dateFechaIngreso
            // 
            this.dateFechaIngreso.Location = new System.Drawing.Point(205, 138);
            this.dateFechaIngreso.Name = "dateFechaIngreso";
            this.dateFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dateFechaIngreso.TabIndex = 55;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listUsuario
            // 
            this.listUsuario.FormattingEnabled = true;
            this.listUsuario.Location = new System.Drawing.Point(527, 137);
            this.listUsuario.Name = "listUsuario";
            this.listUsuario.Size = new System.Drawing.Size(234, 21);
            this.listUsuario.TabIndex = 56;
            this.listUsuario.Text = "Seleccione ...";
            this.listUsuario.validar = true;
            // 
            // listTipoCaso
            // 
            this.listTipoCaso.FormattingEnabled = true;
            this.listTipoCaso.Location = new System.Drawing.Point(94, 227);
            this.listTipoCaso.Name = "listTipoCaso";
            this.listTipoCaso.Size = new System.Drawing.Size(171, 21);
            this.listTipoCaso.TabIndex = 57;
            this.listTipoCaso.Text = "Seleccione ...";
            this.listTipoCaso.validar = true;
            // 
            // listEstado
            // 
            this.listEstado.FormattingEnabled = true;
            this.listEstado.Location = new System.Drawing.Point(345, 227);
            this.listEstado.Name = "listEstado";
            this.listEstado.Size = new System.Drawing.Size(187, 21);
            this.listEstado.TabIndex = 58;
            this.listEstado.Text = "Seleccione ...";
            this.listEstado.validar = true;
            // 
            // listPrioridad
            // 
            this.listPrioridad.FormattingEnabled = true;
            this.listPrioridad.Location = new System.Drawing.Point(629, 230);
            this.listPrioridad.Name = "listPrioridad";
            this.listPrioridad.Size = new System.Drawing.Size(159, 21);
            this.listPrioridad.TabIndex = 59;
            this.listPrioridad.Text = "Seleccione ...";
            this.listPrioridad.validar = true;
            // 
            // ActualizarRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listPrioridad);
            this.Controls.Add(this.listEstado);
            this.Controls.Add(this.listTipoCaso);
            this.Controls.Add(this.listUsuario);
            this.Controls.Add(this.dateFechaIngreso);
            this.Controls.Add(this.parrDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarRequerimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NuevoRequerimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarRequerimiento_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarRequerimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox parrDescripcion;
        private System.Windows.Forms.DateTimePicker dateFechaIngreso;
        private MiLibreria.ErrorComboBox listUsuario;
        private MiLibreria.ErrorComboBox listPrioridad;
        private MiLibreria.ErrorComboBox listEstado;
        private MiLibreria.ErrorComboBox listTipoCaso;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
namespace ModuloReportes
{
    partial class ConfirmarEliminar
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
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.TxtEliminar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSi
            // 
            this.btnSi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.Location = new System.Drawing.Point(256, 12);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(36, 27);
            this.btnSi.TabIndex = 0;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(305, 12);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(36, 27);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // TxtEliminar
            // 
            this.TxtEliminar.AutoSize = true;
            this.TxtEliminar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEliminar.Location = new System.Drawing.Point(10, 15);
            this.TxtEliminar.Name = "TxtEliminar";
            this.TxtEliminar.Size = new System.Drawing.Size(224, 20);
            this.TxtEliminar.TabIndex = 2;
            this.TxtEliminar.Text = "Seguro desea eliminar este registro";
            // 
            // ConfirmarEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 51);
            this.Controls.Add(this.TxtEliminar);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Name = "ConfirmarEliminar";
            this.Text = "ConfirmarEliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label TxtEliminar;
    }
}
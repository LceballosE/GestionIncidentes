namespace ModuloReportes
{
    partial class Graficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.reqXanalista = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reqxusuario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReqxEstado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbTotalReq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbIncidentes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbPrioridadAlta = new System.Windows.Forms.Label();
            this.LbCerrados = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LbAnalistas = new System.Windows.Forms.Label();
            this.lc = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnnueno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reqXanalista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqxusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReqxEstado)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(71, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad de Requerimientos por Analistas";
            // 
            // reqXanalista
            // 
            chartArea10.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea10.Name = "ChartArea1";
            this.reqXanalista.ChartAreas.Add(chartArea10);
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.reqXanalista.Legends.Add(legend10);
            this.reqXanalista.Location = new System.Drawing.Point(12, 355);
            this.reqXanalista.Name = "reqXanalista";
            this.reqXanalista.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series10.IsValueShownAsLabel = true;
            series10.IsXValueIndexed = true;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series10.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.reqXanalista.Series.Add(series10);
            this.reqXanalista.Size = new System.Drawing.Size(459, 249);
            this.reqXanalista.TabIndex = 15;
            this.reqXanalista.Text = "5 analistas con más requerimientos";
            // 
            // reqxusuario
            // 
            chartArea11.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea11.Name = "ChartArea1";
            this.reqxusuario.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.reqxusuario.Legends.Add(legend11);
            this.reqxusuario.Location = new System.Drawing.Point(59, 98);
            this.reqxusuario.Name = "reqxusuario";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series11.IsValueShownAsLabel = true;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series11.YValuesPerPoint = 2;
            this.reqxusuario.Series.Add(series11);
            this.reqxusuario.Size = new System.Drawing.Size(316, 201);
            this.reqxusuario.TabIndex = 26;
            this.reqxusuario.Text = "5 analistas con más requerimientos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(28, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Top 5 : Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(162, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "con más Requerimientos";
            // 
            // ReqxEstado
            // 
            chartArea12.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea12.Name = "ChartArea1";
            this.ReqxEstado.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.ReqxEstado.Legends.Add(legend12);
            this.ReqxEstado.Location = new System.Drawing.Point(477, 355);
            this.ReqxEstado.Name = "ReqxEstado";
            this.ReqxEstado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series12.IsValueShownAsLabel = true;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            series12.YValuesPerPoint = 2;
            this.ReqxEstado.Series.Add(series12);
            this.ReqxEstado.Size = new System.Drawing.Size(311, 228);
            this.ReqxEstado.TabIndex = 28;
            this.ReqxEstado.Text = "5 analistas con más requerimientos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(471, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cantidad de Requerimientos por Estados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.LbTotalReq);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(440, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 80);
            this.panel1.TabIndex = 29;
            // 
            // LbTotalReq
            // 
            this.LbTotalReq.AutoSize = true;
            this.LbTotalReq.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalReq.Location = new System.Drawing.Point(69, 41);
            this.LbTotalReq.Name = "LbTotalReq";
            this.LbTotalReq.Size = new System.Drawing.Size(28, 24);
            this.LbTotalReq.TabIndex = 1;
            this.LbTotalReq.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Requerimientos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.LbIncidentes);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(625, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 80);
            this.panel2.TabIndex = 30;
            // 
            // LbIncidentes
            // 
            this.LbIncidentes.AutoSize = true;
            this.LbIncidentes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIncidentes.Location = new System.Drawing.Point(68, 41);
            this.LbIncidentes.Name = "LbIncidentes";
            this.LbIncidentes.Size = new System.Drawing.Size(28, 24);
            this.LbIncidentes.TabIndex = 1;
            this.LbIncidentes.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Incidentes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.LbPrioridadAlta);
            this.panel3.Controls.Add(this.LbCerrados);
            this.panel3.Location = new System.Drawing.Point(440, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 80);
            this.panel3.TabIndex = 31;
            // 
            // LbPrioridadAlta
            // 
            this.LbPrioridadAlta.AutoSize = true;
            this.LbPrioridadAlta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrioridadAlta.Location = new System.Drawing.Point(69, 41);
            this.LbPrioridadAlta.Name = "LbPrioridadAlta";
            this.LbPrioridadAlta.Size = new System.Drawing.Size(28, 24);
            this.LbPrioridadAlta.TabIndex = 1;
            this.LbPrioridadAlta.Text = "...";
            // 
            // LbCerrados
            // 
            this.LbCerrados.AutoSize = true;
            this.LbCerrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCerrados.Location = new System.Drawing.Point(31, 9);
            this.LbCerrados.Name = "LbCerrados";
            this.LbCerrados.Size = new System.Drawing.Size(111, 19);
            this.LbCerrados.TabIndex = 0;
            this.LbCerrados.Text = "Prioridad Alta";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Goldenrod;
            this.panel4.Controls.Add(this.LbAnalistas);
            this.panel4.Controls.Add(this.lc);
            this.panel4.Location = new System.Drawing.Point(625, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 80);
            this.panel4.TabIndex = 30;
            // 
            // LbAnalistas
            // 
            this.LbAnalistas.AutoSize = true;
            this.LbAnalistas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAnalistas.Location = new System.Drawing.Point(68, 41);
            this.LbAnalistas.Name = "LbAnalistas";
            this.LbAnalistas.Size = new System.Drawing.Size(28, 24);
            this.LbAnalistas.TabIndex = 1;
            this.LbAnalistas.Text = "...";
            // 
            // lc
            // 
            this.lc.AutoSize = true;
            this.lc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lc.Location = new System.Drawing.Point(46, 9);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(69, 19);
            this.lc.TabIndex = 0;
            this.lc.Text = "Usuario";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Khaki;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(440, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 80);
            this.panel5.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(122, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "TOTAL";
            // 
            // btnnueno
            // 
            this.btnnueno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnnueno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnnueno.FlatAppearance.BorderSize = 0;
            this.btnnueno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnnueno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnnueno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnueno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnueno.ForeColor = System.Drawing.Color.White;
            this.btnnueno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnueno.Location = new System.Drawing.Point(6, 1);
            this.btnnueno.Name = "btnnueno";
            this.btnnueno.Size = new System.Drawing.Size(76, 29);
            this.btnnueno.TabIndex = 33;
            this.btnnueno.Text = "Refrescar";
            this.btnnueno.UseVisualStyleBackColor = false;
            this.btnnueno.Click += new System.EventHandler(this.btnnueno_Click);
            // 
            // Graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.btnnueno);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReqxEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reqxusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reqXanalista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graficas";
            this.Text = "Graficas";
            this.Load += new System.EventHandler(this.Graficas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reqXanalista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqxusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReqxEstado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart reqXanalista;
        private System.Windows.Forms.DataVisualization.Charting.Chart reqxusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ReqxEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbTotalReq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbIncidentes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbPrioridadAlta;
        private System.Windows.Forms.Label LbCerrados;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LbAnalistas;
        private System.Windows.Forms.Label lc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnnueno;
    }
}
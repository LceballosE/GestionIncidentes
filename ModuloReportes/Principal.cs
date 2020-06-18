﻿using MiLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloReportes
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly, sw, sh;

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btngraficas_Click(object sender, EventArgs e)
        {
            panelsubmenu.Visible = false;
            panelsubmenu2.Visible = false;

            AbrirFormulario<Graficas>();
        }

        private void btnRequerimiento_Click(object sender, EventArgs e)
        {
            panelsubmenu.Visible = false;
            AbrirFormulario<NuevoRequerimiento>();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            panelsubmenu.Visible = false;
            AbrirFormulario<NuevoUsuario>();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (panelsubmenu2.Visible == true)
            {
                panelsubmenu.Visible = false;
                panelsubmenu2.Visible = false;
            }
            else
            {
                panelsubmenu.Visible = false;
                panelsubmenu2.Visible = true;
            }

        }

        private void btnbuscarreq_Click(object sender, EventArgs e)
        {
            panelsubmenu2.Visible = false;
            AbrirFormulario<consultaRequerimiento>();
        }

        private void btnbuscarusuario_Click(object sender, EventArgs e)
        {
            panelsubmenu2.Visible = false;
            AbrirFormulario<consultaUsuario>();
        }

        private void btnbuscatanalista_Click(object sender, EventArgs e)
        {
            panelsubmenu2.Visible = false;
            AbrirFormulario<consultaAnalista>();
        }

        private void btnnueno_Click(object sender, EventArgs e)
        {
            if (panelsubmenu.Visible == true)
            {
                panelsubmenu.Visible = false;
                panelsubmenu2.Visible = false;
            }
            else
            {
                panelsubmenu.Visible = true;
                panelsubmenu2.Visible = false;
            }
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            panelsubmenu.Visible = false;
            panelsubmenu2.Visible = false;
            Autenticacion login = new Autenticacion();
            this.Hide();
            login.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                string consultaUsuario = string.Format("Select * FROM analista WHERE id ='{0}'", Autenticacion.idusuario);
                DataSet dataSet = Utilidades.EjecutarBd(consultaUsuario);
                lbUsuario.Text = dataSet.Tables[0].Rows[0]["nombre"].ToString().Trim() + "   " + dataSet.Tables[0].Rows[0]["apellido"].ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un Error por favor intente nuevamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Autenticacion.nombreUsuario == "admin")
            {
                administrador admin = new administrador();
                admin.Show();
            }
            else
            {
                ConfigUsuario usuario = new ConfigUsuario();
                usuario.Show();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                panelsubmenu.BringToFront();
                panelsubmenu2.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                if (NuevoUsuario.guardado == true || NuevoRequerimiento.guardado == true || ActualizarAnalista.guardado== true)
                {
                    formulario = new MiForm();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    panelformularios.Controls.Add(formulario);
                    panelformularios.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                    panelsubmenu.BringToFront();
                    panelsubmenu2.BringToFront();
                    NuevoRequerimiento.guardado = false;
                    NuevoUsuario.guardado = false;
                    ActualizarAnalista.guardado = false;
                }
                formulario.BringToFront();
                panelsubmenu.BringToFront();
                panelsubmenu2.BringToFront();
            }

        }

        public static void abrirform()
        {
         //  AbrirFormulario<ActualizarAnalista>();
        }


    }
}

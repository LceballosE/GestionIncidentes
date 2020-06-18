using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;
using System.Runtime.InteropServices;

namespace ModuloReportes
{
    public partial class Autenticacion : Form
    {
        public Autenticacion()
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

        public static string idusuario;
        public static string nombreUsuario;
        public static string apellidoUsuario;
        public static string contraseñaUsuario;
        public static string usuarioRed;
      
      
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
   
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
              

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string Ingreso = string.Format("Select * FROM analista WHERE usuariored='{0}' AND contraseña='{1}'", TxtUser.Text.Trim(), TxtPass.Text.Trim());
                DataSet dataSet = Utilidades.EjecutarBd(Ingreso);

                string cuenta = dataSet.Tables[0].Rows[0]["usuariored"].ToString().Trim();
                usuarioRed = cuenta;
                string password = dataSet.Tables[0].Rows[0]["contraseña"].ToString().Trim();
                contraseñaUsuario = password;
                string usercode = dataSet.Tables[0].Rows[0]["id"].ToString().Trim();
                idusuario = usercode;
                string nombre = dataSet.Tables[0].Rows[0]["nombre"].ToString().Trim();
                nombreUsuario = nombre;
                string apellido = dataSet.Tables[0].Rows[0]["apellido"].ToString().Trim();
                apellidoUsuario = apellido;

                if (cuenta == "admin" && TxtPass.Text == password)
                {
                    this.Hide();
                    administrador NuevaVentana = new administrador();
                    NuevaVentana.Show();
                }
                else if (TxtUser.Text == cuenta && TxtPass.Text == password)
                {
                    this.Hide();
                    ConfigUsuario configuracionUser = new ConfigUsuario();
                    configuracionUser.Show();

                }
            }
            catch
            {
                MessageBox.Show("No puedes ingresar, datos incorrectos");
                TxtUser.Text = "";
                TxtPass.Text = "";
                TxtUser.Focus();
            }

        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

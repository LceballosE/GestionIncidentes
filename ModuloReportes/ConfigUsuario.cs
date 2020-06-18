using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloReportes
{
    public partial class ConfigUsuario : diseñoFormularios
    {
        public ConfigUsuario()
        {
            InitializeComponent();
        }


        private void BtnCambiarPass_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CambiarContraseña>();
        }

        private void BtnModuloRep_Click(object sender, EventArgs e)
        {
            Principal contenedorprincipal = new Principal();
            this.Hide();
            contenedorprincipal.Show();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Autenticacion login = new Autenticacion();
            this.Hide();
            login.Show();
        }

        private void ConfigUsuario_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = Autenticacion.nombreUsuario + " " + Autenticacion.apellidoUsuario;
        }
    }

}

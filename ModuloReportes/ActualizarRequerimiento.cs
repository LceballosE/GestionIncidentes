using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;
using MiLibreria;
namespace ModuloReportes
{
    public partial class ActualizarRequerimiento : Form
    {
        public ActualizarRequerimiento()
        {
            InitializeComponent();
        }

        public static bool guardado = false;
        /// <summary>
        /// Metodos de consulta y llenado de informacion
        /// </summary>
      

        private void ActualizarRequerimiento_Load(object sender, EventArgs e)
        {             
            estado.Text = consultaRequerimiento.estado;
            prioridad.Text = consultaRequerimiento.prioridad;
            tipocaso.Text = consultaRequerimiento.tipocaso;
            usuario.Text = consultaRequerimiento.usuario;
        }

        private void ActualizarRequerimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

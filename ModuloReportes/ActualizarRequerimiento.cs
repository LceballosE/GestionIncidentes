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
        private void ConsultaUsuario()
        {
            try
            {
                string consulta = string.Format("select * from usuario");
                DataSet dataset = Utilidades.EjecutarBd(consulta);

                for (int fila = 0; fila < dataset.Tables[0].Rows.Count; fila++)
                {
                    listUsuario.Items.Insert(fila, dataset.Tables[0].Rows[fila]["UsuarioRed"].ToString());
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error, intente nuevamente" + error.Message);
                this.Close();
            }
        }
        private void ConsultaEstado()
        {
            try
            {
                string consulta = string.Format("select * from estado");
                DataSet dataset = Utilidades.EjecutarBd(consulta);

                for (int fila = 0; fila < dataset.Tables[0].Rows.Count; fila++)
                {
                    listEstado.Items.Insert(fila, dataset.Tables[0].Rows[fila]["nombre"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error, intente nuevamente" + error.Message);
                this.Close();
            }
        }
        private void ConsultaTipoCaso()
        {
            try
            {
                string consulta = string.Format("select * from tipocaso");
                DataSet dataset = Utilidades.EjecutarBd(consulta);

                for (int fila = 0; fila < dataset.Tables[0].Rows.Count; fila++)
                {
                    listTipoCaso.Items.Insert(fila, dataset.Tables[0].Rows[fila]["nombre"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error, intente nuevamente" + error.Message);
                this.Close();
            }
        }
        private void ConsultaPrioridad()
        {
            try
            {
                string consulta = string.Format("select * from prioridad");
                DataSet dataset = Utilidades.EjecutarBd(consulta);

                for (int fila = 0; fila < dataset.Tables[0].Rows.Count; fila++)
                {
                    listPrioridad.Items.Insert(fila, dataset.Tables[0].Rows[fila]["nombre"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error, intente nuevamente" + error.Message);
                this.Close();
            }
        }


        private void ActualizarRequerimiento_Load(object sender, EventArgs e)
        {
            cargarInformacion(consultaRequerimiento.idrequerimiento);
            ConsultaUsuario();
            ConsultaEstado();
            ConsultaTipoCaso();
            ConsultaTipoCaso();
            ConsultaPrioridad();
            listEstado.Text = consultaRequerimiento.estado;
            listPrioridad.Text = consultaRequerimiento.prioridad;
            listTipoCaso.Text = consultaRequerimiento.tipocaso;
            listUsuario.Text = consultaRequerimiento.usuario;
        }

        private void cargarInformacion(int idrequerimiento)
        {

            try
            {
                string consulta = string.Format("select * from requerimiento where id= {0}", consultaRequerimiento.idrequerimiento);
                DataSet dataset = Utilidades.EjecutarBd(consulta);
               

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error, intente nuevamente" + error.Message);
                this.Close();
            }
        }

        private void ActualizarRequerimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

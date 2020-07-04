using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;
namespace ModuloReportes
{
    public partial class NuevoRequerimiento : Form
    {
        public NuevoRequerimiento()
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


              /// <summary>
        /// metodo de carga inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NuevoRequerimiento_Load(object sender, EventArgs e)
        {
            ConsultaUsuario();
            ConsultaEstado();
            ConsultaTipoCaso();
            ConsultaTipoCaso();
            ConsultaPrioridad();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.validarformulario(this, errorProvider1) == false)
            {
                try
                {
                    SqlCommand comando = new SqlCommand("dbo.CrearRequerimiento");
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@descripcion", parrDescripcion.Text);
                    comando.Parameters.AddWithValue("@fechaingreso", Convert.ToDateTime(dateFechaIngreso.Value.Date.ToString("dd-MM-yyyy"))); 
                    comando.Parameters.AddWithValue("@idusuario", listUsuario.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@idtipocaso",listTipoCaso.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@idestado", listEstado.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@idprioridad", listPrioridad.SelectedIndex + 1);

                    Utilidades.EjecutarSP(comando);

                    MessageBox.Show("Se ha guardado la informacion correctamente, El usuario ha sido creado");
                    this.Hide();
                    guardado = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message);                    
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            listEstado.Text = "Seleccione ...";
            listPrioridad.Text = "Seleccione ...";
            listTipoCaso.Text = "Seleccione ...";
            listUsuario.Text = "Seleccione ...";
            parrDescripcion.Text = Text;
            dateFechaIngreso.Refresh();
        }
    }
}

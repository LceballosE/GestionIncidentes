using MiLibreria;
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

namespace ModuloReportes
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        public static bool guardado= false;
        /// <summary>
        /// metodos de consulta general
        /// </summary>
        private void ConsultaEmpresa()
        {
            try
            {
                string consulta = string.Format("select * from empresa");
                DataSet dataset = Utilidades.EjecutarBd(consulta);

                for (int fila = 0; fila < dataset.Tables[0].Rows.Count; fila++)
                {
                    ListEmpresa.Items.Insert(fila, dataset.Tables[0].Rows[fila]["nombre"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error, intente nuevamente" + error.Message);
                this.Close();
            }
        }



        /// <summary>
        /// metodo borrar informacion ingresada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            TxtApellido.Text = "";
            TxtNombre.Text = "";
            TxtUsuarioRed.Text = "";
            ListEmpresa.Text = "Seleccione ...";
        }


        /// <summary>
        /// boton que guarda la informacion ingresada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.validarformulario(this, errorProvider1) == false)
            {
                try
                {

                    SqlCommand comando = new SqlCommand("dbo.CrearUsuario");
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                    comando.Parameters.AddWithValue("@apellido", TxtApellido.Text);
                    comando.Parameters.AddWithValue("@usuariored", TxtUsuarioRed.Text);
                    comando.Parameters.AddWithValue("@idempresa", ListEmpresa.SelectedIndex);

                    Utilidades.EjecutarSP(comando);
                    this.Hide();
                    guardado = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message);                  
                }
            }
        }

        public void EjecutarSP(string sp)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(" Error al ejecutar procedimiento almacenado ", ex);
            }
        }


        /// <summary>
        ///  metodo de carga inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            ConsultaEmpresa();
        }    
       
    }
}

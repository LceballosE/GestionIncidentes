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
    public partial class ActualizarAnalista : Form
    {
        public ActualizarAnalista()
        {
            InitializeComponent();
        }
        public static bool guardado = false;
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
                    SqlCommand comando = new SqlCommand("dbo.ModificarAnalista");
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id", consultaAnalista.idUser);
                    comando.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                    comando.Parameters.AddWithValue("@apellido", TxtApellido.Text);
                    comando.Parameters.AddWithValue("@usuariored", TxtUsuarioRed.Text);
                    comando.Parameters.AddWithValue("@contrasena", TxtContraseña.Text);

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



        /// <summary>
        ///  metodo de carga inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {
            TxtNombre.Text = consultaAnalista.nombre;
            TxtApellido.Text = consultaAnalista.Apellido;
            TxtUsuarioRed.Text = consultaAnalista.UsuarioRed;
            TxtContraseña.Text = consultaAnalista.Contraseña;
        }

        private void ActualizarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }
    }
}

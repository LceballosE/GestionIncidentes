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
    public partial class ConfirmarEliminar : Form
    {
        public ConfirmarEliminar()
        {
            InitializeComponent();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand comando = new SqlCommand("dbo.EliminarAnalista");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", consultaAnalista.idUser);


                Utilidades.EjecutarSP(comando);

                MessageBox.Show("Se ha guardado la informacion correctamente, El usuario ha sido eliminado");

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error" + error.Message);
            }

        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}

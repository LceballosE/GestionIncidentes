using MiLibreria;
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
    public partial class consultaUsuario : Consulta
    {
        public consultaUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metodo para buscar segun una palabra el nombre del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()) == false)
            {
                try
                {
                    string consulta = string.Format("select u.id,u.nombre,u.apellido,u.usuariored,e.nombre Empresa from usuario u join empresa e on e.id=u.id where u.nombre like ('%" + txtBuscar.Text.Trim() + "%') ");
                    DataSet dataset = Utilidades.EjecutarBd(consulta);
                    dataGrid.DataSource = dataset.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error);
                }
            }

        }

        private void consultaUsuario_Load(object sender, EventArgs e)
        {
            string consulta = string.Format("select u.id,u.nombre,u.apellido,u.usuariored,e.nombre Empresa from usuario u join empresa e on e.id=u.id");
            DataSet dataset = Utilidades.EjecutarBd(consulta);
            dataGrid.DataSource = dataset.Tables[0];
        }
    }
}

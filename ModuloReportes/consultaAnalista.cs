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
    public partial class consultaAnalista : Consulta
    {
        public static int idUser;
        public static string nombre;
        public static string Apellido;
        public static string UsuarioRed;
        public static string Contraseña;
        public consultaAnalista()
        {
            InitializeComponent();
        }


        /// <summary>
        /// metodo para buscar segun una palabra el nombre del Analista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()) == false)
            {
                try
                {
                    string consulta = string.Format("select * from analista where nombre like ('%" + txtBuscar.Text.Trim() + "%')");
                    DataSet dataset = Utilidades.EjecutarBd(consulta);
                    dataGrid.DataSource = dataset.Tables[0];
                    dataGrid.Columns.Remove("contraseña");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error);
                }
            }
        }

        /// <summary>
        /// carga la informacion inicial al formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultaAnalista_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = llenarDataGV("analista").Tables[0];
        }


        private void consultaAnalista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGrid.CurrentRow.Index;
            idUser = Convert.ToInt32(dataGrid.Rows[filaSeleccionada].Cells[0].Value);
            nombre = Convert.ToString(dataGrid.Rows[filaSeleccionada].Cells[1].Value);
            Apellido = Convert.ToString(dataGrid.Rows[filaSeleccionada].Cells[4].Value);
            UsuarioRed = Convert.ToString(dataGrid.Rows[filaSeleccionada].Cells[2].Value);
            Contraseña = Convert.ToString(dataGrid.Rows[filaSeleccionada].Cells[3].Value);
/// cambiar aqui
        
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class consultaRequerimiento : Consulta
    {
        public static int idrequerimiento;
        public static string usuario;
        public static string tipocaso;
        public static string estado;
        public static string prioridad;
        public static string descripcion;
        public consultaRequerimiento()
        {
            InitializeComponent();
        }


        /// <summary>
        /// llena el formulario con la informacion necesaria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultaRequerimiento_Load(object sender, EventArgs e)
        {
            string consulta = string.Format("SELECT r.Id,r.Descripcion,r.FechaIngreso,u.UsuarioRed usuario,tc.Nombre tipo_Caso, e.Nombre Estado,p.Nombre Prioridad from Requerimiento r join usuario u on r.IdUsuario = u.Id join TipoCaso tc on r.IdTipoCaso = tc.Id   join Estado e on r.IdEstado = e.Id     join Prioridad p on r.IdPrioridad = p.Id");
            DataSet dataset = Utilidades.EjecutarBd(consulta);
            dataGrid.DataSource = dataset.Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()) == false)
            {
                try
                {
                    string consulta = string.Format("SELECT r.Id,r.Descripcion,r.FechaIngreso,u.UsuarioRed usuario,tc.Nombre tipo_caso, e.Nombre,p.Nombre from Requerimiento r join usuario u on r.IdUsuario = u.Id join TipoCaso tc on r.IdTipoCaso = tc.Id   join Estado e on r.IdEstado = e.Id     join Prioridad p on r.IdPrioridad = p.Id where r.id like ('%" + txtBuscar.Text.Trim() + "%')");
                    DataSet dataset = Utilidades.EjecutarBd(consulta);
                    dataGrid.DataSource = dataset.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error);
                }
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGrid.CurrentRow.Index;
            idrequerimiento = Convert.ToInt32(dataGrid.Rows[filaSeleccionada].Cells[0].Value);
            descripcion = Convert.ToString(dataGrid.Rows[filaSeleccionada].Cells[1].Value);
            usuario = Convert.ToString(dataGrid.Rows[filaSeleccionada].Cells[3].Value);
            tipocaso = Convert.ToString(dataGrid.Rows[filaSeleccionada].Cells[4].Value);
            estado = Convert.ToString(dataGrid.Rows[filaSeleccionada].Cells[5].Value);
            prioridad = Convert.ToString(dataGrid.Rows[filaSeleccionada].Cells[6].Value);
            ActualizarRequerimiento requerimiento = new ActualizarRequerimiento();
            requerimiento.Show();
            
        }

    }
}

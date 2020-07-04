using MiLibreria;
using System;
using System.Collections;
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
    public partial class Graficas : Form
    {
        public Graficas()
        {
            InitializeComponent();
        }

        /////cargar dashboards de datos
        public void CantidadRequerimientosPorAnalista()
        {
            ArrayList estados = new ArrayList();
            ArrayList CANTIDAD = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=GestionIncidentesIG;Integrated Security=True");
            conexion.Open();

            try
            {
                SqlDataReader dr;
                SqlCommand comando = new SqlCommand("dbo.CantidadRequerimientosPorEstado", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    estados.Add(dr.GetString(1));
                    CANTIDAD.Add(dr.GetInt32(0));
                }
                ReqxEstado.Series[0].Points.DataBindXY(estados, CANTIDAD);
                dr.Close();
                conexion.Close();

            }
            catch (Exception e)
            {
                conexion.Close();
                MessageBox.Show("Ha ocurrido un Error al cambiar la contraseña. Intente nuevamente" + e);
            }
        }

        public void CantidadRequerimientosPorEstado()
        {
            ArrayList analistas = new ArrayList();
            ArrayList CANTIDAD = new ArrayList();
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=GestionIncidentesIG;Integrated Security=True");
            conexion.Open();

            try
            {
                SqlDataReader dr;
                SqlCommand comando = new SqlCommand("dbo.CantidadRequerimientosPorAnalista", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    analistas.Add(dr.GetString(1));
                    CANTIDAD.Add(dr.GetInt32(0));
                }
                reqXanalista.Series[0].Points.DataBindXY(analistas, CANTIDAD);
                dr.Close();
                conexion.Close();

            }
            catch (Exception e)
            {
                conexion.Close();
                MessageBox.Show("Ha ocurrido un Error al cambiar la contraseña. Intente nuevamente" + e);
            }
        }

        public void CantidadRequerimientosPorUsuario()
        {
            ArrayList analistas = new ArrayList();
            ArrayList CANTIDAD = new ArrayList();
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=GestionIncidentesIG;Integrated Security=True");
            conexion.Open();

            try
            {
                SqlDataReader dr;
                SqlCommand comando = new SqlCommand("dbo.CantidadRequerimientosPorUsuario", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    analistas.Add(dr.GetString(1));
                    CANTIDAD.Add(dr.GetInt32(0));
                }
                reqxusuario.Series[0].Points.DataBindXY(analistas, CANTIDAD);
                dr.Close();
                conexion.Close();

            }
            catch (Exception e)
            {
                conexion.Close();
                MessageBox.Show("Ha ocurrido un Error al cambiar la contraseña. Intente nuevamente" + e);
            }
        }

        public void cargainformacionetiquetas()
        {
            try
            {
                string Ingreso = string.Format("SELECT count(id) total FROM Requerimiento");
                DataSet dataSet = Utilidades.EjecutarBd(Ingreso);
                string totalreq = dataSet.Tables[0].Rows[0]["total"].ToString().Trim();
                LbTotalReq.Text = totalreq;

                Ingreso = string.Format("select count(id) total from Requerimiento where IdTipoCaso = 1");
                dataSet = Utilidades.EjecutarBd(Ingreso);
                string totalincidentes = dataSet.Tables[0].Rows[0]["total"].ToString().Trim();
                LbIncidentes.Text = totalincidentes;

                Ingreso = string.Format("select count(id) total from Requerimiento where IdPrioridad = 1");
                dataSet = Utilidades.EjecutarBd(Ingreso);
                string totalprioridad = dataSet.Tables[0].Rows[0]["total"].ToString().Trim();
                LbPrioridadAlta.Text = totalprioridad;

                Ingreso = string.Format("select count(id) total from usuario");
                dataSet = Utilidades.EjecutarBd(Ingreso);
                string totalanalista = dataSet.Tables[0].Rows[0]["total"].ToString().Trim();
                LbAnalistas.Text = totalanalista;

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un Error." );
            }
        }

        private void btnnueno_Click(object sender, EventArgs e)
        {
            Graficas_Load(sender,e);
        }

        private void Graficas_Load(object sender, EventArgs e)
        {
            CantidadRequerimientosPorAnalista();
            CantidadRequerimientosPorEstado();
            CantidadRequerimientosPorUsuario();
            cargainformacionetiquetas();
        }
    }
}

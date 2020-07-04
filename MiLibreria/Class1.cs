using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet EjecutarBd(string cmd)
        {
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=GestionIncidentesIG;Integrated Security=True");
            conexion.Open();

            DataSet dataset = new DataSet();
            SqlDataAdapter dataadapter = new SqlDataAdapter(cmd, conexion);
            dataadapter.Fill(dataset);

            conexion.Close();

            return dataset;

        }


        public static Boolean validarformulario(Control objeto, ErrorProvider errorProvider)
        {
            Boolean existeError = false;

            foreach (Control item in objeto.Controls)
            {
                if (item is Errotextbox)
                {
                    Errotextbox obj = (Errotextbox)item;

                    if (obj.validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            errorProvider.SetError(obj, "No puede estar vacío");
                            existeError = true;
                        }
                    }
                }
                if (item is ErrorComboBox)
                {
                    ErrorComboBox obj = (ErrorComboBox)item;

                    if (obj.validar == true)
                    {
                        if (obj.SelectedIndex == -1)
                        {
                            errorProvider.SetError(obj, "Debe seleccionar una opción");
                            existeError = true;
                        }
                    }
                }
            }
            return existeError;
        }

        public static void EjecutarSP(SqlCommand comando)
        {
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=GestionIncidentesIG;Integrated Security=True");

            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Los cambios se han guardador correctamente");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la operación" + e);
                conexion.Close();
            }

        }

       
    }
}

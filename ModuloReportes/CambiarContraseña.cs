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
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña()
        {
            InitializeComponent();
        }
               
        private void CambiarContraseña_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancelarPass_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void BtnAceptarPass_Click(object sender, EventArgs e)
        {
            string contraAnt = TxtPassAnt.Text;
            string contraNew = TxtPassNew.Text;
            string contraConfirm = TxtPassConfirm.Text;
            int usuario = Int32.Parse(Autenticacion.idusuario);

            if (contraAnt == Autenticacion.contraseñaUsuario)
            {
                if (contraNew == contraConfirm)
                {
                    try
                    {
                        SqlCommand comando = new SqlCommand("dbo.CambioContraseña");
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@passnew", TxtPassNew.Text);
                        comando.Parameters.AddWithValue("@idanalista", usuario);
                        Utilidades.EjecutarSP(comando);

                        Autenticacion login = new Autenticacion();
                        this.Hide();
                        administrador.ActiveForm.Hide();
                        login.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Ha ocurrido un Error al cambiar la contraseña. Intente nuevamente");
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña nueva y la confirmación no son iguales, por favor valide");
                    TxtPassNew.Text = "";
                    TxtPassConfirm.Text = "";
                    TxtPassNew.Focus();
                }
            }
            else
            {
                MessageBox.Show("La contraseña anterior no es correcta");
                TxtPassAnt.Text = "";
                TxtPassConfirm.Text = "";
                TxtPassNew.Text = "";
                TxtPassAnt.Focus();
            }
        }
    }
}

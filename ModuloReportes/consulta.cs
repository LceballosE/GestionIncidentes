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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        public DataSet llenarDataGV(string tabla)
        {

            string consulta = string.Format("SELECT * from " + tabla);
            DataSet dataset = Utilidades.EjecutarBd(consulta);
            

            return dataset;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}

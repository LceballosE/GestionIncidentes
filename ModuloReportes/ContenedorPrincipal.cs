using MiLibreria;
using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace ModuloReportes
{
    public partial class ContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
               
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void requerimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoRequerimiento nuevorequerimietno = new NuevoRequerimiento();
            nuevorequerimietno.MdiParent = this;
            nuevorequerimietno.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.MdiParent = this;
            nuevoUsuario.Show();
        }

        private void ContenedorPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void analistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaAnalista consultaanalista = new consultaAnalista();
            consultaanalista.MdiParent = this;
            consultaanalista.Show();
        }

        private void requerimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaRequerimiento consultarequerimiento = new consultaRequerimiento();
            consultarequerimiento.MdiParent = this;
            consultarequerimiento.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaUsuario consultausuario = new consultaUsuario();
            consultausuario.MdiParent = this;
            consultausuario.Show();
           
        }

        private void ContenedorPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                string consultaUsuario = string.Format("Select * FROM analista WHERE id ='{0}'", Autenticacion.idusuario);
                DataSet dataSet = Utilidades.EjecutarBd(consultaUsuario);
                lbUsuario.Text = dataSet.Tables[0].Rows[0]["nombre"].ToString().Trim() + "   " + dataSet.Tables[0].Rows[0]["apellido"].ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un Error por favor intente nuevamente.");
            }
         
        }

    }
}

using BaseMundial.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseMundial
{
    public partial class FormEstaPartidos : Form
    {
        public FormEstaPartidos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEstaPartidos_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {
            DataTable datos = EstadPartidoCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgEstadPartido.DataSource = datos.DefaultView;
            }
        }
    }
}

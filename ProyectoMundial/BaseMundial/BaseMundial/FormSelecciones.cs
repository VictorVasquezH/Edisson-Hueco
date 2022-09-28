using BaseMundial.Datos;
//using BaseMundial.Conexion;
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
using static System.Net.Mime.MediaTypeNames;

namespace BaseMundial
{
    public partial class FormSelecciones : Form
    {
        public FormSelecciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void llenarGrid()
        {
            DataTable datos = SeleccionCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgSeleccion.DataSource = datos.DefaultView;
            }
        }

        private void FormSelecciones_Load(object sender, EventArgs e)
        {
            llenarGrid();

        }
    }
}

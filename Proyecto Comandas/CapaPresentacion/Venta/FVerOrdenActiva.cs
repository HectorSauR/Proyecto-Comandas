using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConexionBaseDeDatos;

namespace CapaPresentacion.Venta
{
    public partial class FVerOrdenActiva : Form
    {
        FMenuPrincipal frm = new FMenuPrincipal();
        CConexion conn = new CConexion();
        int numeroOrden;
        public FVerOrdenActiva(FMenuPrincipal form , int numord)
        {
            InitializeComponent();
            frm = form;
            numeroOrden = numord;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void FVerOrdenActiva_Load(object sender, EventArgs e)
        {
            List<CParametros> ListP = new List<CParametros>();

            ListP.Add(new CParametros("@idVenta", numeroOrden));

            dgv_alimentos.DataSource = conn.Listado("verVentaAlimentos", ListP);
            dgv_orden_bebidas.DataSource = conn.Listado("verVentaBebidas", ListP);
        }
    }
}

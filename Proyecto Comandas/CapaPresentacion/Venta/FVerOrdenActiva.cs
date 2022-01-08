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
        public FVerOrdenActiva(FMenuPrincipal form)
        {
            InitializeComponent();
            frm = form;
            //numeroOrden = numord;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var id = lbl_orden.Text;
            var total = lblTotal.Text;
            try
            {
                id = id.Substring(id.IndexOf("#") + 1);
                total = total.Substring(1);
                frm.ejecutarOtroForm(int.Parse(id), float.Parse(total));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FVerOrdenActiva_Load(object sender, EventArgs e)
        {
            
        }

        private void FVerOrdenActiva_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
        }
    }
}

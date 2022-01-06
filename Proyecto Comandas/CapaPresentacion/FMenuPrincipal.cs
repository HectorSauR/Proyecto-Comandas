using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Bebida;
using CapaPresentacion.Platillo;
using CapaConexionBaseDeDatos;

namespace CapaPresentacion
{
    public partial class FMenuPrincipal : Form
    {
        CConexion conn = new CConexion();
        int numeroOrden;
        public FMenuPrincipal()
        {
            InitializeComponent();
        }
                                                        
        private void lbl_platillo_DoubleClick(object sender, EventArgs e)
        {
            FRegPlatillo frm = new FRegPlatillo(this);
            frm.Show();
        }

        private void lbl_bebida_DoubleClick(object sender, EventArgs e)
        {
            FRegBebida frm = new FRegBebida(this);
            frm.Show();
        }

        private void FMenuPrincipal_Load(object sender, EventArgs e)
        {
            actualizarDGV();
            actualizarNumOrden();
            //MessageBox.Show(obtenerID(2).ToString());
        }

        public int obtenerID(int tipo)
        {
            List<CParametros> listp = new List<CParametros>();
            listp.Add(new CParametros("@id", SqlDbType.Int, 100));
            try
            {
                if(tipo == 1)
                {
                    conn.EjectuarPA("verIDOrdenAlimentos", listp);
                    return int.Parse(listp[0].Val.ToString());
                }
                else
                {
                    conn.EjectuarPA("verIDOrdenBebidas", listp);
                    return int.Parse(listp[0].Val.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("No se selecciono ningún tipo");
            return 0;
        }
        public void actualizarDGV()
        {
            dgv_platillo.DataSource = conn.Listado("verPlatillos", null);
            dgv_bebida.DataSource = conn.Listado("verBebidas", null);
            dgv_platillos_activos.DataSource = conn.Listado("verVentasActivas", null);
        }

        public void actualizarVenta()
        {
            dgv_alimentos.DataSource = conn.Listado("verVentaPlatillos", null);
        }

        public void actualizarNumOrden()
        {
            List<CParametros> ListP = new List<CParametros>();

            ListP.Add(new CParametros("@id", SqlDbType.VarChar, 100));

            conn.EjectuarPA("obtenerIDVenta",ListP);

            numeroOrden = int.Parse(ListP[0].Val.ToString());

            lblNumeroVenta.Text = "#"+numeroOrden.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            List<CParametros> ListP = new List<CParametros>();

            ListP.Add(new CParametros("@id", numeroOrden));

            try
            {
                conn.EjectuarPA("verificarVenta", ListP);

                ListP.Add(new CParametros("@msg", SqlDbType.VarChar, 100));

                conn.EjectuarPA("registrarVenta", ListP);

                MessageBox.Show(ListP[0].Val.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            actualizarNumOrden();

        }

        private void dgv_platillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp = dgv_platillo.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp = temp.Substring(0, temp.IndexOf("."));
            
            int idPlatillo = int.Parse(temp);
            int cantidad = 1;

            if (txtCantidad.Text != "")
            {
                cantidad = int.Parse(txtCantidad.Text);
                txtCantidad.Clear();
            }

            List<CParametros> ListP = new List<CParametros>();

            ListP.Add(new CParametros("idOrden", numeroOrden));
            ListP.Add(new CParametros("idPlatillo", idPlatillo));
            ListP.Add(new CParametros("cantidad", cantidad));

            try
            {
                conn.EjectuarPA("registrarOrdenAlimento", ListP);

                ListP.Clear();
                ListP.Add(new CParametros("@idVenta", numeroOrden));

                dgv_alimentos.DataSource = conn.Listado("verVentaAlimentos", ListP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblNumeroVenta_Click(object sender, EventArgs e)
        {

        }

        private void lbl_orden_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgv_bebida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp = dgv_bebida.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp = temp.Substring(0, temp.IndexOf("."));

            int idBebida = int.Parse(temp);
            int cantidad = 1;

            if (txtCantidad.Text != "")
            {
                cantidad = int.Parse(txtCantidad.Text);
                txtCantidad.Clear();
            }

            List<CParametros> ListP = new List<CParametros>();

            ListP.Add(new CParametros("idOrden", numeroOrden));
            ListP.Add(new CParametros("idBebida", idBebida));
            ListP.Add(new CParametros("cantidad", cantidad));
            try
            {
                conn.EjectuarPA("registrarOrdenBebida", ListP);

                ListP.Clear();
                ListP.Add(new CParametros("@idVenta", numeroOrden));

                dgv_orden_bebidas.DataSource = conn.Listado("verVentaBebidas", ListP);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

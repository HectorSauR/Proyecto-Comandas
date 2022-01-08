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
using CrearTicketVenta;
using CapaPresentacion.Venta;

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
            actualizarTotalCaja();
            //MessageBox.Show(obtenerFecha());
            //MessageBox.Show(obtenerID(2).ToString());
        }

        public int obtenerID(int tipo)
        {
            List<CParametros> listp = new List<CParametros>();
            listp.Add(new CParametros("@id", SqlDbType.Int, 100));
            try
            {
                if (tipo == 1)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("No se selecciono ningún tipo");
            return 0;
        }
        public void actualizarDGV()
        {
            try
            {
                dgv_platillo.DataSource = conn.Listado("verPlatillos", null);
                dgv_bebida.DataSource = conn.Listado("verBebidas", null);
                dgv_platillos_activos.DataSource = conn.Listado("verVentasActivas", null);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void actualizarVenta()
        {
            dgv_alimentos.DataSource = conn.Listado("verVentaPlatillos", null);
        }

        public void actualizarNumOrden()
        {
            List<CParametros> ListP = new List<CParametros>();

            ListP.Add(new CParametros("@id", SqlDbType.VarChar, 100));

            conn.EjectuarPA("obtenerIDVenta", ListP);

            numeroOrden = int.Parse(ListP[0].Val.ToString());

            lblNumeroVenta.Text = "#" + numeroOrden.ToString();
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

                //MessageBox.Show(ListP[0].Val.ToString());

                ListP.Clear();
                actualizarTotalCaja();
                DataTable dt = new DataTable();
                dgv_alimentos.DataSource = dt;
                dgv_orden_bebidas.DataSource = dt;

                actualizarNumOrden();
                actualizarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void actualizarTotalCaja()
        {
            List<CParametros> ListP = new List<CParametros>();

            ListP.Add(new CParametros("@total", SqlDbType.VarChar, 100));
            ListP.Add(new CParametros("@fecha", obtenerFecha()));

            conn.EjectuarPA("obtenerVentaDiaria", ListP);

            lbl_totalCaja.Text = "$" + ListP[0].Val.ToString();
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

            ListP.Add(new CParametros("@idOrden", numeroOrden));
            ListP.Add(new CParametros("@idPlatillo", idPlatillo));
            ListP.Add(new CParametros("@cantidad", cantidad));

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

            ListP.Add(new CParametros("@idOrden", numeroOrden));
            ListP.Add(new CParametros("@idBebida", idBebida));
            ListP.Add(new CParametros("@cantidad", cantidad));
            try
            {
                conn.EjectuarPA("registrarOrdenBebida", ListP);

                ListP.Clear();
                ListP.Add(new CParametros("@idVenta", numeroOrden));

                dgv_orden_bebidas.DataSource = conn.Listado("verVentaBebidas", ListP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_platillos_activos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp = dgv_platillos_activos.Rows[e.RowIndex].Cells[0].Value.ToString();
            string temp2 = dgv_platillos_activos.Rows[e.RowIndex].Cells[1].Value.ToString();

            int id = int.Parse(temp);
            float total = float.Parse(temp2);

            try
            {
                FVerOrdenActiva frm = new FVerOrdenActiva(this);

                List<CParametros> ListP = new List<CParametros>();

                ListP.Add(new CParametros("@idVenta", id));

                DataGridViewTextBoxColumn Col1 = new DataGridViewTextBoxColumn();
                Col1.HeaderText = "Nombre";
                DataGridViewTextBoxColumn Col2 = new DataGridViewTextBoxColumn();
                Col2.HeaderText = "Cantidad";
                DataGridViewTextBoxColumn Col3 = new DataGridViewTextBoxColumn();
                Col3.HeaderText = "PrecioVenta";
                DataGridViewTextBoxColumn Col4 = new DataGridViewTextBoxColumn();
                Col4.HeaderText = "Total";

                frm.dgv_orden.Columns.AddRange(new[] { Col1, Col2, Col3, Col4 });

                DataTable dt = conn.Listado("obtenerDatosAlimentosTicket", ListP);
                insertarLineasDGV(dt, frm.dgv_orden);
                dt = conn.Listado("obtenerDatosBebidasTicket", ListP);
                insertarLineasDGV(dt, frm.dgv_orden);

                frm.lblTotal.Text = "$" + total.ToString();
                frm.lbl_orden.Text = "Orden #" + id;
                frm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void ejecutarOtroForm(int id,float total)
        {

            List<CParametros> ListP = new List<CParametros>();

            ListP.Add(new CParametros("@id", id));

            conn.EjectuarPA("confirmarVenta", ListP);
            actualizarDGV();
            actualizarTotalCaja();
            generarTicket(id, total);
        }

        private void insertarLineasDGV(DataTable dt, DataGridView dgv)
        {
            foreach (DataRow dr in dt.Rows)
            {
                dgv.Rows.Add(dr.ItemArray);
            }
        }

        private void generarTicket(int idVenta,float total)
        {
            CrearTicket ticket = new CrearTicket();
            #region iniciar ticket
            ticket.TextoCentro("PROYECTO COMANDAS");
            ticket.lineasAsteriscos();
            ticket.EncabezadoVenta();
            #endregion
            
            List<CParametros> ListP = new List<CParametros>();

            ListP.Add(new CParametros("@idVenta", idVenta));

            DataTable dt = conn.Listado("obtenerDatosAlimentosTicket", ListP);
            insertarLineas(dt, ticket);

            dt = conn.Listado("obtenerDatosBebidasTicket",ListP);
            insertarLineas(dt, ticket);

            #region cerrar ticket
            ticket.lineasIgual();
            ticket.TextoIzquierda("Total a pagar = $" + total.ToString());
            ticket.lineasGuio();
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");

            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketeraS
            #endregion
        }

        private void insertarLineas(DataTable dt, CrearTicket ticket)
        {
            foreach(DataRow dr in dt.Rows)
            {
                var nombre = dr[0].ToString();
                var cantidad = int.Parse(dr[1].ToString());
                var precio = decimal.Parse(dr[2].ToString());
                var total = decimal.Parse(dr[3].ToString());

                precio = decimal.Round(precio, 2);
                total = decimal.Round(total, 2);

                ticket.AgregaArticulo(nombre,cantidad,precio,total);
            }
        }

        private void lbl_activas_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            List<CParametros> ListP = new List<CParametros>();
            string msg;

            ListP.Add(new CParametros("@ganancia", SqlDbType.VarChar, 100));
            ListP.Add(new CParametros("@fecha", obtenerFecha()));

            conn.EjectuarPA("verGanancias", ListP);
            

            msg = ListP[0].Val.ToString();

            MessageBox.Show("La ganancia diaria es de " + msg);
        }

        private void dgv_alimentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_orden_bebidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string obtenerFecha()
        {
            var DateAndTime = DateTime.Now;
            var Date = DateAndTime.Date.ToString("yyyy-MM-dd");
            return Date;
        }
    }
}

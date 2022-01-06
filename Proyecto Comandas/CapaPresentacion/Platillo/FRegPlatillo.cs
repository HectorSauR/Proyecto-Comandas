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
using CapaPresentacion;

namespace CapaPresentacion.Platillo
{
    public partial class FRegPlatillo : Form
    {
        FMenuPrincipal frm;
        CConexion conn = new CConexion();
        public FRegPlatillo(FMenuPrincipal form)
        {
            InitializeComponent();
            frm = form;
        }
        
        private void FRegPlatillo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.actualizarDGV();
            frm.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtCostoPreparacion.Text != "" && txtNombre.Text != "" && txtPrecioVenta.Text != "")
            {
                DialogResult result = MessageBox.Show("Los datos introducidos son los correctos?", "Advertencia", MessageBoxButtons.YesNo);
                if(result == DialogResult.No)
                {
                    return;
                }

                string msg;

                float costo = float.Parse(txtCostoPreparacion.Text);
                float venta = float.Parse(txtPrecioVenta.Text);

                if(costo > venta)
                {
                    MessageBox.Show("El costo de produccion no puede ser mayor al de venta", "Advertencia");
                    return;
                }

                List<CParametros> listp = new List<CParametros>();

                listp.Add(new CParametros("@nombre", txtNombre.Text));
                listp.Add(new CParametros("@costoPreparacion", costo));
                listp.Add(new CParametros("@precioVenta", venta));
                listp.Add(new CParametros("@msg", SqlDbType.VarChar ,100));
                try
                {
                    conn.EjectuarPA("registrarPlatillo", listp);
                    msg = listp[listp.Count - 1].Val.ToString();

                    MessageBox.Show(msg);

                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

            }
            else
            {
                MessageBox.Show("Porfavor introduce todos los espacios requeridos...");
            }
        }

        private void FRegPlatillo_Load(object sender, EventArgs e)
        {

        }
    }
}

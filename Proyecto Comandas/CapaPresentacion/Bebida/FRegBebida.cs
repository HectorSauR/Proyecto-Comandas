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

namespace CapaPresentacion.Bebida
{
    public partial class FRegBebida : Form
    {
        FMenuPrincipal frm;
        CConexion conn = new CConexion();
        public FRegBebida(FMenuPrincipal form)
        {
            InitializeComponent();
            frm = form;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCostoPreparacion.Text != "" && txtNombre.Text != "" && txtPrecioVenta.Text != "")
            {
                DialogResult result = MessageBox.Show("Los datos introducidos son los correctos?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                string msg;

                float costo = float.Parse(txtCostoPreparacion.Text);
                float venta = float.Parse(txtPrecioVenta.Text);

                if (costo > venta)
                {
                    MessageBox.Show("El costo de produccion no puede ser mayor al de venta", "Advertencia");
                    return;
                }

                List<CParametros> listp = new List<CParametros>();

                listp.Add(new CParametros("@nombre", txtNombre.Text));
                listp.Add(new CParametros("@costoPreparacion", costo));
                listp.Add(new CParametros("@precioVenta", venta));
                listp.Add(new CParametros("@msg", SqlDbType.VarChar, 100));
                try
                {
                    conn.EjectuarPA("registrarBebida", listp);
                    msg = listp[listp.Count - 1].Val.ToString();

                    MessageBox.Show(msg);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
            else
            {
                MessageBox.Show("Porfavor introduce todos los espacios requeridos...");
            }
        }

        private void FRegBebida_FormClosed(object sender, FormClosedEventArgs e)
        {

            frm.actualizarDGV();
            frm.Show();

        }

        private void FRegBebida_Load(object sender, EventArgs e)
        {
            refrescarPlatillos();
        }

        private void refrescarPlatillos()
        {
            dgv_platillos.DataSource = conn.Listado("verTodosBebidas", null);
            foreach (DataGridViewRow dr in dgv_platillos.Rows)
            {
                if (dr.Cells[1].Value.ToString() == "A")
                {
                    dr.DefaultCellStyle.ForeColor = Color.White;
                    dr.DefaultCellStyle.BackColor = Color.Green;
                    continue;
                }
                dr.DefaultCellStyle.ForeColor = Color.White;
                dr.DefaultCellStyle.BackColor = Color.Red;

            }
        }


        private void rbtn_agregar_CheckedChanged(object sender, EventArgs e)
        {
            lbl_nombre.Text = "Nombre";
            btnRegistrar.Text = "Agregar";
            btnRegistrar.Visible = true;
        }

        private void rbtn_modificar_CheckedChanged(object sender, EventArgs e)
        {
            lbl_nombre.Text = "ID";
            btnRegistrar.Text = "Modificar";
            MessageBox.Show("Porfavor introduce el nuevo costo y precio venta y selecciona la bebida a modificar");
            btnRegistrar.Visible = false;
        }

        private void rbtn_deshabilitar_CheckedChanged(object sender, EventArgs e)
        {
            txtCostoPreparacion.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecioVenta.Enabled = false;
            MessageBox.Show("Porfavor selecciona del listado derecho el bebida a desactivar");
            btnRegistrar.Visible = false;
        }

        private void rbtn_habilitar_CheckedChanged(object sender, EventArgs e)
        {
            txtCostoPreparacion.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecioVenta.Enabled = false;
            MessageBox.Show("Porfavor selecciona del listado derecho el bebida a activar");
            btnRegistrar.Visible = false;
        }

        private void dgv_platillos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CParametros> listp = new List<CParametros>();

            var temp = dgv_platillos.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp = temp.Substring(0, temp.IndexOf("."));

            if (rbtn_agregar.Checked)
            {
                return;
            }

            if (rbtn_modificar.Checked)
            {

                txtNombre.Text = temp;
                if (txtCostoPreparacion.Text == "" && txtPrecioVenta.Text == "")
                {
                    MessageBox.Show("Porfavor introduce los valores a modificar");
                    return;
                }
                listp.Add(new CParametros("@id", int.Parse(temp)));
                listp.Add(new CParametros("@costo", float.Parse(txtCostoPreparacion.Text)));
                listp.Add(new CParametros("@venta", float.Parse(txtPrecioVenta.Text)));

                conn.EjectuarPA("modificarBebida", listp);

            }

            if (rbtn_deshabilitar.Checked)
            {

                listp.Add(new CParametros("@id", int.Parse(temp)));
                listp.Add(new CParametros("@tipo", 0));

                conn.EjectuarPA("desactivarActivarbebida", listp);

                refrescarPlatillos();

            }

            if (rbtn_habilitar.Checked)
            {

                listp.Add(new CParametros("@id", int.Parse(temp)));
                listp.Add(new CParametros("@tipo", 1));

                conn.EjectuarPA("desactivarActivarbebida", listp);

                refrescarPlatillos();
            }
        }
    }
}

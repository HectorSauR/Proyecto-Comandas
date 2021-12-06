using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FMenuPrincipal : Form
    {
        public FMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FMenuPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido!");
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnComprimir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Compr = new frmComprimir();
            Compr.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form desc = new frmDescomprimir();
            desc.Show();
        }
    }
}

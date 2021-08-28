using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class reporte : Form
    {
        public reporte()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            txtnombre.Hide();
            rtbreporte.Hide();
            txtrepenv.Show();
            btnenviar.Hide();
            rtxtreporte.Hide();
        }
    }
}

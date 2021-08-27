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
    public partial class home : Form
    {
        static string getString(char[] arr)
        {
            string s = new string(arr);

            return s;
        }

        public home()
        {
            InitializeComponent();
            rtxtResults.Text = "Pedidos";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            rtxtResults.Text = (rtxtResults.Text + "\n\nNombre: " + txtnombre.Text + "\nEdad: ");
            if (edad15.Checked)
            {
                rtxtResults.Text = (rtxtResults.Text + "menos de 15");
            }
            if (edad17.Checked)
            {
                rtxtResults.Text = (rtxtResults.Text + "entre 15 y 17");
            }
            if (edad18.Checked)
            {
                rtxtResults.Text = (rtxtResults.Text + "mas de 18");
            }
            rtxtResults.Text = (rtxtResults.Text + "\nfecha: " + dtpfecha.Value);
        }

        private void edad15_CheckedChanged(object sender, EventArgs e)
        {
            if (((edad17.Checked == true) || (edad18.Checked == true)) && edad15.Checked == true)
            {
                edad17.Checked = false;
                edad18.Checked = false;
            }
        }

        private void edad17_CheckedChanged(object sender, EventArgs e)
        {
            if (((edad15.Checked == true) || (edad18.Checked == true)) && edad17.Checked == true)
            {
                edad15.Checked = false;
                edad18.Checked = false;
            }
        }

        private void edad18_CheckedChanged(object sender, EventArgs e)
        {
            if (((edad17.Checked == true) || (edad15.Checked == true)) && edad18.Checked == true)
            {
                edad17.Checked = false;
                edad15.Checked = false;
            }
        }
        Form reporte = new reporte();
        private void btnreportar_Click(object sender, EventArgs e)
        {
            reporte.Show();
        }
    }
}

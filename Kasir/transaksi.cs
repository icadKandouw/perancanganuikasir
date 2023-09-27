using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class transaksi : Form
    {
        public transaksi()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void add1_Click(object sender, EventArgs e)
        {
            cash cash = new cash();
            cash.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selesai1 selesai1 = new selesai1();
            selesai1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selesai1 selesai1 = new selesai1();
            selesai1.ShowDialog();
        }
    }
}

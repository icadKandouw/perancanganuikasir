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
    public partial class cash : Form
    {
        public cash()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            selesai1 selesai1 = new selesai1();
            selesai1.ShowDialog();
        }
    }
}

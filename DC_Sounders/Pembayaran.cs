using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC_Sounders
{
    public partial class Pembayaran : Form
    {
        public Pembayaran()
        {
            InitializeComponent();
        }

        private void PictBack_Click(object sender, EventArgs e)
        {
            MENU bck = new MENU();
            this.Hide();
            bck.ShowDialog();
            this.Close();

        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {

        }
    }
}

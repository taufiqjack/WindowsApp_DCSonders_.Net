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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void pemesananToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesanPaketSoundSysyetmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalPaket go = new RentalPaket();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                 MessageBox.Show("Apa anda yakin ingin logout?", "Logout", MessageBoxButtons.YesNo))
            {
                Login go = new Login();
                this.Hide();
                go.ShowDialog();
                this.Close();
            }
            
        }

        private void rentalSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalSound go = new RentalSound();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void rentalLightingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalLighting go = new RentalLighting();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void cekPemesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CekPemesanan go = new CekPemesanan();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void pembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pembayaran go = new Pembayaran();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MENU_Load(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void okeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

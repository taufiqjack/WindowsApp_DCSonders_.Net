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
    public partial class Menu_Admin : Form
    {
        public Menu_Admin()
        {
            InitializeComponent();
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

        private void Menu_Admin_Load(object sender, EventArgs e)
        {

        }

        private void pemesananCostumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListPemesan go = new ListPemesan();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }
    }
}

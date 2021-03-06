using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC_Sounders
{
    public partial class ListPemesan : Form
    {
        public ListPemesan()
        {
            InitializeComponent();
            view();
        }

        private void dataGridListPemesanan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridListPemesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            view();
        }
        void view()
        {
            admin lht = new admin();
            dataGridListPemesanan.DataSource = lht.view();

        }

        private void btnDelPict_Click(object sender, EventArgs e)
        {
            hapusData balik = new hapusData();
            this.Hide();
            balik.ShowDialog();
            this.Close();
        }

        private void btnPictBackReport_Click(object sender, EventArgs e)
        {
            Menu_Admin bck = new Menu_Admin();
            this.Hide();
            bck.ShowDialog();
            this.Close();
        }

        private void txBoxnama_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void ListPemesan_Load(object sender, EventArgs e)
        {

        }

        private void cmbBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

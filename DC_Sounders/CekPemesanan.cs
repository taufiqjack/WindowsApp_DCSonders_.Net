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
    public partial class CekPemesanan : Form
    {
        public CekPemesanan()
        {
            InitializeComponent();
        }

        private void dataGridCari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridCari.Visible = true;
        }

        private void boxCari_TextChanged(object sender, EventArgs e)
        {
            

            //if (boxCari.Text == "")
            //{
            //    admin obj = new admin();
            //    dataGridCari.DataSource = obj.view();
            //    dataGridCari.Visible = true;
            //}
            //else
            //{
            //    admin obj = new admin();
            //    dataGridCari.DataSource = obj.search(boxCari.Text);
            //    dataGridCari.Visible = true;
            //}
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (boxCari.Text == "")
            {
                admin obj = new admin();
                dataGridCari.DataSource = obj.view();
                dataGridCari.Visible = true;
                btnPictEdit.Visible = true;
                label2.Visible = true;
            }
            else
            {
                admin obj = new admin();
                dataGridCari.DataSource = obj.search(boxCari.Text);
                dataGridCari.Visible = true;
                btnPictEdit.Visible = true;
                label2.Visible = true;
            }
        }

        private void Pemesanan_Load(object sender, EventArgs e)
        {
      
        }

        private void btnBatalCek_Click(object sender, EventArgs e)
        {
            MENU go = new MENU();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void btnPictEdit_Click(object sender, EventArgs e)
        {
            btnPictEdit.Visible = true;

            editData go = new editData();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }
    }
}

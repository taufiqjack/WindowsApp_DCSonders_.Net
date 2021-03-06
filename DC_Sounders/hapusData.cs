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
    public partial class hapusData : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976");

        public hapusData()
        {
            InitializeComponent();
        }

        private void pictSave_Click(object sender, EventArgs e)
        {
            string noktpText = boxKtp.Text.ToString();
            string namaPmsnText = cmbBoxNama.Text.ToString();
            string emailText = boxEmail.Text.ToString();
            string tlpText = boxTelp.Text.ToString();
            string JnsRntalText = cmbJnisSound.Text.ToString();
            string almtText = boxAlmt.Text.ToString();
            string hargaText = boxHrg.Text.ToString();
            string TglText = boxDateTgl.Text.ToString();

            DialogResult rs = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Peringatan!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                string namaText = cmbBoxNama.SelectedItem.ToString();

                admin cre = new admin();
                cre.delete(namaText);
                MessageBox.Show("Pesanan anda berhasil dihapus");
                Menu_Admin balik = new Menu_Admin();
                this.Hide();
                balik.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Silahkan pilih Data yang akan dihapus");
            }
        }

        private void cmbBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pemesanan where Nama_Pemesan='" + cmbBoxNama.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                boxKtp.Text = dr["No_Ktp"].ToString();
                boxEmail.Text = dr["Email"].ToString();
                boxTelp.Text = dr["No_Hp"].ToString();
                cmbJnisSound.Text = dr["Rental"].ToString();
                boxAlmt.Text = dr["Alamat"].ToString();
                boxHrg.Text = dr["Harga"].ToString();
                //boxDateTgl. = dr["Tangal"].ToString();
            }
            con.Close();
        }

        private void hapusData_Load(object sender, EventArgs e)
        {
            boxKtp.Enabled = false;
            boxEmail.Enabled = false;
            boxTelp.Enabled = false;
            boxAlmt.Enabled = true;
            boxHrg.Enabled = false;
            boxKtp.Enabled = false;
            cmbJnisSound.Enabled = false;
            boxDateTgl.Enabled = false;

            cmbBoxNama.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pemesanan";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbBoxNama.Items.Add(dr["Nama_Pemesan"].ToString());
            }
            con.Close();
        }

        private void btnPictBack_Click(object sender, EventArgs e)
        {
            Menu_Admin balik = new Menu_Admin();
            this.Hide();
            balik.ShowDialog();
            this.Close();
        }
    }
}

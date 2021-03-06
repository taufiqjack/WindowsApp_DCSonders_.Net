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
    public partial class editData : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976");

        public editData()
        {
            InitializeComponent();
        }

        private void boxHrg_TextChanged(object sender, EventArgs e)
        {

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

        private void editData_Load(object sender, EventArgs e)
        {
            boxHrg.Enabled = false;
            cmbJnisSound.Enabled = false;

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

        private void cmbJnisSound_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hargaPaket();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Lighting where nama_lighting='" + cmbJnisSound.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                boxHrg.Text = dr["harga_lighting"].ToString();
            }
            con.Close();

            
        }

        private void boxDateTgl_ValueChanged(object sender, EventArgs e)
        {

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            string noktpText = boxKtp.Text.ToString();
            string namaPmsnText = cmbBoxNama.Text.ToString();
            string emailText = boxEmail.Text.ToString();
            string tlpText = boxTelp.Text.ToString();
            string JnsRntalText = cmbJnisSound.Text.ToString();
            string almtText = boxAlmt.Text.ToString();
            string hargaText =boxHrg.Text.ToString();
            string TglText = boxDateTgl.Text.ToString();



            string btn = pictSave.Name;


            admin create = new admin();

            create.update(noktpText, namaPmsnText, emailText, tlpText, JnsRntalText,almtText, hargaText, TglText);
            MessageBox.Show("Update Sukses!");
            CekPemesanan balik = new CekPemesanan();
            this.Hide();
            balik.ShowDialog();
            this.Close();

        }

        private void btnBatalSound_Click(object sender, EventArgs e)
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
                CekPemesanan balik = new CekPemesanan();
                this.Hide();
                balik.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Silahkan pilih Data yang akan dihapus");
            }
            
        }

        private void btnPictBack_Click(object sender, EventArgs e)
        {
            CekPemesanan balik = new CekPemesanan();
            this.Hide();
            balik.ShowDialog();
            this.Close();
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



            string btn = pictSave.Name;


            admin create = new admin();

            create.update(noktpText, namaPmsnText, emailText, tlpText, JnsRntalText, almtText, hargaText, TglText);
            MessageBox.Show("Update Sukses!");
            CekPemesanan balik = new CekPemesanan();
            this.Hide();
            balik.ShowDialog();
            this.Close();
        }

        private void boxKtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxKtp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ?
               false : true;
            if (boxKtp.Text.Length >= 16)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 16 karakter");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void boxTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ?
               false : true;
            if (boxTelp.Text.Length >= 15)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 12 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 12 karakter");
                    e.KeyChar = (char)0;
                }
            }
        }
    }
}

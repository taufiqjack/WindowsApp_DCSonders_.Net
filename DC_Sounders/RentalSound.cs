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
    public partial class RentalSound : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976");
        public RentalSound()
        {
            InitializeComponent();
            boxDateTgl.Value = DateTime.Now;
        }

        private void RentalSound_Load(object sender, EventArgs e)
        {
            displayCombo();
            boxHrg.Enabled = false;
        }

        private void btnPsn_Click(object sender, EventArgs e)
        {
            try
            {


                string str = "";

                string ktp = boxKtp.Text.ToString();
                string nm = BoxNama.Text.ToString();
                string mail = boxEmail.Text.ToString();
                string hp = boxTelp.Text.ToString();
                string jns = cmbJnisSound.SelectedItem.ToString();
                string almt = boxAlmt.Text.ToString();
                string hrg = boxHrg.Text.ToString();
                string tgl = boxDateTgl.Text.ToString();


                string strKoneksi = "Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();

                if (btnPsn.Text == "Pesan") str = "insert into Pemesanan values(@Ktp, @Nm, @Mail, @Telp, @Jns, @Al, @Hrg, @Tgl)";

                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("Ktp", ktp));
                cmd.Parameters.Add(new SqlParameter("Nm", nm));
                cmd.Parameters.Add(new SqlParameter("Mail", mail));
                cmd.Parameters.Add(new SqlParameter("Telp", hp));
                cmd.Parameters.Add(new SqlParameter("Jns", jns));
                cmd.Parameters.Add(new SqlParameter("Al", almt));
                cmd.Parameters.Add(new SqlParameter("Hrg", hrg));
                cmd.Parameters.Add(new SqlParameter("Tgl", tgl));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data telah tersimpan", "Perhatian", MessageBoxButtons.OK);
                MENU go = new MENU();
                this.Hide();
                go.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void displayCombo()
        {
            cmbJnisSound.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Sound";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbJnisSound.Items.Add(dr["nama_Sound"].ToString());
            }
            con.Close();
        }

        private void cmbJnisSound_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Sound where nama_Sound='" + cmbJnisSound.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                boxHrg.Text = dr["harga_Sound"].ToString();
            }
            con.Close();
        }

        private void boxDateTgl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBatalSound_Click(object sender, EventArgs e)
        {
            MENU go = new MENU();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MENU go = new MENU();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void boxKtp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ?
               false : true;
            if (boxKtp.Text.Length >= 15)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 15 karakter");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void boxTelp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void boxKtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ?
               false : true;
            if (boxTelp.Text.Length >= 12)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 12 karakter");
                    e.KeyChar = (char)0;
                }
            }
        }
    }
}

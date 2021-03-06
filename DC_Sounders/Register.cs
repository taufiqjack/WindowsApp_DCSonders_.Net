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
    public partial class Register : Form
    {

        SqlConnection con = new SqlConnection();
        public Register()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976";
            
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login go = new Login();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        DataTable akun = new DataTable();
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "")
            {
                MessageBox.Show("username harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxUser.Focus();
                return;
            }
            if (txtBoxPass.Text == "")
            {
                MessageBox.Show("password harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxPass.Focus();
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976";
                con.Open();
                //string userid = txtBoxUser.Text;
                //string password = txtBoxPass.Text;
                SqlCommand cmd = new SqlCommand("insert into Register(username,password) values ('"+txtBoxUser.Text+"','"+txtBoxPass.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registrasi berhasil ");
                Login go = new Login();
                this.Hide();
                go.ShowDialog();
                this.Close();

            }
            catch (SqlException f)
            {
                Console.WriteLine(f.Message);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976");
            con.Open();

            {
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {
            txtBoxPass.PasswordChar = '*';
        }
    }
}

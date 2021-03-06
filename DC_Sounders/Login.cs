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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(BoxUser.Text == "")
            {
                MessageBox.Show("username harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BoxUser.Focus();
                return;
            }
            if (BoxPass.Text == "")
            {
                MessageBox.Show("password harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BoxPass.Focus();
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976";
                con.Open();
                string query = ("select * from Register where username = '" + BoxUser.Text.Trim() + "' and password = '" + BoxPass.Text.Trim() + "'");
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                string queryadmin = ("select * from LoginAdmin where username = '" + BoxUser.Text.Trim() + "' and password = '" + BoxPass.Text.Trim() + "'");
                SqlDataAdapter admin = new SqlDataAdapter(queryadmin, con);
                DataTable dataadmin = new DataTable();
                admin.Fill(dataadmin);

                if (dtbl.Rows.Count == 1)
                {
                    MessageBox.Show("Login Sukses");
                    MENU go = new MENU();
                    this.Hide();
                    go.ShowDialog();
                    this.Close();
                }
                else if (dataadmin.Rows.Count == 1)
                {
                    MessageBox.Show("Login Admin Sukses");
                    Menu_Admin go = new Menu_Admin();
                    this.Hide();
                    go.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }


            }
            catch (SqlException f)
            {
                Console.WriteLine(f.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register go = new Register();
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void BoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxPass_TextChanged(object sender, EventArgs e)
        {
            BoxPass.PasswordChar = '*';
        }
    }
}

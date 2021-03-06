using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Sounders
{
    class admin
    {
        string strKoneksi = "Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976";
        SqlConnection koneksi = new SqlConnection();

        public DataTable view()
        {
            DataTable tampil;
            string query = "Select * from Pemesanan";
            SqlDataAdapter data = new SqlDataAdapter(query, strKoneksi);
            tampil = new DataTable();
            data.Fill(tampil);

            return tampil;
        }

        public string delete(string delete)
        {
            string str = "";
            string nb = delete;
            string con = "Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976";

            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = con;
            koneksi.Open();

            str = "delete from Pemesanan where Nama_Pemesan=@nb";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("nb", nb));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            return str;
        }
        public DataTable search(string cari)
        {
            DataTable tampil;
            string query = "SELECT * FROM Pemesanan WHERE No_Ktp LIKE '%" + cari + "%' OR Nama_Pemesan LIKE '%" + cari + "%' OR Email LIKE '%" + cari + "%'";
            //where datediff(DAY, Tanggal,'2019-08-08')=0

            SqlDataAdapter data = new SqlDataAdapter(query, strKoneksi);
            tampil = new DataTable();
            data.Fill(tampil);

            return tampil;
        }
        public string update(string noktp, string nama, string email, string nohp, string rental, string alamat, string hrg, string tgl)
        {

            string ps = "sukses";

            string query = String.Format("update Pemesanan set Nama_Pemesan=@nm, Email=@email,No_Hp=@nohp,Rental=@rental, Alamat=@almt, Harga=@hrga, Tanggal=@Tgal where No_Ktp=@ktp");
            koneksi.ConnectionString = strKoneksi;
            SqlCommand cmd = new SqlCommand(query, koneksi);
            koneksi.Open();

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ktp", noktp));
            cmd.Parameters.Add(new SqlParameter("nm", nama));
            cmd.Parameters.Add(new SqlParameter("email", email));
            cmd.Parameters.Add(new SqlParameter("nohp", nohp));
            cmd.Parameters.Add(new SqlParameter("rental", rental));
            cmd.Parameters.Add(new SqlParameter("almt", alamat));
            cmd.Parameters.Add(new SqlParameter("hrga", hrg));
            cmd.Parameters.Add(new SqlParameter("tgal", tgl));



            cmd.ExecuteNonQuery();
            koneksi.Close();
            return ps;
        }

        public string deleteforadmin(string deleted)
        {
            string stri = "";
            string dl = deleted;
            string con = "Data Source=ASUS-X555U-TDC;Initial Catalog=Rental-sound;User ID=sa;Password=1976";

            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = con;
            koneksi.Open();

            stri = "delete from Pemesanan where Nama_Pemesan=@nb";
            SqlCommand cmd = new SqlCommand(stri, koneksi);
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.Add(new SqlParameter("nb", dl));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            return stri;
        }
    }
}

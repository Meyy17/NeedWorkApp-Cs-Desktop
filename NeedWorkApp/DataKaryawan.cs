using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NeedWorkApp
{
    public partial class DataKaryawan : Form
    {
        public DataKaryawan()
        {
            InitializeComponent();
            //ConnectionDb
            SqlConnection conn = new SqlConnection(@"Data Source=AQILSUKALOLI\SQLEXPRESS;Initial Catalog=DesktopDb;Integrated Security=True");
            //Make Query
            SqlDataAdapter query = new SqlDataAdapter("SELECT username, nama, alamat, tanggal_lahir, jenis_kelamin FROM Usertb", conn);
            DataTable userdata = new DataTable();
            query.Fill(userdata);
            tablekaryawan.DataSource = userdata;
        }

        private void DataKaryawan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard nav = new Dashboard();
            nav.Show();
            this.Hide();
        }
    }
}

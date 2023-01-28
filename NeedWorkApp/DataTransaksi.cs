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
    public partial class DataTransaksi : Form
    {
        public DataTransaksi()
        {
            InitializeComponent();
            //ConnectionDb
            SqlConnection conn = new SqlConnection(@"Data Source=AQILSUKALOLI\SQLEXPRESS;Initial Catalog=DesktopDb;Integrated Security=True");
            //Make Query
            SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM tb_transaksi", conn);
            DataTable datatransaksi = new DataTable();
            query.Fill(datatransaksi);
            tabletransaksi.DataSource = datatransaksi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard nav = new Dashboard();
            nav.Show();
            this.Hide();
        }

        private void tabletransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class Databarang : Form
    {
        public Databarang()
        {
            InitializeComponent();
            //ConnectionDb
            SqlConnection conn = new SqlConnection(@"Data Source=AQILSUKALOLI\SQLEXPRESS;Initial Catalog=DesktopDb;Integrated Security=True");
            //Make Query
            SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM tb_barang", conn);
            DataTable databarang = new DataTable();
            query.Fill(databarang);
            tablebarang.DataSource = databarang;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard nav = new Dashboard();
            nav.Show();
            this.Hide();
        }

        private void Databarang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Dashboard nav = new Dashboard();
            nav.Show();
            this.Hide();
        }

        private void tablebarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

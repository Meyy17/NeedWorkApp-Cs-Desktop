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

    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            //ConnectionDb
            SqlConnection conn = new SqlConnection(@"Data Source=AQILSUKALOLI\SQLEXPRESS;Initial Catalog=DesktopDb;Integrated Security=True");
            //GetEmailByUserInput
            String email = Form1.emailuser;
            //Make Query
            SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Usertb WHERE email = '"+email+"'", conn);
            DataTable userdata = new DataTable();
            query.Fill(userdata);

            //SetText
            welcome.Text = "Hallo 👋, Selamat Datang "+userdata.Rows[0]["nama"].ToString();
            nama.Text = userdata.Rows[0]["nama"].ToString();
            username.Text = userdata.Rows[0]["username"].ToString();
            temail.Text = userdata.Rows[0]["email"].ToString();
            alamat.Text = userdata.Rows[0]["alamat"].ToString();
            tlhir.Text = userdata.Rows[0]["tanggal_lahir"].ToString();
            jklmin.Text = userdata.Rows[0]["jenis_kelamin"].ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        { 

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Databarang nav = new Databarang();
            nav.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard f2 = new Dashboard();
            f2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataKaryawan nav = new DataKaryawan();
            nav.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTransaksi nav = new DataTransaksi();
            nav.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 nav = new Form1();
            nav.Show();
            this.Hide();
        }
    }
}

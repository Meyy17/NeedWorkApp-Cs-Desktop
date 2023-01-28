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
    public partial class Form1 : Form
    {
        public static string emailuser = "";
        SqlConnection conn = new SqlConnection(@"Data Source=AQILSUKALOLI\SQLEXPRESS;Initial Catalog=DesktopDb;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (tusername.Text == "")
            {
                MessageBox.Show("Kamu belum memasukkan Username/Email");
            }
            else if (tpw.Text == "")
            {
                MessageBox.Show("Kamu belum memasukkan Password");
            }

            else
            {
                SqlDataAdapter query = new SqlDataAdapter("select count (*) from Usertb where email = '" + tusername.Text + "' and password = '" + tpw.Text + "'", conn);
                DataTable response = new DataTable();
                query.Fill(response);
                if (response.Rows[0][0].ToString() == "1")
                {
                    emailuser = tusername.Text;
                    Dashboard nav = new Dashboard();
                    nav.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email Atau Password Salah!");
                }
            }
           



        }

        private void tusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

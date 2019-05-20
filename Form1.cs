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

namespace mini_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=rajesh;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            SqlCommand cmd = new SqlCommand("select count (*) as cnt from login_details where userid='"+ txtuserid.Text +"' and passwrd='"+txtpassword.Text+"'", conn);

            conn.Open();
            if (cmd.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("You are Granted");
                Selection s1 = new Selection();
                s1.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Acess Denied");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinguPage si = new SinguPage();
            si.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

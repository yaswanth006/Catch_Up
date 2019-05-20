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
    public partial class SinguPage : Form
    {
        public SinguPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=rajesh;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            SqlCommand cmd = new SqlCommand("insert into login_details values('" + txtuid.Text + "','" + txtpass.Text + "','" + txtname.Text + "','" + txteid.Text + "','" + txtpno.Text +  "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("sucessfully registered");

            Form1 s1 = new Form1();
            s1.Show();
            this.Hide();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MSearch : Form
    {
        public MSearch()
        {
            InitializeComponent();
        }

        private void MSearch_Load(object sender, EventArgs e)
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=rajesh;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            string cmd = "select * from uploader_details where locality='" + txtlocality.Text + "'";
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd, conn);
            conn.Close();
            DataSet ds = new DataSet();
            adp.Fill(ds, "uploader_details");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "uploader_details";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=rajesh;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            SqlCommand cmd = new SqlCommand("delete from login_details where userid='" + txtlocality.Text + "'",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

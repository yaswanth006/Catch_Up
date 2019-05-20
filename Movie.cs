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
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=rajesh;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            SqlCommand cmd = new SqlCommand("insert into uploader_details values('" + txtpno.Text + "','" + txtloc.Text + "','" + txttheatre.Text + "','" + txtmovie.Text + "'," + txtticket.Text + ","+txtamount.Text+")", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("sucessfully uploaded"); 
            Selection s1 = new Selection();
            s1.Show();
            this.Hide();
        }
    }
}

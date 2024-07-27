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

namespace wholesale_store_project
{
    public partial class Form12 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;


        public Form12()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you need to update this user?", "Update record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE customertable SET customername=@customername, address=@address, phonenumber=@phonenumber  WHERE customerid=@customerid", con);

                    cm.Parameters.AddWithValue("@customerid", txtcustomerid.Text);
                    cm.Parameters.AddWithValue("@customername", txtcustomername.Text);
                    cm.Parameters.AddWithValue("@address", txtaddress.Text);
                    cm.Parameters.AddWithValue("@phonenumber", txtphonenumber.Text);

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User updated successfully!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
        }
    }
}

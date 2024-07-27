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
    public partial class Form9 : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Form9()
        {
            InitializeComponent();
        }

        private void txtparentname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Are you sure you need to save this supplier?", "Saving record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO customertable(customerid,customername,address,phonenumber)VALUES(@customerid,@customername,@address,@phonenumber)", con);

                    cm.Parameters.AddWithValue("@customerid", txtcustomerid.Text);
                    cm.Parameters.AddWithValue("@customername", txtcustomername.Text);
                    cm.Parameters.AddWithValue("@address", txtaddress.Text);
                    cm.Parameters.AddWithValue("@phonenumber", txtphonenumber.Text);



                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User created successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
        }
    }
}

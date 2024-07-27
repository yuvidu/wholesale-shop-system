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
    public partial class Form13 : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;


        public Form13()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Are you sure you need to save this supplier?", "Saving record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO productdetailstable(productid,productname,priceperkg)VALUES(@productid,@productname,@priceperkg)", con);

                    cm.Parameters.AddWithValue("@productid", txtproductid.Text);
                    cm.Parameters.AddWithValue("@productname", txtproductname.Text);
                    cm.Parameters.AddWithValue("@priceperkg", txtpriceperkg.Text);
                  



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

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
        }
    }
}

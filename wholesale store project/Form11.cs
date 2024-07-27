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
using System.Net;

namespace wholesale_store_project
{


    public partial class Form11 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Form11()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you need to update this user?", "Update record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE producttable SET supplierid=@supplierid, date=@date, quantity=@quantity  WHERE productid=@productid", con);

                    cm.Parameters.AddWithValue("@productid", txtproductid.Text);
                    cm.Parameters.AddWithValue("@supplierid", txtsupplierid.Text);
                    cm.Parameters.AddWithValue("@date", txtdate.Text);
                    cm.Parameters.AddWithValue("@quantity", txtquantity.Text);

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

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
        }
    }
}

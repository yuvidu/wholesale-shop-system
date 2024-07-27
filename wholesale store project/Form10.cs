using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wholesale_store_project
{
    public partial class Form10 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;


        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Are you sure you need to update this user?", "Update record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE suppliertable SET suppliername=@suppliername, address=@address, homenumber=@homenumber, productid=@productid  WHERE supplierid=@supplierid", con);

                    cm.Parameters.AddWithValue("@supplierid", txtsupplierid.Text);
                    cm.Parameters.AddWithValue("@suppliername", txtsuppliername.Text);
                    cm.Parameters.AddWithValue("@address", address.Text);
                    cm.Parameters.AddWithValue("@homenumber", homenumber.Text);
                    cm.Parameters.AddWithValue("@productid", productid.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
        }
    }
}

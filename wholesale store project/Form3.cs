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
    public partial class Form3 : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;



        public Form3()
        {

            InitializeComponent();
            InitializeDataGridView();
            LoadProducts();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form3 = new Form8();
            form3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvuser.Columns[e.ColumnIndex].Name;
            if (colname == "editcol")
            {
                EditProduct(e.RowIndex);
            }
            else if (colname == "deletecol")
            {
                DeleteProduct(e.RowIndex);
            }

            LoadProducts();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void EditProduct(int rowIndex)
        {
            // Create an instance of the registration form for editing
            Form11 registerForm = new Form11();

            // Populate the registration form fields with selected product data
            registerForm.txtproductid.Text = dgvuser.Rows[rowIndex].Cells["productid"].Value.ToString();
            registerForm.txtsupplierid.Text = dgvuser.Rows[rowIndex].Cells["supplierid"].Value.ToString();
            registerForm.txtdate.Text = dgvuser.Rows[rowIndex].Cells["date"].Value.ToString();
            registerForm.txtquantity.Text = dgvuser.Rows[rowIndex].Cells["quantity"].Value.ToString();

            registerForm.txtproductid.Enabled = false; // Disable editing of the product ID
            registerForm.ShowDialog();
        }

        private void DeleteProduct(int rowIndex)
        {
            string productId = dgvuser.Rows[rowIndex].Cells["productid"].Value.ToString();
            if (MessageBox.Show($"Are you sure you want to delete the product with ID: {productId}?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cm = new SqlCommand("DELETE FROM producttable WHERE productid = @productid", con);
                    cm.Parameters.AddWithValue("@productid", productId);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void LoadProducts()
        {
            int i = 0;
            dgvuser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM producttable", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvuser.Rows.Add(i, dr["productid"].ToString(), dr["supplierid"].ToString(), dr["date"].ToString(), dr["quantity"].ToString());
            }
            dr.Close();
            con.Close();
        }



        private void InitializeDataGridView()
        {
            dgvuser.Columns.Clear();

            dgvuser.Columns.Add("No", "No");
            dgvuser.Columns.Add("productid", "Product ID");
            dgvuser.Columns.Add("supplierid", "Supplier ID");
            dgvuser.Columns.Add("date", "Date");
            dgvuser.Columns.Add("quantity", "Quantity");

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "editcol";
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            dgvuser.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "deletecol";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgvuser.Columns.Add(deleteColumn);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
        }

        private void stockbutton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void suppliersbutton_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            form3.Show();
        }

        private void customersbutton_Click(object sender, EventArgs e)
        {
            Form5 form3 = new Form5();
            form3.Show();
        }

        private void productbutton_Click(object sender, EventArgs e)
        {
            Form6 form3 = new Form6();
            form3.Show();
        }
    }
}

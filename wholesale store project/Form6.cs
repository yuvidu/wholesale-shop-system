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
    public partial class Form6 : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Form6()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadProducts();
        }

        private void productbutton_Click(object sender, EventArgs e)
        {
            Form6 form3 = new Form6();
            form3.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void dgvuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


        private void LoadProducts()
        {
            int i = 0;
            dgvuser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM productdetailstable", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvuser.Rows.Add(i, dr["productid"].ToString(), dr["productname"].ToString(), dr["priceperkg"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void InitializeDataGridView()
        {
            dgvuser.Columns.Clear();

            dgvuser.Columns.Add("No", "No");
            dgvuser.Columns.Add("productid", "Product ID");
            dgvuser.Columns.Add("productname", "Product Name");
            dgvuser.Columns.Add("priceperkg", "Price per KG");

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

        private void EditProduct(int rowIndex)
        {
            // Create an instance of the registration form for editing
            Form14 registerForm = new Form14();

            // Populate the registration form fields with selected product data
            registerForm.txtproductid.Text = dgvuser.Rows[rowIndex].Cells["productid"].Value.ToString();
            registerForm.txtproductname.Text = dgvuser.Rows[rowIndex].Cells["productname"].Value.ToString();
            registerForm.txtpriceperkg.Text = dgvuser.Rows[rowIndex].Cells["priceperkg"].Value.ToString();

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
                    cm = new SqlCommand("DELETE FROM productdetailstable WHERE productid = @productid", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 form3 = new Form13();
            form3.Show();
        }
    }
}

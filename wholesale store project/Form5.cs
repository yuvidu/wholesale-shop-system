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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Form5()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadCustomers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvuser.Columns[e.ColumnIndex].Name;
            if (colname == "editcol")
            {
                EditCustomer(e.RowIndex);
            }
            else if (colname == "deletecol")
            {
                DeleteCustomer(e.RowIndex);
            }

            LoadCustomers();

        }
        private void EditCustomer(int rowIndex)
        {
            // Create an instance of the registration form for editing
            Form12 registerForm = new Form12();

            // Populate the registration form fields with selected customer data
            registerForm.txtcustomerid.Text = dgvuser.Rows[rowIndex].Cells["customerid"].Value.ToString();
            registerForm.txtcustomername.Text = dgvuser.Rows[rowIndex].Cells["customername"].Value.ToString();
            registerForm.txtaddress.Text = dgvuser.Rows[rowIndex].Cells["address"].Value.ToString();
            registerForm.txtphonenumber.Text = dgvuser.Rows[rowIndex].Cells["phonenumber"].Value.ToString();

            registerForm.txtcustomerid.Enabled = false; // Disable editing of the customer ID
            registerForm.ShowDialog();
        }

        private void DeleteCustomer(int rowIndex)
        {
            string customerId = dgvuser.Rows[rowIndex].Cells["customerid"].Value.ToString();
            if (MessageBox.Show($"Are you sure you want to delete the customer with ID: {customerId}?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cm = new SqlCommand("DELETE FROM customertable WHERE customerid = @customerid", con);
                    cm.Parameters.AddWithValue("@customerid", customerId);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public void LoadCustomers()
        {
            int i = 0;
            dgvuser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM customertable", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvuser.Rows.Add(i, dr["customerid"].ToString(), dr["customername"].ToString(), dr["address"].ToString(), dr["phonenumber"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form3 = new Form9();
            form3.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            dgvuser.Columns.Clear();

            dgvuser.Columns.Add("No", "No");
            dgvuser.Columns.Add("customerid", "Customer ID");
            dgvuser.Columns.Add("customername", "Customer Name");
            dgvuser.Columns.Add("address", "Address");
            dgvuser.Columns.Add("phonenumber", "Phone Number");

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

        private void panel1_Paint(object sender, PaintEventArgs e)
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

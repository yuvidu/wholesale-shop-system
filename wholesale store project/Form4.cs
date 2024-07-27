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
    public partial class Form4 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Form4()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadSuppliers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form3 = new Form7();
            form3.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvuser.Columns[e.ColumnIndex].Name;
            if (colname == "editcol")
            {
                EditSupplier(e.RowIndex);
            }
            else if (colname == "deletecol")
            {
                DeleteSupplier(e.RowIndex);
            }

            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            int i = 0;
            dgvuser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM suppliertable", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvuser.Rows.Add(i, dr["supplierid"].ToString(), dr["suppliername"].ToString(), dr["address"].ToString(), dr["homenumber"].ToString(), dr["productid"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void InitializeDataGridView()
        {
            dgvuser.Columns.Clear();

            dgvuser.Columns.Add("No", "No");
            dgvuser.Columns.Add("supplierid", "Supplier ID");
            dgvuser.Columns.Add("suppliername", "Supplier Name");
            dgvuser.Columns.Add("address", "Address");
            dgvuser.Columns.Add("homenumber", "Home Number");
            dgvuser.Columns.Add("productid", "Product ID");

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

        private void EditSupplier(int rowIndex)
        {
            // Create an instance of the registration form for editing
            Form10 registerForm = new Form10();

            // Populate the registration form fields with selected supplier data
            registerForm.txtsupplierid.Text = dgvuser.Rows[rowIndex].Cells["supplierid"].Value.ToString();
            registerForm.txtsuppliername.Text = dgvuser.Rows[rowIndex].Cells["suppliername"].Value.ToString();
            registerForm.address.Text = dgvuser.Rows[rowIndex].Cells["address"].Value.ToString();
            registerForm.homenumber.Text = dgvuser.Rows[rowIndex].Cells["homenumber"].Value.ToString();
            registerForm.productid.Text = dgvuser.Rows[rowIndex].Cells["productid"].Value.ToString();

            registerForm.txtsupplierid.Enabled = false; // Disable editing of the supplier ID
            registerForm.ShowDialog();
        }

        private void DeleteSupplier(int rowIndex)
        {
            string supplierId = dgvuser.Rows[rowIndex].Cells["supplierid"].Value.ToString();
            if (MessageBox.Show($"Are you sure you want to delete the supplier with ID: {supplierId}?", "Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cm = new SqlCommand("DELETE FROM suppliertable WHERE supplierid = @supplierid", con);
                    cm.Parameters.AddWithValue("@supplierid", supplierId);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Supplier deleted successfully!");
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

        private void productbutton_Click(object sender, EventArgs e)
        {
            Form6 form3 = new Form6();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEUQ31G\SQLEXPRESS;Initial Catalog=wholesalestoredb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginuser.Clear();
            loginpassword.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            "Are you sure you want to exit the application?",
            "Exit Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                loginpassword.UseSystemPasswordChar = false;
            }
            else
            {
                loginpassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                loginpassword.UseSystemPasswordChar = false;
            }
            else
            {
                loginpassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM logintable WHERE username=@username AND password=@password", con);
                cm.Parameters.AddWithValue("@username", loginuser.Text);
                cm.Parameters.AddWithValue("@password", loginpassword.Text);
                con.Open();
                dr = cm.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    MessageBox.Show("Welcome " + dr["username"].ToString() + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 form3 = new Form2();
                    form3.Show();

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                con.Close();
            }
        }
    }
}

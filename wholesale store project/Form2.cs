using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wholesale_store_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form3 = new Form5();
            form3.Show();
        }

        private void stockbutton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void productbutton_Click(object sender, EventArgs e)
        {
            Form6 form3 = new Form6();
            form3.Show();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form3 = new Form1();
            form3.Show();
        }
    }
}

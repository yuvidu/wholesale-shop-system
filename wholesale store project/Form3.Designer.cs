namespace wholesale_store_project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productbutton = new System.Windows.Forms.Button();
            this.customersbutton = new System.Windows.Forms.Button();
            this.suppliersbutton = new System.Windows.Forms.Button();
            this.stockbutton = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.productbutton);
            this.panel1.Controls.Add(this.customersbutton);
            this.panel1.Controls.Add(this.suppliersbutton);
            this.panel1.Controls.Add(this.stockbutton);
            this.panel1.Controls.Add(this.homebutton);
            this.panel1.Location = new System.Drawing.Point(83, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 51);
            this.panel1.TabIndex = 1;
            // 
            // productbutton
            // 
            this.productbutton.BackColor = System.Drawing.Color.Black;
            this.productbutton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.productbutton.Location = new System.Drawing.Point(505, 9);
            this.productbutton.Name = "productbutton";
            this.productbutton.Size = new System.Drawing.Size(81, 34);
            this.productbutton.TabIndex = 4;
            this.productbutton.Text = "Product";
            this.productbutton.UseVisualStyleBackColor = false;
            this.productbutton.Click += new System.EventHandler(this.productbutton_Click);
            // 
            // customersbutton
            // 
            this.customersbutton.BackColor = System.Drawing.Color.Black;
            this.customersbutton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.customersbutton.Location = new System.Drawing.Point(391, 9);
            this.customersbutton.Name = "customersbutton";
            this.customersbutton.Size = new System.Drawing.Size(81, 34);
            this.customersbutton.TabIndex = 3;
            this.customersbutton.Text = "Customers";
            this.customersbutton.UseVisualStyleBackColor = false;
            this.customersbutton.Click += new System.EventHandler(this.customersbutton_Click);
            // 
            // suppliersbutton
            // 
            this.suppliersbutton.BackColor = System.Drawing.Color.Black;
            this.suppliersbutton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.suppliersbutton.Location = new System.Drawing.Point(279, 9);
            this.suppliersbutton.Name = "suppliersbutton";
            this.suppliersbutton.Size = new System.Drawing.Size(81, 34);
            this.suppliersbutton.TabIndex = 2;
            this.suppliersbutton.Text = "Suppliers";
            this.suppliersbutton.UseVisualStyleBackColor = false;
            this.suppliersbutton.Click += new System.EventHandler(this.suppliersbutton_Click);
            // 
            // stockbutton
            // 
            this.stockbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stockbutton.Location = new System.Drawing.Point(170, 9);
            this.stockbutton.Name = "stockbutton";
            this.stockbutton.Size = new System.Drawing.Size(81, 34);
            this.stockbutton.TabIndex = 1;
            this.stockbutton.Text = "Stock";
            this.stockbutton.UseVisualStyleBackColor = false;
            this.stockbutton.Click += new System.EventHandler(this.stockbutton_Click);
            // 
            // homebutton
            // 
            this.homebutton.BackColor = System.Drawing.Color.Black;
            this.homebutton.ForeColor = System.Drawing.SystemColors.Window;
            this.homebutton.Location = new System.Drawing.Point(57, 9);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(81, 34);
            this.homebutton.TabIndex = 0;
            this.homebutton.Text = "Home";
            this.homebutton.UseVisualStyleBackColor = false;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // dgvuser
            // 
            this.dgvuser.BackgroundColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvuser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvuser.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvuser.Location = new System.Drawing.Point(-3, 158);
            this.dgvuser.Name = "dgvuser";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvuser.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvuser.RowHeadersWidth = 51;
            this.dgvuser.Size = new System.Drawing.Size(800, 215);
            this.dgvuser.TabIndex = 2;
            this.dgvuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Supplier Id";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "edit";
            this.Column5.Image = ((System.Drawing.Image)(resources.GetObject("Column5.Image")));
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "delete";
            this.Column6.Image = ((System.Drawing.Image)(resources.GetObject("Column6.Image")));
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 441);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvuser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button productbutton;
        private System.Windows.Forms.Button customersbutton;
        private System.Windows.Forms.Button suppliersbutton;
        private System.Windows.Forms.Button stockbutton;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
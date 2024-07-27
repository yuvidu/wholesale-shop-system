namespace wholesale_store_project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productbutton = new System.Windows.Forms.Button();
            this.customersbutton = new System.Windows.Forms.Button();
            this.suppliersbutton = new System.Windows.Forms.Button();
            this.stockbutton = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.productbutton);
            this.panel1.Controls.Add(this.customersbutton);
            this.panel1.Controls.Add(this.suppliersbutton);
            this.panel1.Controls.Add(this.stockbutton);
            this.panel1.Controls.Add(this.homebutton);
            this.panel1.Location = new System.Drawing.Point(671, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 219);
            this.panel1.TabIndex = 0;
            // 
            // productbutton
            // 
            this.productbutton.BackColor = System.Drawing.Color.Black;
            this.productbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.productbutton.Location = new System.Drawing.Point(14, 173);
            this.productbutton.Name = "productbutton";
            this.productbutton.Size = new System.Drawing.Size(90, 30);
            this.productbutton.TabIndex = 4;
            this.productbutton.Text = "Product";
            this.productbutton.UseVisualStyleBackColor = false;
            this.productbutton.Click += new System.EventHandler(this.productbutton_Click);
            // 
            // customersbutton
            // 
            this.customersbutton.BackColor = System.Drawing.Color.Black;
            this.customersbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.customersbutton.Location = new System.Drawing.Point(14, 135);
            this.customersbutton.Name = "customersbutton";
            this.customersbutton.Size = new System.Drawing.Size(90, 30);
            this.customersbutton.TabIndex = 3;
            this.customersbutton.Text = "Customers";
            this.customersbutton.UseVisualStyleBackColor = false;
            this.customersbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // suppliersbutton
            // 
            this.suppliersbutton.BackColor = System.Drawing.Color.Black;
            this.suppliersbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.suppliersbutton.Location = new System.Drawing.Point(14, 95);
            this.suppliersbutton.Name = "suppliersbutton";
            this.suppliersbutton.Size = new System.Drawing.Size(90, 30);
            this.suppliersbutton.TabIndex = 2;
            this.suppliersbutton.Text = "Suppliers";
            this.suppliersbutton.UseVisualStyleBackColor = false;
            this.suppliersbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // stockbutton
            // 
            this.stockbutton.BackColor = System.Drawing.Color.Black;
            this.stockbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stockbutton.Location = new System.Drawing.Point(14, 54);
            this.stockbutton.Name = "stockbutton";
            this.stockbutton.Size = new System.Drawing.Size(90, 30);
            this.stockbutton.TabIndex = 1;
            this.stockbutton.Text = "Stock";
            this.stockbutton.UseVisualStyleBackColor = false;
            this.stockbutton.Click += new System.EventHandler(this.stockbutton_Click);
            // 
            // homebutton
            // 
            this.homebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homebutton.Location = new System.Drawing.Point(14, 13);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(90, 30);
            this.homebutton.TabIndex = 0;
            this.homebutton.Text = "Home";
            this.homebutton.UseVisualStyleBackColor = false;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 451);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}
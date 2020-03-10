namespace Login_Signup
{
    partial class nav
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
            this.newsaleButton = new System.Windows.Forms.Button();
            this.vi = new System.Windows.Forms.Button();
            this.addproductButton = new System.Windows.Forms.Button();
            this.viewproductsButton = new System.Windows.Forms.Button();
            this.updateempButton = new System.Windows.Forms.Button();
            this.viewempButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newsaleButton
            // 
            this.newsaleButton.BackColor = System.Drawing.Color.Teal;
            this.newsaleButton.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsaleButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.newsaleButton.Location = new System.Drawing.Point(431, 226);
            this.newsaleButton.Name = "newsaleButton";
            this.newsaleButton.Size = new System.Drawing.Size(261, 77);
            this.newsaleButton.TabIndex = 0;
            this.newsaleButton.Text = "Start new sale";
            this.newsaleButton.UseVisualStyleBackColor = false;
            this.newsaleButton.Click += new System.EventHandler(this.newsaleButton_Click);
            this.newsaleButton.MouseEnter += new System.EventHandler(this.newsaleButton_MouseEnter);
            this.newsaleButton.MouseLeave += new System.EventHandler(this.newsaleButton_MouseLeave);
            // 
            // vi
            // 
            this.vi.BackColor = System.Drawing.Color.Teal;
            this.vi.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vi.ForeColor = System.Drawing.Color.AliceBlue;
            this.vi.Location = new System.Drawing.Point(698, 226);
            this.vi.Name = "vi";
            this.vi.Size = new System.Drawing.Size(273, 77);
            this.vi.TabIndex = 1;
            this.vi.Text = "View all Departments";
            this.vi.UseVisualStyleBackColor = false;
            // 
            // addproductButton
            // 
            this.addproductButton.BackColor = System.Drawing.Color.Tomato;
            this.addproductButton.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproductButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.addproductButton.Location = new System.Drawing.Point(698, 320);
            this.addproductButton.Name = "addproductButton";
            this.addproductButton.Size = new System.Drawing.Size(273, 77);
            this.addproductButton.TabIndex = 3;
            this.addproductButton.Text = "Add/Update Product";
            this.addproductButton.UseVisualStyleBackColor = false;
            this.addproductButton.Click += new System.EventHandler(this.addproductButton_Click);
            // 
            // viewproductsButton
            // 
            this.viewproductsButton.BackColor = System.Drawing.Color.Tomato;
            this.viewproductsButton.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewproductsButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.viewproductsButton.Location = new System.Drawing.Point(431, 320);
            this.viewproductsButton.Name = "viewproductsButton";
            this.viewproductsButton.Size = new System.Drawing.Size(261, 77);
            this.viewproductsButton.TabIndex = 2;
            this.viewproductsButton.Text = "View All Products";
            this.viewproductsButton.UseVisualStyleBackColor = false;
            this.viewproductsButton.Click += new System.EventHandler(this.viewproductsButton_Click);
            // 
            // updateempButton
            // 
            this.updateempButton.BackColor = System.Drawing.Color.MistyRose;
            this.updateempButton.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateempButton.ForeColor = System.Drawing.Color.Black;
            this.updateempButton.Location = new System.Drawing.Point(698, 414);
            this.updateempButton.Name = "updateempButton";
            this.updateempButton.Size = new System.Drawing.Size(273, 77);
            this.updateempButton.TabIndex = 5;
            this.updateempButton.Text = "Add/Update Employees";
            this.updateempButton.UseVisualStyleBackColor = false;
            // 
            // viewempButton
            // 
            this.viewempButton.BackColor = System.Drawing.Color.MistyRose;
            this.viewempButton.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewempButton.ForeColor = System.Drawing.Color.Black;
            this.viewempButton.Location = new System.Drawing.Point(431, 414);
            this.viewempButton.Name = "viewempButton";
            this.viewempButton.Size = new System.Drawing.Size(261, 77);
            this.viewempButton.TabIndex = 4;
            this.viewempButton.Text = "View all Employees";
            this.viewempButton.UseVisualStyleBackColor = false;
            this.viewempButton.Click += new System.EventHandler(this.viewempButton_Click);
            // 
            // nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.backrutgjh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.updateempButton);
            this.Controls.Add(this.viewempButton);
            this.Controls.Add(this.addproductButton);
            this.Controls.Add(this.viewproductsButton);
            this.Controls.Add(this.vi);
            this.Controls.Add(this.newsaleButton);
            this.Name = "nav";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newsaleButton;
        private System.Windows.Forms.Button vi;
        private System.Windows.Forms.Button addproductButton;
        private System.Windows.Forms.Button viewproductsButton;
        private System.Windows.Forms.Button updateempButton;
        private System.Windows.Forms.Button viewempButton;
    }
}
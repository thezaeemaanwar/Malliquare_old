namespace Login_Signup
{
    partial class newsale
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
            this.menuButton = new System.Windows.Forms.Button();
            this.pid2Field = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pid2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.billField = new System.Windows.Forms.TextBox();
            this.qty2Field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.retField = new System.Windows.Forms.TextBox();
            this.recField = new System.Windows.Forms.TextBox();
            this.nsaleButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Maroon;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.menuButton.Location = new System.Drawing.Point(13, 13);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 33);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pid2Field
            // 
            this.pid2Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid2Field.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pid2Field.Location = new System.Drawing.Point(394, 117);
            this.pid2Field.Name = "pid2Field";
            this.pid2Field.Size = new System.Drawing.Size(207, 23);
            this.pid2Field.TabIndex = 1;
            this.pid2Field.Text = "Enter product code here";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(792, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid2Col,
            this.pname2Col,
            this.gst2Col,
            this.price2Col,
            this.qty2Col});
            this.dataGridView1.Location = new System.Drawing.Point(361, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 308);
            this.dataGridView1.TabIndex = 3;
            // 
            // pid2Col
            // 
            this.pid2Col.HeaderText = "Product Code";
            this.pid2Col.Name = "pid2Col";
            // 
            // pname2Col
            // 
            this.pname2Col.HeaderText = "Product Name";
            this.pname2Col.Name = "pname2Col";
            // 
            // gst2Col
            // 
            this.gst2Col.HeaderText = "GST";
            this.gst2Col.Name = "gst2Col";
            // 
            // price2Col
            // 
            this.price2Col.HeaderText = "Sales Price";
            this.price2Col.Name = "price2Col";
            // 
            // qty2Col
            // 
            this.qty2Col.HeaderText = "Quantity";
            this.qty2Col.Name = "qty2Col";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(730, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // billField
            // 
            this.billField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.billField.Location = new System.Drawing.Point(801, 494);
            this.billField.Name = "billField";
            this.billField.Size = new System.Drawing.Size(100, 20);
            this.billField.TabIndex = 5;
            this.billField.Text = "00.00 Rs";
            this.billField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // qty2Field
            // 
            this.qty2Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty2Field.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.qty2Field.Location = new System.Drawing.Point(617, 117);
            this.qty2Field.Name = "qty2Field";
            this.qty2Field.Size = new System.Drawing.Size(169, 23);
            this.qty2Field.TabIndex = 6;
            this.qty2Field.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cash Returned";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(690, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cash Recieved";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // retField
            // 
            this.retField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.retField.Location = new System.Drawing.Point(801, 567);
            this.retField.Name = "retField";
            this.retField.Size = new System.Drawing.Size(100, 20);
            this.retField.TabIndex = 9;
            this.retField.Text = "00.00 Rs";
            // 
            // recField
            // 
            this.recField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.recField.Location = new System.Drawing.Point(801, 531);
            this.recField.Name = "recField";
            this.recField.Size = new System.Drawing.Size(100, 20);
            this.recField.TabIndex = 10;
            this.recField.Text = "00.00 Rs";
            // 
            // nsaleButton
            // 
            this.nsaleButton.BackColor = System.Drawing.Color.Maroon;
            this.nsaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsaleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nsaleButton.Location = new System.Drawing.Point(801, 598);
            this.nsaleButton.Name = "nsaleButton";
            this.nsaleButton.Size = new System.Drawing.Size(100, 35);
            this.nsaleButton.TabIndex = 11;
            this.nsaleButton.Text = "New Sale";
            this.nsaleButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(361, 598);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 35);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newsale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.F2pW4A;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nsaleButton);
            this.Controls.Add(this.recField);
            this.Controls.Add(this.retField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qty2Field);
            this.Controls.Add(this.billField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pid2Field);
            this.Controls.Add(this.menuButton);
            this.Name = "newsale";
            this.Text = "newsale";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.TextBox pid2Field;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty2Col;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billField;
        private System.Windows.Forms.TextBox qty2Field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox retField;
        private System.Windows.Forms.TextBox recField;
        private System.Windows.Forms.Button nsaleButton;
        private System.Windows.Forms.Button exitButton;
    }
}
namespace Login_Signup
{
    partial class products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchproductField = new System.Windows.Forms.TextBox();
            this.searchproductButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.pidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costpriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gstCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salepriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promonameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "NULL";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidCol,
            this.pnameCol,
            this.costpriceCol,
            this.gstCol,
            this.salepriceCol,
            this.promonameCol,
            this.promoCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchproductField
            // 
            resources.ApplyResources(this.searchproductField, "searchproductField");
            this.searchproductField.Name = "searchproductField";
            // 
            // searchproductButton
            // 
            this.searchproductButton.BackColor = System.Drawing.Color.Goldenrod;
            this.searchproductButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.searchproductButton, "searchproductButton");
            this.searchproductButton.Name = "searchproductButton";
            this.searchproductButton.UseVisualStyleBackColor = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.menuButton, "menuButton");
            this.menuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuButton.Name = "menuButton";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // pidCol
            // 
            resources.ApplyResources(this.pidCol, "pidCol");
            this.pidCol.Name = "pidCol";
            // 
            // pnameCol
            // 
            resources.ApplyResources(this.pnameCol, "pnameCol");
            this.pnameCol.Name = "pnameCol";
            // 
            // costpriceCol
            // 
            resources.ApplyResources(this.costpriceCol, "costpriceCol");
            this.costpriceCol.Name = "costpriceCol";
            // 
            // gstCol
            // 
            resources.ApplyResources(this.gstCol, "gstCol");
            this.gstCol.Name = "gstCol";
            // 
            // salepriceCol
            // 
            resources.ApplyResources(this.salepriceCol, "salepriceCol");
            this.salepriceCol.Name = "salepriceCol";
            // 
            // promonameCol
            // 
            resources.ApplyResources(this.promonameCol, "promonameCol");
            this.promonameCol.Name = "promonameCol";
            // 
            // promoCol
            // 
            resources.ApplyResources(this.promoCol, "promoCol");
            this.promoCol.Name = "promoCol";
            // 
            // products
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.Shop1;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.searchproductButton);
            this.Controls.Add(this.searchproductField);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchproductField;
        private System.Windows.Forms.Button searchproductButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn costpriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gstCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn salepriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn promonameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn promoCol;
    }
}
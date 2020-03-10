namespace Login_Signup
{
    partial class employees
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empTable = new System.Windows.Forms.DataGridView();
            this.eidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empsalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theShoppingMallDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theShoppingMallDataSet = new Login_Signup.TheShoppingMallDataSet();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // empTable
            // 
            this.empTable.AllowUserToOrderColumns = true;
            this.empTable.AutoGenerateColumns = false;
            this.empTable.BackgroundColor = System.Drawing.Color.Teal;
            this.empTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidCol,
            this.efnameCol,
            this.elnameCol,
            this.depCol,
            this.cityCol,
            this.dobCol,
            this.empsalCol});
            this.empTable.DataSource = this.theShoppingMallDataSetBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.NullValue = "NULL";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.empTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.empTable.Location = new System.Drawing.Point(297, 119);
            this.empTable.Name = "empTable";
            this.empTable.Size = new System.Drawing.Size(744, 476);
            this.empTable.TabIndex = 26;
            // 
            // eidCol
            // 
            this.eidCol.HeaderText = "Employee Id";
            this.eidCol.Name = "eidCol";
            // 
            // efnameCol
            // 
            this.efnameCol.HeaderText = "First Name";
            this.efnameCol.Name = "efnameCol";
            // 
            // elnameCol
            // 
            this.elnameCol.HeaderText = "Last Name";
            this.elnameCol.Name = "elnameCol";
            // 
            // depCol
            // 
            this.depCol.HeaderText = "Department";
            this.depCol.Name = "depCol";
            // 
            // cityCol
            // 
            this.cityCol.HeaderText = "City";
            this.cityCol.Name = "cityCol";
            // 
            // dobCol
            // 
            this.dobCol.HeaderText = "DOB";
            this.dobCol.Name = "dobCol";
            // 
            // empsalCol
            // 
            this.empsalCol.HeaderText = "Salary";
            this.empsalCol.Name = "empsalCol";
            // 
            // theShoppingMallDataSetBindingSource
            // 
            this.theShoppingMallDataSetBindingSource.DataSource = this.theShoppingMallDataSet;
            this.theShoppingMallDataSetBindingSource.Position = 0;
            // 
            // theShoppingMallDataSet
            // 
            this.theShoppingMallDataSet.DataSetName = "TheShoppingMallDataSet";
            this.theShoppingMallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Teal;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Location = new System.Drawing.Point(773, 64);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 32);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.MouseEnter += new System.EventHandler(this.searchButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.Color.MintCream;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(481, 67);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(286, 27);
            this.searchField.TabIndex = 28;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Teal;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuButton.Location = new System.Drawing.Point(13, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 32);
            this.menuButton.TabIndex = 30;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.set_of_simple_cute_backgrounds_vector_734486;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.empTable);
            this.Name = "employees";
            this.Text = "Employees in Mall";
            this.Load += new System.EventHandler(this.employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theShoppingMallDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView empTable;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.BindingSource theShoppingMallDataSetBindingSource;
        private TheShoppingMallDataSet theShoppingMallDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn efnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn elnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn depCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn empsalCol;
    }
}
namespace Login_Signup
{
    partial class signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empidField = new System.Windows.Forms.Label();
            this.firstnameField = new System.Windows.Forms.TextBox();
            this.lastnameField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.cnicField = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empidField2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dobField = new System.Windows.Forms.DateTimePicker();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.cpasswordField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.salaryField = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.departmentField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(142, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(337, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(151, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(337, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNIC no.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empidField
            // 
            this.empidField.AutoSize = true;
            this.empidField.BackColor = System.Drawing.Color.Transparent;
            this.empidField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empidField.ForeColor = System.Drawing.Color.Indigo;
            this.empidField.Location = new System.Drawing.Point(134, 127);
            this.empidField.Name = "empidField";
            this.empidField.Size = new System.Drawing.Size(95, 19);
            this.empidField.TabIndex = 4;
            this.empidField.Text = "Employee Id";
            this.empidField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.empidField.Click += new System.EventHandler(this.label5_Click);
            // 
            // firstnameField
            // 
            this.firstnameField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.firstnameField.Location = new System.Drawing.Point(85, 95);
            this.firstnameField.Name = "firstnameField";
            this.firstnameField.Size = new System.Drawing.Size(187, 20);
            this.firstnameField.TabIndex = 5;
            this.firstnameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastnameField
            // 
            this.lastnameField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lastnameField.Location = new System.Drawing.Point(278, 95);
            this.lastnameField.Name = "lastnameField";
            this.lastnameField.Size = new System.Drawing.Size(191, 20);
            this.lastnameField.TabIndex = 6;
            // 
            // emailField
            // 
            this.emailField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.emailField.Location = new System.Drawing.Point(86, 208);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(186, 20);
            this.emailField.TabIndex = 8;
            // 
            // cnicField
            // 
            this.cnicField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cnicField.Location = new System.Drawing.Point(278, 208);
            this.cnicField.Name = "cnicField";
            this.cnicField.Size = new System.Drawing.Size(190, 20);
            this.cnicField.TabIndex = 7;
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.Indigo;
            this.signupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.signupButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.signupButton.Location = new System.Drawing.Point(247, 344);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(56, 31);
            this.signupButton.TabIndex = 9;
            this.signupButton.Text = "SignUp";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // signin
            // 
            this.signin.AutoSize = true;
            this.signin.BackColor = System.Drawing.Color.Transparent;
            this.signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.LinkColor = System.Drawing.Color.Indigo;
            this.signin.Location = new System.Drawing.Point(320, 379);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(40, 13);
            this.signin.TabIndex = 11;
            this.signin.TabStop = true;
            this.signin.Text = "Sign In";
            this.signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signin_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Already have an account?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vivaldi", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(130, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "The Shopping Mall";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // empidField2
            // 
            this.empidField2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.empidField2.Location = new System.Drawing.Point(85, 149);
            this.empidField2.Name = "empidField2";
            this.empidField2.Size = new System.Drawing.Size(186, 20);
            this.empidField2.TabIndex = 13;
            this.empidField2.TextChanged += new System.EventHandler(this.empidField2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(325, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date of Birth";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dobField
            // 
            this.dobField.CalendarMonthBackground = System.Drawing.Color.BlanchedAlmond;
            this.dobField.CalendarTitleBackColor = System.Drawing.Color.BlanchedAlmond;
            this.dobField.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobField.Location = new System.Drawing.Point(278, 147);
            this.dobField.Name = "dobField";
            this.dobField.ShowUpDown = true;
            this.dobField.Size = new System.Drawing.Size(190, 20);
            this.dobField.TabIndex = 15;
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.passwordField.Location = new System.Drawing.Point(85, 261);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(186, 20);
            this.passwordField.TabIndex = 19;
            this.passwordField.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cpasswordField
            // 
            this.cpasswordField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cpasswordField.Location = new System.Drawing.Point(278, 261);
            this.cpasswordField.Name = "cpasswordField";
            this.cpasswordField.Size = new System.Drawing.Size(190, 20);
            this.cpasswordField.TabIndex = 18;
            this.cpasswordField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(314, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Confirm Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(121, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Create Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox4.Location = new System.Drawing.Point(279, 314);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 20);
            this.textBox4.TabIndex = 22;
            // 
            // salaryField
            // 
            this.salaryField.AutoSize = true;
            this.salaryField.BackColor = System.Drawing.Color.Transparent;
            this.salaryField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryField.ForeColor = System.Drawing.Color.Indigo;
            this.salaryField.Location = new System.Drawing.Point(346, 292);
            this.salaryField.Name = "salaryField";
            this.salaryField.Size = new System.Drawing.Size(51, 19);
            this.salaryField.TabIndex = 21;
            this.salaryField.Text = "Salary";
            this.salaryField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(122, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Department";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departmentField
            // 
            this.departmentField.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.departmentField.FormattingEnabled = true;
            this.departmentField.Items.AddRange(new object[] {
            "Management",
            "Sales",
            "Purchase",
            "Accounts"});
            this.departmentField.Location = new System.Drawing.Point(86, 315);
            this.departmentField.Name = "departmentField";
            this.departmentField.Size = new System.Drawing.Size(185, 21);
            this.departmentField.TabIndex = 23;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Signup.Properties.Resources.shop53;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 610);
            this.Controls.Add(this.departmentField);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.salaryField);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.cpasswordField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dobField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.empidField2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.cnicField);
            this.Controls.Add(this.lastnameField);
            this.Controls.Add(this.firstnameField);
            this.Controls.Add(this.empidField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signup";
            this.Text = "signup";
            this.Load += new System.EventHandler(this.signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label empidField;
        private System.Windows.Forms.TextBox firstnameField;
        private System.Windows.Forms.TextBox lastnameField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox cnicField;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.LinkLabel signin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empidField2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dobField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox cpasswordField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label salaryField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox departmentField;
    }
}
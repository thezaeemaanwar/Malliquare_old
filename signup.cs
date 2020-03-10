///*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Signup
{
    public partial class signup : Form

    {
        SqlConnection con = new SqlConnection("Data Source=ZaeemaAnwar;Initial Catalog=TheShoppingMall;Integrated Security=True");

        public signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            save_data_in_database();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void empidField2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {

        }
        private void save_data_in_database()
        {

           con.Open();

            string dep = departmentField.Text;

            if (string.Equals(dep, "Management"))
                dep = "MAN";
            else if (string.Equals(dep, "Accounts"))
                dep = "ACC";
            else if (string.Equals(dep, "Sales"))
                dep = "SAL";
            else if (string.Equals(dep, "Purchase"))
                dep = "PUR";


            int salary = int.Parse("30,000", NumberStyles.AllowThousands, new CultureInfo("en-au"));

            string insert_in_emp = "insert into Employees_data(employee_id, firstname, lastname, user_password, CNIC, email, DOB, department_id, salary) " +
                                    "values(@id, @fname, @lname , @pass, @cnic, @mail, @dob, @dep_id, @sal)";
            SqlCommand cmd = new SqlCommand(insert_in_emp, con);

            cmd.Parameters.AddWithValue("@id", empidField2.Text);
            cmd.Parameters.AddWithValue("@fname", firstnameField.Text);
            cmd.Parameters.AddWithValue("@lname", lastnameField.Text);
            cmd.Parameters.AddWithValue("@pass", passwordField.Text);
            cmd.Parameters.AddWithValue("@cnic", cnicField.Text);
            cmd.Parameters.AddWithValue("@mail", emailField.Text);
            cmd.Parameters.AddWithValue("@dob", dobField.Text);
            cmd.Parameters.AddWithValue("@dep_id", dep);
            cmd.Parameters.AddWithValue("@sal", salary);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Account has been successfully created");

            con.Close();


        }
        private void populate_data()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees_data");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset); 

            for (int i=0 ; i<dataset.Tables[0].Rows.Count ; i++)
            {
                String id = dataset.Tables[0].Rows[1].ItemArray[0].ToString();
                String fname = dataset.Tables[0].Rows[1].ItemArray[1].ToString();
                String lname = dataset.Tables[0].Rows[1].ItemArray[2].ToString();
                String pas = dataset.Tables[0].Rows[1].ItemArray[3].ToString();
                String cnic = dataset.Tables[0].Rows[1].ItemArray[4].ToString();
                String email = dataset.Tables[0].Rows[1].ItemArray[5].ToString();
                String dob = dataset.Tables[0].Rows[1].ItemArray[6].ToString();
                DataGridViewRow viewRow = new DataGridViewRow();
                //viewRow.CreateCells(empTable);

            }

            con.Close();
        }
    }
}

//*/
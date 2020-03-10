using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Signup
{
    public partial class nav : Form
    {
        public nav()
        {
            InitializeComponent();
        }

        private void viewempButton_Click(object sender, EventArgs e)
        {
            new employees().Show();
            this.Hide();
        }

        private void viewproductsButton_Click(object sender, EventArgs e)
        {
            new products().Show();
            this.Hide();
        }

        private void newsaleButton_Click(object sender, EventArgs e)
        {
            new newsale().Show();
            this.Hide();
        }

        private void addproductButton_Click(object sender, EventArgs e)
        {
            new addproduct().Show();
            this.Hide();
        }

        private void newsaleButton_MouseEnter(object sender, EventArgs e)
        {
            newsaleButton.BackColor = System.Drawing.Color.Azure;
            newsaleButton.ForeColor = System.Drawing.Color.Black;
        }

        private void newsaleButton_MouseLeave(object sender, EventArgs e)
        {
            newsaleButton.BackColor = System.Drawing.Color.Teal;
            newsaleButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

    }
}

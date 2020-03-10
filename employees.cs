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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void employees_Load(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            new nav().Show();
            this.Hide();
        }

        private void searchButton_MouseEnter(object sender, EventArgs e)
        {
            searchButton.BackColor = System.Drawing.Color.HotPink;
            searchButton.ForeColor = System.Drawing.Color.Black;
        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.BackColor = System.Drawing.Color.Teal;
            searchButton.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.HotPink;
            menuButton.ForeColor = System.Drawing.Color.Black;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.BackColor = System.Drawing.Color.Teal;
            menuButton.ForeColor = System.Drawing.Color.GhostWhite;
        }
    }
}

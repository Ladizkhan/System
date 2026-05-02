using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culinary_File_Management
{
    public partial class Aboutsystem : Form
    {
        public Aboutsystem()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            Recipe_Management frm = new Recipe_Management();
            frm.Show();
            this.Hide();
        }

        private void btnViewrecipe_Click(object sender, EventArgs e)
        {
            ViewRecipe frm = new ViewRecipe();
            frm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only for Admin", "Notify",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
           "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Login login = new Login();
                login.Show();
                this.Close();
            }
        }
    }
}

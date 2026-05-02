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
    public partial class Recipe_Management : Form
    {
        Dashboard _dbForm;
        public Recipe_Management(Dashboard frm = null)
        {
            InitializeComponent();
            _dbForm = frm;
        }

        


        private void Recipe_Management_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            Recipe_Management frm = new Recipe_Management();
            frm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only for Admin", "Notify",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

       

        private void btnSystem_Click(object sender, EventArgs e)
        {
            Aboutsystem frm = new Aboutsystem();
            frm.Show();
            this.Hide();
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

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            
            if (_dbForm != null)
            {
                _dbForm.Show();
                this.Close();
            }
            else
            {
                Dashboard frm = new Dashboard();
                frm.Show();
                this.Hide();
            }
        }

        private void btnViewRecipe_Click(object sender, EventArgs e)
        {
             ViewRecipe frm = new ViewRecipe();
            frm.Show();
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            string sql = "insert into tblAddrecipe ([Recipe Name], [Username], [Prep Time], [Cook Time], [Category], [Servings]) Values ('"
                          + txtRecipename.Text + "','"
                          + txtName.Text + "','"
                          + txtPreptime.Text + "','"
                          + txtCooktime.Text + "', '"
                          + cmbCategory.Text + "', '"
                          + cmbServings.Text + "')";

            Addrecipe dB = new Addrecipe();

            try
            {
                if (dB.Savecmd(sql) >= 1)
                {
                    
                    Dashboard dash = (Dashboard)Application.OpenForms["Dashboard"];
                    if (dash != null)
                    {
                        dash.OutData();
                    }

                    MessageBox.Show("Record has been successfully inserted to tblAddrecipe.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    if (_dbForm != null)
                    {
                        _dbForm.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

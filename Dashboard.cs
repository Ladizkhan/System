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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        
        public void OutData()
        {
            try
            {
                Addrecipe db = new Addrecipe();
                DataTable dt = db.SelectCmd("select * from tblAddrecipe");

                if (dt != null)
                {
                    dGridViewRecipe.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh Error: " + ex.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            OutData();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            
            Recipe_Management frm = new Recipe_Management(this);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dGridViewRecipe.CurrentRow != null && !dGridViewRecipe.CurrentRow.IsNewRow)
            {
                try
                {
                    
                    var ownerCell = dGridViewRecipe.CurrentRow.Cells[0].Value;
                    string recordOwner = ownerCell != null ? ownerCell.ToString() : "";

                    
                    string loggedInUser = GlobalClass.Username;
                    string loggedInRole = GlobalClass.UserRole;

                    
                    if (string.IsNullOrEmpty(loggedInUser) || string.IsNullOrEmpty(loggedInRole))
                    {
                        MessageBox.Show("Error: Session expired. Please login again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                    if (loggedInRole.ToLower() == "admin" || loggedInUser == recordOwner)
                    {
                        DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirm == DialogResult.Yes)
                        {
                            
                            var recipeCell = dGridViewRecipe.CurrentRow.Cells[1].Value;
                            string recipeName = recipeCell != null ? recipeCell.ToString() : "";

                            
                            string sql = $"DELETE FROM tblAddrecipe WHERE [Recipe Name] = '{recipeName}' AND Username = '{recordOwner}'";

                            Addrecipe db = new Addrecipe();
                            if (db.Savecmd(sql) >= 1)
                            {
                                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OutData(); 
                            }
                        }
                    }
                    else
                    {
                        
                        MessageBox.Show("Access Denied: You can only delete your own uploads.",
                            "Restriction", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid record to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void btnSystem_Click(object sender, EventArgs e)
        {
            Aboutsystem frm = new Aboutsystem();
            frm.Show();
            this.Hide();
        }
    }
}
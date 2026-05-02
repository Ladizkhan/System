using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culinary_File_Management
{
    public partial class AdminForm : Form
    {
        
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\System\dbLogin.mdf;Integrated Security=True";

        public AdminForm()
        {
            InitializeComponent();
        }

        
        private void RefreshData()
        {

            Login_Class db = new Login_Class();
            dGridViewAdmin.DataSource = db.selectCmd("select * from tblLogin");
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            RefreshData();

            
            dGridViewAdmin.ReadOnly = true;
            dGridViewAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridViewAdmin.AllowUserToAddRows = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dGridViewAdmin.CurrentRow != null && dGridViewAdmin.CurrentRow.Index >= 0)
            {
                
                string selectedUser = dGridViewAdmin.CurrentRow.Cells[0].Value.ToString();
                string selectedRole = dGridViewAdmin.CurrentRow.Cells[2].Value.ToString();

                // 2. ADMIN PROTECTION BASE SA ROLE
                // Hindi papayagan ang delete kung ang role ay "Admin"
                if (selectedRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("The Admin account cannot be deleted to maintain system access.",
                        "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // 3. Confirmation box bago mag-delete
                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete user: {selectedUser}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM tblLogin WHERE Username = @username";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@username", selectedUser);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        
                        MessageBox.Show($"User {selectedUser} successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        RefreshData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user record from the table first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Aboutsystem frm = new Aboutsystem();
            frm.Show();
            this.Hide();
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

        
        private void tblLoginBindingNavigatorSaveItem_Click(object sender, EventArgs e) { }
        private void dGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }
    }
}
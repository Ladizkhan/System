using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using Culinary_File_Management;


namespace Culinary_File_Management
{
    public partial class Login : Form
    {
        Login_Class db = new Login_Class();
        public Login()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUSER.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill in required fields.");
                return;
            }

            try
            {
                string query = "SELECT * FROM tblLogin WHERE Username = '" + txtUSER.Text + "' AND Password = '" + txtPassword.Text + "'";
                DataTable dtable = db.selectCmd(query);

                if (dtable.Rows.Count > 0)
                {
                    
                    GlobalClass.Username = dtable.Rows[0]["Username"].ToString();
                    GlobalClass.UserRole = dtable.Rows[0]["Role"].ToString();

                    
                    string role = GlobalClass.UserRole;

                    if (role == "Admin")
                    {
                        MessageBox.Show("Welcome Admin!", "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        AdminForm admin = new AdminForm();
                        admin.Show();
                    }
                    else if (role == "User")
                    {
                        MessageBox.Show("Welcome User!", "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        
                        Dashboard userform = new Dashboard();
                        userform.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register FRM = new Register();
            FRM.Show();
            this.Hide();
        }

        private void btnShowpass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {             
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }


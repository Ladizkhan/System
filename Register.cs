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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            string query = "INSERT INTO tblLogin (Username, Password, Role) VALUES (@user, @pass, 'User')";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register_Class db = new Register_Class();

            string query = "INSERT INTO tblLogin (Username, Password, Role) VALUES (@user, @pass, 'User')";

            SqlParameter[] paramsList = 
                {new SqlParameter("@user", txtUser.Text),
                 new SqlParameter("@pass", txtPass.Text)
                };

            if (db.ExecuteQuery(query, paramsList))
            {
                DialogResult result = MessageBox.Show("Welcome User! You are Registered",
              "Register Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {

                    Dashboard frm = new Dashboard();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Failed to register.");
            }
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
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culinary_File_Management
{
    internal class Addrecipe
    {
        DataTable dTable;
        SqlDataAdapter sqlDA;
        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        string conStr;

        public Addrecipe()
        {
            
            conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\System\dbAddrecipe.mdf;Integrated Security=True";
            sqlCon = new SqlConnection(conStr);
        }

        public int Savecmd(string sql)
        {
            
            try
            {
                
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                int result = cmd.ExecuteNonQuery(); 

                sqlCon.Close(); 
                return result;
            }
            catch (Exception ex)
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                throw ex;
            }
        }

        public DataTable SelectCmd(string sql)
        {
            try
            {
                dTable = new DataTable();
                
                sqlDA = new SqlDataAdapter(sql, conStr);
                sqlDA.Fill(dTable); 
                return dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Error: " + ex.Message);
                return null;
            }
        }
    }
}


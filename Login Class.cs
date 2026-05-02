using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culinary_File_Management
{
    internal class Login_Class
    {
        DataTable dTable;
        SqlDataAdapter sqlDA;
        SqlCommand sqlCmd;
        SqlConnection con;
        string conStr;

        public Login_Class()
        {
            conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\System\dbLogin.mdf;Integrated Security=True";
            con = new SqlConnection(conStr);
            
        }

        public int cudCmd(string sql)
        {
            sqlCmd = new SqlCommand(sql, con);
            return sqlCmd.ExecuteNonQuery();
        }

        public DataTable selectCmd(string sql)
        {
            dTable = new DataTable();
            sqlDA = new SqlDataAdapter(sql, conStr);
            sqlDA.Fill(dTable);
            sqlDA.Dispose();
            return dTable;
        }
    }
}

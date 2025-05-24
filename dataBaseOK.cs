using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace demo_proj
{
    internal class dataBaseOK
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BTLC503\SQLEXPRESS;Initial Catalog=otdel_kadrov;Integrated Security=True");

        public void openConn()
        {
            conn.Open();
        }
        public void closeConn()
        {
            conn.Close();
        }
        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}

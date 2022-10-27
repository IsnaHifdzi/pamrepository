using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1
using System.Data.SqlClient;
namespace app_kasir
{
    class koneksi
    {
        //2
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = " Data source=LAPTOP-BCV032MA;initial catalog=DB_AppKASIR;integrated security=true";
            return conn;
        }
    }
}

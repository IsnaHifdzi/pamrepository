using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Conneting();
        }
        public void Conneting()
        {
            using(
                SqlConnection con = new SqlConnection("data source = LAPTOP-BCV032MA; database = ProdiTI;"+ "user ID = sa; Password = 123456789")
            )
            {
                con.Open();
                Console.WriteLine("Kamu Berhasil Terhubung Ke Database!!! :)");
                Console.Read();
            }

        }
    }

}

using System.Data.SqlClient;
using System;


namespace Koneksi
{
    class Program
    {
        static void Main(string[] args)
        {

            new Program().Connecting();
        }
        public void Connecting()
        {
            using (
                SqlConnection con = new SqlConnection("data source=LAPTOP-GK6AO77T;database=ProdiTI;User ID=sa;Password=Rey071201")
                )
            {
                con.Open();
                Console.WriteLine("Berhasil terhubung ke database!");
            }
        }
    }
}

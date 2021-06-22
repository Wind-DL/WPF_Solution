using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Data Source=127.0.0.1;User ID = root;Password = admin;Database=shengangdb;charset = utf8;pooling = true";
            MySqlConnection _connection = new MySqlConnection();
            _connection.ConnectionString = str;
            _connection.Open();
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}

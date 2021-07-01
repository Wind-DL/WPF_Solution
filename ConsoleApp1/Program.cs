using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Random random = new Random(Guid.NewGuid().GetHashCode());

    class Program
    {
        static void Main(string[] args)
        {

            Task.Run(async () =>
            {
                await Task.Delay(2000);
                Console.WriteLine("模拟某个耗时操作(耗时2秒)......");
            });

            Console.WriteLine("Main thread Complete");
            Console.ReadLine();
        }
    }
}

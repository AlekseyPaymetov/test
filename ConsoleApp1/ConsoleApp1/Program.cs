using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class User
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {

            User n = new User();
            Console.WriteLine(n.X);

        }
    }
}

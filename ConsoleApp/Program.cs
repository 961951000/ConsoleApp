using ConsoleApp.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DbHelper.Insert();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

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
            var db = new DbHelper();
            db.Insert();
            db.Delete();
            db.Update();
            var school = db.Select();
            Console.WriteLine(school);
            Console.ReadLine();
        }
    }
}

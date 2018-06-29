using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFullName = " Elizabeth Warren ";
            Console.WriteLine("Trim: '{0}'", myFullName.Trim());
            Console.WriteLine("ToUpper:  '{0}'", myFullName.Trim().ToUpper());
        }
    }
}

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
            var myFullName = "Elizabeth Warren ";
            Console.WriteLine("Trim: '{0}'", myFullName.Trim());
            Console.WriteLine("ToUpper:  '{0}'", myFullName.Trim().ToUpper());
            //break the string into first and last name
            //Use of string.IndexOf() and substring() methods
            var index = myFullName.IndexOf(' ');//returns the indexof upto a space 
            var firstName = myFullName.Substring(0, index);
            var lastName = myFullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);


        }
    }
}

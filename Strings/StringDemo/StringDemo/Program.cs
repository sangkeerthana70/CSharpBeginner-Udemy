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
            //split string using string.split() method
            var names = myFullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);
            //using replace method to replace a string 
            var replace = myFullName.Replace("Elizabeth", "ElizabethAnne");
            var replace1 = myFullName.Replace("a", "A");

            Console.WriteLine(replace);
            Console.WriteLine(replace1);
            /*
             * //String.IsNullOrEmpty method
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }*/

            //above method replaced by IsNullOrWhiteSpace method to make empty user input invalid.
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            //convert string to  numbers 
            var str = "25";
            var age = Convert.ToByte(str);//convert the str to a byte instead of Int32(which takes 4 bytes) since a byte can hold upto int-250
            Console.WriteLine(age);
            //convert number to string
            float price = 29.95f;
            //convert the var price from float to a string representation of a number 
            //Console.WriteLine(price.ToString("C"));//which is then formatted to currency using format string
            Console.WriteLine(price.ToString("C0"));//C0 formats it to a whole number by rounding it and getting rid of the decimal points

        }
    }
}

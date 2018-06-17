using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Jennifer Aniston";

            //for (var i = 0; i < name.Length; i++)
            // {
            //     Console.WriteLine(name[i]);
            // }

            //rewrite the same for loop using forEachloop
            //using foreach loop on innumerable objects like arrays, strings or linked lists is more easier than any other loops
            //Example-1
            foreach ( var character in name)
            {
                Console.WriteLine(character);
            }

            //Example-2

            var numbers = new int[] { 1, 2, 3, 4, 5 };

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

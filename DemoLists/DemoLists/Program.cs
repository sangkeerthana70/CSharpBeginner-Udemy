using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list initialize an instance of the list class
            var numbers = new List<int>() { 6, 5, 8, 2, 1 };
            
            numbers.Add(7);//add one object to a list
            
            //add another list or another array to a list
            numbers.AddRange(new int[3] { 10, 11, 12 });
            foreach(var i in numbers)
                Console.WriteLine(i);
        }
    }
}

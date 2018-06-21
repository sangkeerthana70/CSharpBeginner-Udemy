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
            numbers.AddRange(new int[4] { 10, 11, 12, 1 });
            foreach(var i in numbers)
                Console.WriteLine(i);
            Console.WriteLine();//print an empty line
            Console.WriteLine("Index of 7: " + numbers.IndexOf(7));//returns the position of the number in the List
            //Last index of method to locate the last index of duplicate elements in the lists.
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            //count 
            Console.WriteLine("Count: " + numbers.Count);

            //Remove() method
            numbers.Remove(1);
            foreach(var j in numbers)
                Console.WriteLine(j);
           
        }
    }
}

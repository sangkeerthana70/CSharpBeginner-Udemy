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
            numbers.Remove(1);//This example removes only one 1 from the list
            foreach (var j in numbers)
                Console.WriteLine(j);

            Console.WriteLine();
            Console.WriteLine();
            //to rempove all occurrences of 1 in the list 
            
            for( var i = 0; i < numbers.Count; i ++)
            {
                if(numbers[i] == 1)
                numbers.Remove(numbers[i]);

            }
            foreach(var q in numbers)
                Console.WriteLine("collection after removing 1's from numbers: " + q);

            //clear method removes all elements from the list
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}

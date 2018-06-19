using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 20, 16, 12 };
            //length
            Console.WriteLine("Length: " + numbers.Length);
            //IndexOf() method in action
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //clear() method sets the value of a specified position in an array to 0.
            Array.Clear(numbers, 0, 3);
            //forEach loop to display all the elements in the array after using the Array.Clear method
            Console.WriteLine("Effect of using Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //copy() method copies elements from one array into the other
            int[] another = new int[5];
            Array.Copy(numbers, another, 5);
            //forEach loop to display all the elements in the array after using the Array.Copy method
            Console.WriteLine("Effect of using Copy()");
            foreach(var i in another)
                Console.WriteLine(i);

            //Sort() method sorts all the elements in an array in ascending order
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach(var j in numbers)
                Console.WriteLine(j);
            //Reverse() method
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach(var k in numbers)
                Console.WriteLine(k);

        }
    }
}
/*Key Points to be noted in this Lecture are 
 * the first example called the length property on the nummbers object whereas in other examples we called
 * the other array  methods directly on the Array Class itself and not on the numbers object.
 * This means that if the method is accessible on the class itself like the Arrays it is a static method.
 * when a class member like a method or field or property is declared as a static that means it's accessible
 * from the class itself but otherwise that member is accessible via the object.

 * 

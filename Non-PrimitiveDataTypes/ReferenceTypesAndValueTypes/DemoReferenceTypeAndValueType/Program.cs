using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoReferenceTypeAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //value type
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0} ,b:  {1}", a, b  ));
            //reference type
            var arr1 = new int[3] { 1, 2, 3 };//new keyword allocates memory 
            var arr2 = arr1;
            arr2[0] = 0;
            Console.WriteLine(string.Format("arr1[0]: {0}, arr2[0]: {1}", arr1[0], arr2[0]));
        }   

    }
}

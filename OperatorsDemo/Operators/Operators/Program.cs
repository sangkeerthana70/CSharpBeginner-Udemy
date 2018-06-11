using System;

namespace Operators
{
    class Program
    {
        //Example for add operator
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine( a + b);

            //Example for division operator
            var c = 10;
            var d = 3;
            Console.WriteLine(c/d);

            //Example for explicit type casting
            var x = 10;
            var y = 3;
            Console.WriteLine((float)x / (float) y);

            //Example for operator precedence
            var e = 1;
            var f = 2;
            var g = 3;
            Console.WriteLine(e + f * g);//multiply and divide have the first precedence over addition or subtraction operators

            //Example to change precedence of operators
            var h = 1;
            var i = 2;
            var j = 3;
            Console.WriteLine((h + i) * j);

            //Example of comparison operators
            var k = 8;
            var l = 9;
            Console.WriteLine(k > l);

            //Example of equality 
            var m = 12;
            var n = 2;
            Console.WriteLine(m == n);

            //Example of inequality 
            var o = 12;
            var p = 2;
            Console.WriteLine(o != p);

            //another example of the not operator 
            var q = 15;
            var r = 5;
            Console.WriteLine(!(q != r));//should return false since it is !(true) hence false

            //(!(q != r) is two negatives that will result in a positive can be rewriiten as ( q == r)
            var s = 2;
            var t = 5;
            Console.WriteLine(s == t);

            //example of logical and operator
            var u = 1;
            var v = 2;
            var w = 3;
            Console.WriteLine(w > v && w > u);//will result in true as it evaluates to true and true

            //Example of logical andor operator
            var xx = 2;
            var yy = 3;
            var z = 4;
            Console.WriteLine(z > yy && z == xx);//will result in false as it evaluates to true and false 

            //Example of logical or operator
            var anu = 5;
            var kee = 6;
            var gee = 7;
            Console.WriteLine(gee > kee || gee == anu);//will reult in true as it evaluates to true or false.
        }
    }
}

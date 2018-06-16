using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleReferenceAndValueType
{
    //class Person
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Ex:1 passing by value type
            var number = 1;
            Increment(number);
            Console.WriteLine(number);//value will be 1 unchanged as passed by value 

            //Ex:2 passing by reference type
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

            //static methods that are void wont return any value but created to call them without creating an object(demo purposes)

            public static void Increment(int number1)
            {
                //addition assignment operator in action
                number += 10;
            }

            public static void MakeOld(Person person1)
            {
                person1.Age += 10;
            }
        }
    }
}

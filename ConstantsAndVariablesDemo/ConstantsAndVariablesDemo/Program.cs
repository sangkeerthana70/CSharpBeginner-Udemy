using System;

namespace ConstantsAndVariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var number = 2;//byte number = 2;
             var count = 10;// int count = 10;
             var totalPrice = 20.95f; // float totalPrice = 20.95f;//C sharp treats a real number as double data type at runtime so to explicitly tell the compiler to treat it as float use the word f.
             var character = 'B';// char character = 'A';
             var firstName = "Sam";// string firstName = "Anu";
             var isWorking = true;// bool isWorking = false;
             Console.WriteLine(number);
             Console.WriteLine(count);
             Console.WriteLine(totalPrice);
             Console.WriteLine(character);
             Console.WriteLine(firstName);
             Console.WriteLine(isWorking);*/

            /* //Format string
             Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
             Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);*/

            const float Pi = 3.14f;//declare constant value when the value has to stay the same throughout the class.
            Console.WriteLine(Pi);

        }
    }
}

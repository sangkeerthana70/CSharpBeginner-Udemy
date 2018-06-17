using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnConditionals
{
    public class Conditionals
    {
        static void Main(string[] args)
        {
            var number = new NotFiniteNumberException();

            Ex1(number);
        }

        private static void Ex1(NotFiniteNumberException number)
        {
            throw new NotImplementedException();
        }

        public void Ex1()
        {
            /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            /// applications where values entered into input boxes need to be validated.)

            Console.WriteLine("Enter a number between 1 and 10:");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            Console.WriteLine(number);

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("The number is Valid");
            }
            else
            {
                Console.WriteLine("The number is invalid");
            }
        }




    }
}

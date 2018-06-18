using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //Example-1 Random class to generate random numbers
            var random = new Random();
            /*
            for (var i = 0; i < 10; i++)
            {
                // var randomNumber = random.Next();
                // Console.WriteLine(randomNumber);

                var randomNumber = random.Next(1, 15);//to limit the range of random numbers generated specify the min and max values.
                Console.WriteLine(randomNumber);
            }
            */

            //Example-2 Random class to generate random string
            
            for (var i = 0; i < 10; i++)
            {
                var randomChar = random.Next(97, 122);//cast the number generated to character
                Console.Write((char)randomChar);//Console.Write is used to print the output in the same line
                Console.WriteLine();
            }



        }
    }
}

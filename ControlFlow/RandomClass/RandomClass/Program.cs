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
            /*
            for (var i = 0; i < 10; i++)
            
                var randomChar = random.Next(97, 122);//cast the number generated to character since 97 to 122 represent ascii chars from a to z 
                Console.Write((char)randomChar);//Console.Write is used to print the output in the same line
                Console.WriteLine();
            
            */

            //Ex-3
            for (var i = 0; i < 10; i++)
            
                Console.Write((char)('a' + random.Next(0, 26)));
                Console.WriteLine();


            //EX-4 display the string after storing it in a array instead of using console.writeline
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            //create string based on the char array using the string class
            var password = new string(buffer);
            Console.WriteLine(password);
            
        }
    }
}

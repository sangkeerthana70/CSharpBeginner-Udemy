using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Example of while loop.
            //A while loop is used when we are unsure how many times the loop will be executed.
            var i = 0;
            while(i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);                  
                }
                i++;
            }

            //Example-2 using break 
            //while(true)
            //{
            //    Console.Write("Type Your name: ");
            //    var input = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(input))//if input is null or whitespace if condition is true an  breaks out of the loop 
            //        break;


            //    Console.WriteLine("@Echo: " + input);
            //}

            //Example-3 Not Operator
            while (true)
            {
                Console.Write("Type Your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;//continues to line-47 beginning of while loop
                }
                break;


                
            }

        }
    }
}

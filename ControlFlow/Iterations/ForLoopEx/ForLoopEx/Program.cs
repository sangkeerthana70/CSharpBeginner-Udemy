using System;


namespace ForLoopEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //check for even numbers from 1 to 10
            for (var i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

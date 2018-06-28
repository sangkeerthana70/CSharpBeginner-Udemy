using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating timeSPan objects
            var timeSpan = new TimeSpan(1, 2, 3);


            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Time duration: " + duration);
            //properties of timeSpan class
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);
            //Add and Subtract examples
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Convert timeSpan to string  using ToString method
            Console.WriteLine("Convert timeSpan to String: " + timeSpan.ToString());
            //parse string to timeSpan
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
            

        }
    }
}

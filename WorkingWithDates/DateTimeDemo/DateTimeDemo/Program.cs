using System;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2018, 6, 22);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Minutes: " + now.Minute);

            var tomorrow = now.AddDays(1);//will return tomorrow
            var yesterday = now.AddDays(-1);//will return yesterday
            //formatting DateTime objects to string using methods in DateTime object
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));//DateTime format specifiers

        }
    }
}

using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //create objectof type  StringBuilder
            var builder = new StringBuilder();
            //explore methods of StringBuilder which has string manipulation options
            builder.Append('*', 15);
            builder.AppendLine();//adds a new line
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('*', 15);
            //Console.WriteLine(builder);//this method takes in a char and repeats it the number of times specified. It also has many other over loads.
            builder.Replace('*', '#');
            //Console.WriteLine(builder);
            builder.Remove(0, 15);//removes chars from the specified position
            builder.Insert(0, new string('$', 15));
            Console.WriteLine(builder);
            Console.WriteLine("First Char: " + builder[0]);*/

            //chain all of the above stringBuilder methods to simplify the code
            //create objectof type  StringBuilder
            var builder = new StringBuilder();
            //explore methods of StringBuilder which has string manipulation options
            builder
                .Append('*', 15)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('*', 15)
                .Replace('*', '#')
                .Remove(0, 15)
                .Insert(0, new string('$', 15));
            Console.WriteLine(builder);
            Console.WriteLine("First Char: " + builder[0]);
        }
 
        
    }
}
//note: string builders do not have a search method which means the Indexof, and other search methods do not exist.
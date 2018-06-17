using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ex:1
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season");                    
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to the beach");                   
                    break;

                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
            */

            //Example:2 SwitchCase
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;
                default:
                    Console.WriteLine("I don't understand that season");
                    break;

            }


        }
    }
}

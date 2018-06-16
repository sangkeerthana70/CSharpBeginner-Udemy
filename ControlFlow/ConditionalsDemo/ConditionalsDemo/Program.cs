using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex:1 If Else conditionals
              int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }*/

            //Ex:2 Conditional Operator
            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)//normal if else statement
            {
                price = 19.95f; 
            }
            else
            {
                price = 29.95f;
            }
            //Conditional Operator
            bool isGoldCustomer1 = false;
            
            float price1 = (isGoldCustomer1) ? 19.95f : 29.95f;
            Console.WriteLine(price1);

        }
    }
}

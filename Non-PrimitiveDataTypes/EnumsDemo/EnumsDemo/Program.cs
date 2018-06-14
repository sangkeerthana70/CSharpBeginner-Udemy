using System;

namespace EnumsDemo
{
    public enum ShippingMethod
    {
        //members
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //convert Enum to an integer using integer casting
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);  

            //convert integer  to a Enum (ShippingMethod) 
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //convert an enum to a string or get a string and convert it to a enum
            //EX-1 convert the method(enum) to a string
            Console.WriteLine(method.ToString());

            //EX-2 convert a string to enum if stored in a database or some other system



        }
    }
}

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
            var methodName = "Express"; //convert this to a shippingMethod enum
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            /*1-first parameter is the  type which is the ShippingMethod to which we want the string to be converted into,
            2-second parameter is the string value for which we give the methodName.
            3-the return type returns an object, it does not return a shippingMethod, to do this we have to explicitly cast 
            4-the object that is returned to a ShippingMethod(enum).
            5-finally store the result of this expression in a separate variable called shippingMethod*/
            Console.WriteLine(shippingMethod);
        }
    }
}

using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //implicit type conversion
            byte b = 1;
            int i = b;
            Console.WriteLine( i);*/

            /*
            //explicit type conversion
            int i = 1000;
            byte b = (byte) i; //cast the integer to a byte
            Console.WriteLine(b);*/

            //non-compatible data type conversion.
            //Example:1
            try
            {
                //the convert class converts number to byte.
                var number = "1234";
                // int i = Convert.ToInt32(number);
                byte b = Convert.ToByte(number);//this gives handling exception error when the program is run hence the try catch Exception is done
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
                
            }

            //Example-2 for non-compatible data type
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
         



        }
    }
}

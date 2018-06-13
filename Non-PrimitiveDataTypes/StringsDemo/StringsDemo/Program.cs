using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // string firstName = "Anuradha";
            var firstName = "Anuradha";
            var lastName = "Sengalvarayan";

            var fullName = firstName + " " + lastName;
            //string format method
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Keethu", "Geethu", "Senthil" };
            //join method that joins all the names
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            //verbatim strings
            var text = "Hi John \nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            

        }

    }
}

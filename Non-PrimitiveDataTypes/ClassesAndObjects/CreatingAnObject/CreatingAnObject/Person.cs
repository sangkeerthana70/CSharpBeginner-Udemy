using System;

namespace CreatingAnObject
{
    //Define a class called Person
    public class Person//access modifier, keyword class and identifier, these are the syntax to define a class
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is "  + FirstName +  " " + LastName );
        }

    }
}

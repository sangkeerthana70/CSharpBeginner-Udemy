using CreatingAnObject.Math;

namespace CreatingAnObject
{

    class Program
    {
        static void Main(string[] args)
        {
            //create an Object of type Person
           // Person John = new Person();
            var John = new Person();
            John.FirstName = "John";
            John.LastName = "Smith";
            John.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(8, 9);
            System.Console.WriteLine(result);

        }
    }
}

namespace Persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Person("Andrey", 43, "Russia").ConvertToJSON());
        }
    }
}

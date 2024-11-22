namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new() {
                new Person("Андрей", new() { 4, 5, 3, 2, 3, 4}),
                new Person("Дима", new() { 3, 5, 3, 2, 3, 4, 5, 5}),
                new Person("Вика", new() { 4, 5, 2, 2, 3, 4, 4, 5}),
                new Person("Анастасия", new() { 4, 5, 5, 5, 2, 3, 4}),
                new Person("Леонид", new() { 4, 5, 3, 2, 3, 4, 3, 3, 3, 3}),
            };

            var result = from r in people select $"Имя: {r.Name}, Средний балл: {Math.Ceiling(r.AverageMarks() / 0.1) * 0.1}";

            foreach ( var r in result )
            {
                Console.WriteLine(r);
            }
        }
    }
}

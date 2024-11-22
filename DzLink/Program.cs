namespace DzLink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> ints = new List<int>();
            Console.WriteLine("Начальный список: ");
            for (int i = 0; i < 15; i++) {
                ints.Add(new Random().Next(0, 100));
                Console.WriteLine(ints[i]);
            }
            var result = from r in ints where r % 2 == 0 && r > 10 select r;
            Console.WriteLine("Отсортированный список: ");
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}

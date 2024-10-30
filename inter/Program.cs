using System.Runtime.Serialization;

List<string> names = new List<string>() { "Денис", "Марк", "Даниил", "Артём"};
foreach (var name in names) {
    if (name.First() == 'Д') {
        Console.WriteLine(name);
    }
}
var result = from name in names where name.StartsWith('Д') select name;
foreach (var item in result) {
    Console.WriteLine(item);
}

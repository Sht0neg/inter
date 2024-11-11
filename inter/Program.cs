using System.Diagnostics.SymbolStore;
using System.Net.WebSockets;
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

var result2 = names.Where(name => name.StartsWith('Д')).OrderBy(name => name);


List<Person> people = new() {
    new Person() { Age = 1, Name = "Марк", Languages = new List<string>(){"Java", "HolyC"} },
    new Person() { Age = 2, Name = "Иван", Languages = new List <string>(){"Java", "Python"} },
    new Person() { Age = 3, Name = "Петя"},
};

var namesp = from person in people select $"Name: {person.Name}, Age: {person.Age}";

List<Company> companies = new() {
    new Company() { Titel="Sony", Industry="Video games" },
    new Company() {Titel="Bruzzzers", Industry="Interaction"}
};

var nameper = from person in people
              from lang in person.Languages
              where lang == "Java"
              select $"Name: {person.Name}, Age: {person.Age}";

List<int> marks = new() { 2, 4, 5, 2, 3, 3, 4, 5 };
Console.WriteLine(marks.Aggregate((x, y) => x + y));

foreach (var i in nameper) {
    Console.WriteLine(i);
}

class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public List<string> Languages { get; set; }
}

class Company {

    public string Titel { get; set; }
    public string Industry { get; set; }
}

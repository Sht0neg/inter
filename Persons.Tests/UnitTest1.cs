using System.Text.Json;

namespace Persons.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetBirthDate()
        {
            Person person = new("Даниил", 43, "Россия");
            Assert.IsTrue(person.GetBirthDate() == 2024 - 43);
        }

        [Test]
        public void TestConverToJSON()
        {
            Person person = new("Даниил", 43, "Россия");
            Assert.IsTrue(person.ConvertToJSON().StartsWith("{"));
        }

        [Test]
        public void TestCountrySort()
        {
            People people = new(new List<Person> { new("Даниил", 43, "Россия"),
                new("Александер", 33, "Турция"),
                new("Сергей", 51, "Россия"),
                new("Иван", 73, "СССР")
            });
            Assert.IsTrue(people.CountrySort("Россия").Count == 2);
        }
    }
}
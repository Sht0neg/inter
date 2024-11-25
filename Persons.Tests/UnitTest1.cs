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
            Person person = new("������", 43, "������");
            Assert.IsTrue(person.GetBirthDate() == 2024 - 43);
        }

        [Test]
        public void TestConverToJSON()
        {
            Person person = new("������", 43, "������");
            Assert.IsTrue(person.ConvertToJSON().StartsWith("{"));
        }

        [Test]
        public void TestCountrySort()
        {
            People people = new(new List<Person> { new("������", 43, "������"),
                new("����������", 33, "������"),
                new("������", 51, "������"),
                new("����", 73, "����")
            });
            Assert.IsTrue(people.CountrySort("������").Count == 2);
        }
    }
}
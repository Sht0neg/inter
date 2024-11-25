using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public Person(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public int GetBirthDate() {
            return DateTime.UtcNow.Year - this.Age;
        }

        public string ConvertToJSON() {
            string json = JsonSerializer.Serialize(this);
            return json;
        }
    }
}

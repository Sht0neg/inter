using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class People
    {
        public List<Person> people;

        public People(List<Person> people)
        {
            this.people = people;
        }

        public List<Person> CountrySort(string Country) {
            var result = this.people.Where(person => person.Country.StartsWith(Country));
            return result.ToList();
        }
    }
}

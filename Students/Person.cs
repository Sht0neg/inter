using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Person
    {
        public string Name { get; set; }

        public List<int> Marks { get; set; }

        public Person(string name, List<int> marks)
        {
            Name = name;
            Marks = marks;
        }

        public float AverageMarks() {
            float av = 0;
            foreach (var mark in Marks)
            {
                av += mark;
            }
            return av/Marks.Count;
        }
    }
}

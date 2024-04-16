using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaProject
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public int CompareTo(Person obj)
        {
            return Name.CompareTo(obj.Name);
        }
    }
}

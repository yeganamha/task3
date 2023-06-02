using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Person
    {
        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age =  age;
        }
         public string Name { get; set; }
        public string Surname { get; set;}
        public int Age { get; set; }




    }
}

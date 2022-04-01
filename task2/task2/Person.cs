using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class Person
    {
        public Person(string name, string surname, byte age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name;
        public string Surname;
        private byte Age;
    }
}

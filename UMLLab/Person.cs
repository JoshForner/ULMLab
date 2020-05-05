using System;
using System.Collections.Generic;
using System.Text;

namespace UMLLab
{
    class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }

        public Person() { }
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public override string ToString()
        {
            return $"Person[name = {Name}, address = {Address}]";
        }
    }
}

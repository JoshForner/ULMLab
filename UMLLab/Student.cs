using System;
using System.Collections.Generic;
using System.Text;

namespace UMLLab
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student() { }
        public Student(string Name, string Address, string Program, int Year, double Fee) : base(Name,Address)
        {
            this.Fee = Fee;
            this.Program = Program;
            this.Year = Year;
        }

        public override string ToString()
        {
            return base.ToString() + $", program = {Program}, year = {Year}, fee = {Fee}]";
        }
    }
}

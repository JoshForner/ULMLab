using System;
using System.Collections.Generic;
using System.Text;

namespace UMLLab
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff() { }
        public Staff(string Name, string Address, string School, double Pay) : base (Name, Address) 
        {
            this.Pay = Pay;
            this.School = School;
        }

        public override string ToString()
        {
            return base.ToString() + $", school = {School}, pay = {Pay}]";
        }
    }
}

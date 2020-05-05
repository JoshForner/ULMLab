using System;
using System.Collections.Generic;

namespace UMLLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Student("Josh", "123 Oak", "Math", 2024, 5890.17),
                new Student("Kat", "123 Cherry", "History", 2025, 7881.07),
                new Student("Sam", "123 Birch", "Art", 2026, 10050.65),
                new Staff("Bill", "456 Maple", "Allendale", 26000),
                new Staff("Mary", "456 Poplar", "Hudsonville", 28487.99)
            };
            AddPerson(people);
            for(int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].ToString());
            }
        }


        public static List<Person> AddPerson(List<Person> people)
        {
            while (true)
            {
                Console.WriteLine("Would you like to add a student or staff?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "student")
                {
                    Console.WriteLine("What is their name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is their address?");
                    string address = Console.ReadLine();
                    Console.WriteLine("What program are they in?");
                    string program = Console.ReadLine();
                    Console.WriteLine("What year do they graduate?");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("How much is the fee?");
                    double fee = double.Parse(Console.ReadLine());
                    Student student =new Student(name, address, program, year, fee);
                    people.Add(student);
                    break;
                }
                if (answer == "staff")
                {
                    Console.WriteLine("What is their name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is their address?");
                    string address = Console.ReadLine();
                    Console.WriteLine("What school do they teach at?");
                    string school = Console.ReadLine();
                    Console.WriteLine("What is their salary?");
                    double pay = int.Parse(Console.ReadLine());
                    Staff staff = new Staff(name, address, school, pay);
                    people.Add(staff);
                    break;
                }
            }
            return people;
        }
    }
}

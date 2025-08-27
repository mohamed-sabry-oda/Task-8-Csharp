using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public Student(Student other)
        {
            Id = other.Id;
            Name = other.Name; // ensures a new string object
            Grade = other.Grade;
        }
        public override string ToString()
        {
            return $"Id {Id} Name {Name} Grade {Grade}";
        }
    }
}

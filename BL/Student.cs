using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Student
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public double MedM { get; set; }
        public string Year { get; set; }
        public string Group { get; set; }

        public Student(string name, string date, double medMar, string year, string group)
        {
            Name = name;
            Date = date;
            MedM = medMar;
            Year = year;
            Group = group;
        }
    }
}

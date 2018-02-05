using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Student:Person
    {
        public string Program { set; get; }
        public int Year { set; get; }
        public double Fee { set; get; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            return $"Student:{Name}, {Address}, {Program}, {Year}, {string.Format("{0:C}",Fee)}";
        }
    }
}

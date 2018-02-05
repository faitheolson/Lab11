using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff: Person
    {
        public string School { set; get; }
        public double Pay { set; get; }

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return $"Staff: {Name}, {Address}, {School}, {String.Format("{0:C}", Pay)}";
        }
       


    }
}

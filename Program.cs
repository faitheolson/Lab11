using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>();
            PersonList.Add(new Person("Fred", "1155 Clark"));
            PersonList.Add(new Student("Bart Simpson","CartoonLand", "Biology", 1975, 1200));
            PersonList.Add(new Staff("Mrs. Moon", "1100 Republic Dr", "Bingham Elementary", 5000));

            foreach (Person item in PersonList)
            {
                Console.WriteLine(item.ToString());
            }

            


        }
    }
}

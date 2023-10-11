using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_4___c_
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Person()
        {
            Name = string.Empty;
            Id = 0;
        }
        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

    }
}

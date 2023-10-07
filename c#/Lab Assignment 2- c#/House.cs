using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2___c_
{
    public class House
    {
        public Room r1;
        public Room r2;
        public Resident person;
        public int totalm2 { get; set; }
        public House() 
        {
            r1 = new Room();
            r2 = new Room();
            person = new Resident();
            totalm2 = 150;
        }
        public void addResident(Resident p)
        {
            if (person.name == null && person.lastname == null)
                person = p;
        }
        public int calculateTotalm2()
        {
            totalm2 = r1.m2 + r2.m2;
            return totalm2;
        }
    }
}

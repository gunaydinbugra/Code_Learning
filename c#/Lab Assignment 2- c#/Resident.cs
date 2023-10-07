using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2___c_
{
    public class Resident
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public Resident() 
        {
            name = null;
            lastname = null;
        }
        public void getResident()
        {
            Console.WriteLine("--------------------------Resident Information--------------------------");
            Console.Write("Name: ");
            string a = Console.ReadLine();
            name = a;
            Console.Write("Last name: ");
            a = Console.ReadLine();
            lastname = a;
        }
        public void printResident()
        {
            Console.WriteLine($"Resident Name: {name}, Resident Last name: {lastname}");
            Thread.Sleep(750);
        }
    }
}

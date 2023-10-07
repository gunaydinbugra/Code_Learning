using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2___c_
{
    public class Room
    {
        public int m2 { set; get; }
        public string balcony { set; get; }

        public void getRoom()
        {
            
            bool b = false;
            while(b != true)
            {
 //               Console.Clear();
                Console.WriteLine("--------------------------Room Information--------------------------");
                Console.Write("Enter m2 of room: ");
                string a = Console.ReadLine();
                if (int.TryParse(a, out int x))
                {
                    m2 = x;
                    b = true;
                }
                else
                {
                    Console.WriteLine("Invalid value entered please try again");
                    Thread.Sleep(750);
                }
            }
            b = false;
            while(b != true)
            {
                Console.Write("Does room has a balcony (yes or no): ");
                string a = Console.ReadLine();
                if(a == "yes" || a == "no")
                {
                    balcony = a;
                    b = true;
                }
                else
                {
                    Console.WriteLine("please enter only yer or no");
                    Thread.Sleep(750);
                }
            }
        }
        public void printRoom()
        {
            Console.WriteLine($"m2: {m2},balcony: {balcony}");
            Thread.Sleep(750);
        }
    }
}

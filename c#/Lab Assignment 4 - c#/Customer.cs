using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_4___c_
{
    public class Customer : Person
    {
        public Customer(string name, int id)
        {
            Name= name;
            Id= id;
        }
        public void requestJob(Employee employee, task t)
        {
            employee.AddTask(t);
        }
    }
}

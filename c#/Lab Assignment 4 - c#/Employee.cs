using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_4___c_
{
    public class Employee : Person
    {
        public string Role { get; set; }
        public List<task> Tasks { get; set; } = new List<task>();

        public Employee(string name, int id, string role)
        {
            Name = name;
            Id = id;
            Role = role;
        }
        public void displayTasks()
        {
            Console.WriteLine($"Employee ID: {Id}, Employee Role: {Role}");
            Console.WriteLine("Tasks: ");
            foreach (task i in Tasks)
            {
                Console.Write($"Task {Tasks.Count()} ");
                Console.WriteLine(i);
            }
        }
        public void AddTask(task t)
        {
            Tasks.Add(t);
        }
        public void RemoveTask(task t)
        {
            Tasks.Remove(t);
        }
        public void displayUnfinishedTasks()
        {
            Console.WriteLine($"Employee ID: {Id} and Employee Role: {Role}");
            Console.WriteLine("UnFinished Tasks: ");
            foreach (task i in Tasks)
            {   
                if(i.Finished == false)
                    Console.WriteLine(i);
            }
        }
        public void removeDuplicateTasks()
        {
            int c = 0;
            for (int i = Tasks.Count - 1; i >= 0; i--)
            {
                for (int t = Tasks.Count - 1; t >= 0; t--)
                {
                    if (Tasks[i].Equals(Tasks[t]))
                    {
                        c++;
                    }
                }
                if(c >= 2)
                {
                    Tasks.Remove(Tasks[i]);
                }
            }
        }
    }
}

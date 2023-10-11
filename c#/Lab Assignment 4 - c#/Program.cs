using Lab_Assignment_4___c_;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

bool b1 = false;
List<Employee> employee = new List<Employee>();
List<Customer> customer = new List<Customer>();
List<task> tasks = new List<task>();
while(b1 != true)
{
    Console.Write("Number of Employees that you want to add: ");
    string a = Console.ReadLine();
    if (int.TryParse(a, out int x1))
    {
        for (int i = 0; i < x1 ; i++)
        {
            Console.Write("Enter Name,id and Role: ");
            string employeename = Console.ReadLine();
            bool b2 = false;
            int employeeid = 0;
            while(b2 != true)
            {
                a = Console.ReadLine();
                if (int.TryParse(a, out int x2))
                {
                    employeeid = x2;
                    b2 = true;
                }
                else
                {
                    Console.WriteLine("Invalid Value Entered");
                }
            }
            string employeerole = Console.ReadLine();
            Employee e = new Employee(employeename, employeeid, employeerole);
            employee.Add(e);
        }
        b1= true;
    }
    else
    {
        Console.WriteLine("Invalid Value Entered");
    }
}
b1 = false;
while (b1 != true)
{
    Console.Write("Number of Customer that you want to add: ");
    string a = Console.ReadLine();
    if (int.TryParse(a, out int x1))
    {
        for (int i = 0; i < x1; i++)
        {
            Console.Write("Enter Name and id:  ");
            string customername = Console.ReadLine();
            bool b2 = false;
            int customerid = 0;
            while (b2 != true)
            {
                a = Console.ReadLine();
                if (int.TryParse(a, out int x2))
                {
                    customerid = x2;
                    b2 = true;
                }
                else
                {
                    Console.WriteLine("Invalid Value Entered");
                }
            }
            Customer e = new Customer(customername, customerid);
            customer.Add(e);
        }
        b1 = true;
    }
    else
    {
        Console.WriteLine("Invalid Value Entered");
    }
}
b1 = false;
while (b1 != true)
{
    Console.Write("Enter how many tasks to get done: ");
    string a = Console.ReadLine();
    if (int.TryParse(a, out int x1))
    {
        for (int i = 0; i < x1; i++)
        {
            Console.WriteLine($"Task {i+1}");
            Console.Write("Enter DueDate(day month year): ");
            int day = 0, month = 0, year = 0, cost = 0;
            bool finished = true;
            bool b2 = false;
            while (b2 != true)
            {
                a = Console.ReadLine();
                if (int.TryParse(a, out int x2))
                {
                    day = x2;
                    b2 = true;
                }
                else
                {
                    Console.WriteLine("Invalid Value Entered");
                }
            }
            b2 = false;
            while (b2 != true)
            {
                a = Console.ReadLine();
                if (int.TryParse(a, out int x2))
                {
                    month = x2;
                    b2 = true;
                }
                else
                {
                    Console.WriteLine("Invalid Value Entered");
                }
            }
            b2 = false;
            while (b2 != true)
            {
                a = Console.ReadLine();
                if (int.TryParse(a, out int x2))
                {
                    year = x2;
                    b2 = true;
                }
                else
                {
                    Console.WriteLine("Invalid Value Entered");
                }
            }
            b2 = false;
            while (b2 != true)
            {
                Console.Write("Cost: ");
                a = Console.ReadLine();
                if (int.TryParse(a, out int x2))
                {
                    cost = x2;
                    b2 = true;
                }
                else
                {
                    Console.WriteLine("Invalid Value Entered");
                }
            }
            b2 = false;
            while (b2 != true)
            {
                Console.Write("Finished(yes '1' ,no '2'): ");
                a = Console.ReadLine();
                if (int.TryParse(a, out int x2))
                {
                    if (x2 == 1)
                    {
                        finished = true;
                        b2 = true;
                    }
                    else if (x2 == 2)
                    {
                        finished = false;
                        b2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Value Entered");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Value Entered");
                }
            }
            DueDate l = new DueDate(day ,month, year);
            task t = new task(l, cost, finished);
            tasks.Add(t);
        }
        b1 = true;
    }
    else
    {
        Console.WriteLine("Invalid Value Entered");
    }
}
b1 = false;
int x3 = tasks.Count();
for (int i = 0; i < x3; i++)
{
    int e = 0, c = 0;
    Console.Write($"Choose employee id to assign task {i+1} and customer id: ");
    bool b2 = false;
    while (b2 != true)
    {
        string o = Console.ReadLine();
        if (int.TryParse(o, out int x2))
        {
            e = x2;
            b2 = true;
        }
        else
        {
            Console.WriteLine("Invalid Value Entered");
        }
    }
    b2 = false;
    while (b2 != true)
    {
        string a = Console.ReadLine();
        if (int.TryParse(a, out int x2))
        {
            c = x2;
            b2 = true;
        }
        else
        {
            Console.WriteLine("Invalid Value Entered");
        }
    }
    int x4 = employee.Count();
    int x5 = customer.Count();

    for(int p = 0; p < x4; p++)
    {
        if (employee[p].Id == e)
        {
            for (int u = 0; u < x5; u++)
            {
                if (customer[u].Id == c)
                {
                    customer[u].requestJob(employee[p], tasks[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("Given id dont recognised");
        }
    }
    
 }
int x6 = employee.Count();
for (int i = 0; i < x6; i++)
{
    employee[i].removeDuplicateTasks();
}
Console.WriteLine("Updated Tasks For Each Employee: ");
for (int i = 0; i < x6; i++)
{
    employee[i].displayTasks();
}









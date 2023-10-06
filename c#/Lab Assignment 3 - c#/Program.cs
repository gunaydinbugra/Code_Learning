using Lab_Assignment_3___c_;
using System.ComponentModel.Design;

CheckingAccount c1 = new CheckingAccount();
SavingAccount s1 = new SavingAccount();
SavingAccount s2 = new SavingAccount();

Console.Write("Enter initial balance for CheckingAccount1= ");
string a = Console.ReadLine();
if(int.TryParse(a,out int x))
{
    c1.setbalance(x);
}
else
{
    Console.WriteLine("Invalid Value Entered");
}
Console.Write("Enter initial balance for SavingAccount1= ");
a = Console.ReadLine();
if (int.TryParse(a, out x))
{
    s1.setbalance(x);
}
else
{
    Console.WriteLine("Invalid Value Entered");
}
Console.Write("Enter initial balance for SavingAccount2= ");
a = Console.ReadLine();
if (int.TryParse(a, out x))
{
    s2.setbalance(x);
}
else
{
    Console.WriteLine("Invalid Value Entered");
}
bool exitmenu = false;

while(exitmenu != true)
{
    Console.Clear();
    Console.Write("Choose Operation: \n1-Deposit 2-Withdraw 3-Transfer 4-Balance 5-Exit: ");
    a = Console.ReadLine();

    switch (a)
    {
        case "1":
            Console.Write("Enter the Account type and number to deposit money to (c1 - s1 - s2): ");
            a = Console.ReadLine();
            switch (a)
            {
                case "c1":
                    Console.Write("Enter amount of money to deposit: ");
                    a = Console.ReadLine();
                    if (int.TryParse(a, out x))
                        c1.deposit(x);
                    else
                        Console.WriteLine("Invalid Value Entered");
                    break;
                case "s1":
                    Console.Write("Enter amount of money to deposit: ");
                    a = Console.ReadLine();
                    if (int.TryParse(a, out x))
                        s1.deposit(x);
                    else
                        Console.WriteLine("Invalid Value Entered");
                    break;
                case "s2":
                    Console.Write("Enter amount of money to deposit: ");
                    a = Console.ReadLine();
                    if (int.TryParse(a, out x))
                        s2.deposit(x);
                    else
                        Console.WriteLine("Invalid Value Entered");
                    break;
                default:
                    Console.WriteLine("Invalid Value Entered");
                    break;
            }
            break;
        case "2":
            Console.Write("Enter the Account type and number to withdraw money from (c1 - s1 - s2): ");
            a = Console.ReadLine();
            switch (a)
            {
                case "c1":
                    Console.Write("Enter amount of money to withdraw: ");
                    a = Console.ReadLine();
                    if (int.TryParse(a, out x))
                        c1.withdraw(x);
                    else
                        Console.WriteLine("Invalid Value Entered");
                    break;
                case "s1":
                    Console.Write("Enter amount of money to withdraw: ");
                    a = Console.ReadLine();
                    if (int.TryParse(a, out x))
                        s1.withdraw(x);
                    else
                        Console.WriteLine("Invalid Value Entered");
                    break;
                case "s2":
                    Console.Write("Enter amount of money to withdraw: ");
                    a = Console.ReadLine();
                    if (int.TryParse(a, out x))
                        s2.withdraw(x);
                    else
                        Console.WriteLine("Invalid Value Entered");
                    break;
                default:
                    Console.WriteLine("Invalid Value Entered");
                    break;
            }
            break;
        case "3":
            Console.Write("Enter the Account type and number to transer money from (c1 - s1 - s2): ");
            a = Console.ReadLine();
            switch (a)
            {
                case "c1":
                    Console.Write("Enter the Account type and number to transfer (s1 - s2): ");
                    a = Console.ReadLine();
                    switch (a)
                    {
                        case "s1":
                            Console.Write("Enter amount of money to transfer: ");
                            a = Console.ReadLine();
                            if (int.TryParse(a, out x))
                            {
                                c1.withdraw(x);
                                s1.deposit(x);
                            }
                            else
                                Console.WriteLine("Invalid Value Entered");
                            break;
                        case "s2":
                            Console.Write("Enter amount of money to transfer: ");
                            a = Console.ReadLine();
                            if (int.TryParse(a, out x))
                            {
                                c1.withdraw(x);
                                s2.deposit(x);
                            }
                            else
                                Console.WriteLine("Invalid Value Entered");
                            break;
                        default:
                            Console.WriteLine("Invalid Value Entered");
                            break;
                    }
                    break;
                case "s1":
                    Console.Write("Enter the Account type and number to transfer (c1 - s2): ");
                    a = Console.ReadLine();
                    switch (a)
                    {
                        case "c1":
                            Console.Write("Enter amount of money to transfer: ");
                            a = Console.ReadLine();
                            if (int.TryParse(a, out x))
                            {
                                s1.withdraw(x);
                                c1.deposit(x);
                            }
                            else
                                Console.WriteLine("Invalid Value Entered");
                            break;
                        case "s2":
                            Console.Write("Enter amount of money to transfer: ");
                            a = Console.ReadLine();
                            if (int.TryParse(a, out x))
                            {
                                s1.withdraw(x);
                                s2.deposit(x);
                            }
                            else
                                Console.WriteLine("Invalid Value Entered");
                            break;
                        default:
                            Console.WriteLine("Invalid Value Entered");
                            break;
                    }
                    break;
                case "s2":
                    Console.Write("Enter the Account type and number to transfer (c1 - s1): ");
                    a = Console.ReadLine();
                    switch (a)
                    {
                        case "c1":
                            Console.Write("Enter amount of money to transfer: ");
                            a = Console.ReadLine();
                            if (int.TryParse(a, out x))
                            {
                                s2.withdraw(x);
                                c1.deposit(x);
                            }
                            else
                                Console.WriteLine("Invalid Value Entered");
                            break;
                        case "s1":
                            Console.Write("Enter amount of money to transfer: ");
                            a = Console.ReadLine();
                            if (int.TryParse(a, out x))
                            {
                                s2.withdraw(x);
                                s1.deposit(x);
                            }
                            else
                                Console.WriteLine("Invalid Value Entered");
                            break;
                        default:
                            Console.WriteLine("Invalid Value Entered");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Value Entered");
                    break;
            }

            break;
        case "4":

                Console.WriteLine($"Checking Account Balance = {c1.getbalance()} \nSaving Account 1 Balance = {s1.getbalance()} \nSaving Account 2 Balance = {s2.getbalance()}");
                Console.Write("To Return Menu Press Anything");
                a = Console.ReadLine();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("Exiting the Menu");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Exiting the Menu. ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Exiting the Menu..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Exiting the Menu...");
            exitmenu = true;
            break;
        default:
            Console.WriteLine("Invalid Value Entered");
            break;
    }

}







using Lab_Assignment_5___c_;

int[] arr = new int[4];
Calculator c = new Calculator(1);
bool a = false;
while(a != true)
{
    Console.Write("Lenght of the number set: ");
    string b = Console.ReadLine();
    if(int.TryParse(b, out int x))
    {
        c = new Calculator(x);
        a = true;
    }
    else
    {
        Console.WriteLine("Invalid Value Entered");
    }
}
int[] an = new int[c.length];
Console.Write("Please enter first number set: ");
for (int i = 0; i < c.length; i++)
{
bool t = false;
    while (t != true)
    {
    string b = Console.ReadLine();
    if (int.TryParse(b, out int x))
        {
        c.arr1[i] = x;
        t = true;
        }
        else
        {
        Console.WriteLine("Invalid Value Entered");
        }
    }
}
Console.Write("Please enter second number set: ");
for (int i = 0; i < c.length; i++)
{
    bool t = false;
    while (t != true)
    {
        string b = Console.ReadLine();
        if (int.TryParse(b, out int x))
        {
            c.arr2[i] = x;
            t = true;
        }
        else
        {
            Console.WriteLine("Invalid Value Entered");
        }
    }
}
a = false;
while(a != true)
{
    Console.Write("\nChoose Operation (+) (-) (/) (*) (exit): ");
    string l = Console.ReadLine();
    switch (l)
    {
        case "+":
            an = c.Calculate('+');
            Console.Write("Answer: ");
            for (int i = 0; i < c.length; i++)
            {
                Console.Write($"{an[i]} ");
            }
            break;
        case "-":
            an = c.Calculate('-');
            Console.Write("Answer: ");
            for (int i = 0; i < c.length; i++)
            {
                Console.Write($"{an[i]} ");
            }
            break;
        case "*":
            an = c.Calculate('*');
            Console.Write("Answer: ");
            for (int i = 0; i < c.length; i++)
            {
                Console.Write($"{an[i]} ");
            }
            break;
        case "/":
            an = c.Calculate('/');
            Console.Write("Answer: ");
            for (int i = 0; i < c.length; i++)
            {
                Console.Write($"{an[i]} ");
            }
            break;
        case "exit":
            a = true;
            break;
        default:
            Console.WriteLine("Invalid Value Entered");
            break;
    }
}













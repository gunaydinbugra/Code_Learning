/*
// problem #1 - Write a C# Sharp program to print Hello and your name in a separate line.

System.Console.WriteLine("Hello Bugra");

// problem #2 - Write a C# Sharp program to print the sum of two numbers.

System.Console.WriteLine(90 + 10);

// problem #3 - Write a C# Sharp program to print the result of dividing two numbers.

System.Console.WriteLine(100 / 20);

// problem #4 - Write a C# Sharp program to print the results of the specified operations. 

System.Console.WriteLine(-1 + 4 * 6);
System.Console.WriteLine((35 + 5) % 7);
System.Console.WriteLine(14 + -4 * 6 / 11);
System.Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

// problem #5 - Write a C# Sharp program to swap two numbers.

System.Console.Write("Input for the First Number: ");
int first = int.Parse(Console.ReadLine());
System.Console.Write("Input for the Second Number: ");
int second = int.Parse(Console.ReadLine());
int discard = first;
first = second;
second = discard;
Console.WriteLine($"First Number: {first}");
Console.WriteLine($"First Number: {second}");

// problem #6 - Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.

Console.Write("Input the first number to multiply: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Input the second number to multiply: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Input the third number to multiply: ");
int third = int.Parse(Console.ReadLine());
Console.WriteLine($"{first} x {second} x {third} = {first*second*third} ");

// problem #7 - Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.

Console.Write("Input the first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Input the second number: ");
int second = int.Parse(Console.ReadLine());
Console.WriteLine($"{first} + {second} = {first + second} ");
Console.WriteLine($"{first} - {second} = {first - second} ");
Console.WriteLine($"{first} x {second} = {first * second} ");
Console.WriteLine($"{first} / {second} = {first / second} ");

// problem #8 - Write a C# Sharp program that prints the multiplication table of a number as input.

Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number*i}");
}

// problem #9 - Write a C# Sharp program that takes four numbers as input to calculate and print the average.

Console.Write("Enter the first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Enter the third number: ");
int third = int.Parse(Console.ReadLine());
Console.Write("Enter the fourth number: ");
int fourth = int.Parse(Console.ReadLine());

Console.Write($"The average of {first}, {second}, {third}, {fourth} is: {(first + second + third + fourth)/4}");

// problem #10 - Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.

Console.Write("Enter the first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Enter the third number: ");
int third = int.Parse(Console.ReadLine());
Console.WriteLine($"Result of specified numbers {first}, {second}, {third}, ({first} + {second}) x {third} = {(first + second)*third} and {first} x {second} + {second} x {third} = {first*second + second*third}");

// problem #11 - Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"You look older than {age}");

// problem #12 - Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in
// the next row, with no separation. You should do it twice: Use the console. Write and use {0}.

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"{number} {number} {number} {number}");
Console.WriteLine($"{number}{number}{number}{number}");

// problem #13 - Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("{0}{0}{0}",number);
Console.WriteLine("{0} {0}", number);
Console.WriteLine("{0} {0}", number);
Console.WriteLine("{0} {0}", number);
Console.WriteLine("{0}{0}{0}", number);

// problem #14 - Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.

Console.Write("Enter the amount of celsius: ");
int celcius = int.Parse(Console.ReadLine());

Console.WriteLine($"Kelvin = {celcius + 273}");
Console.WriteLine($"Fahrenheit = {celcius * 1.8 + 32}");

// problem #15 - Write a C# program that removes a specified character from a non-empty string using the index of a character.

Console.Write("Enter a non-empty string: ");
string remove = Console.ReadLine();

Console.WriteLine(remove.Remove(1,1));
Console.WriteLine(remove.Remove(9, 1));
Console.WriteLine(remove.Remove(0, 1));

// problem #16 - Write a C# program to create a new string from a given string where the first and last characters change their positions.

Console.Write("Enter a string: ");
string change = Console.ReadLine();

Console.WriteLine(change.Substring(change.Length - 1) + change.Substring(1,change.Length - 2) + change.Substring(0,1));

// problem #17 - Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.

Console.Write("Enter a string: ");
string add = Console.ReadLine();

Console.WriteLine(add.Substring(0,1) + add.Substring(0,add.Length) + add.Substring(0,1));

// problem #18 - Write a C# program to check a pair of integers and return true if one is negative and one is positive.

Console.Write("Input first integer: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Input second integer: ");
int second = int.Parse(Console.ReadLine());

Console.WriteLine((first < 0 && second > 0) || (first > 0 && second < 0));

// problem #19 - Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.

Console.Write("Input first integer: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Input second integer: ");
int second = int.Parse(Console.ReadLine());

if (first == second)
{
    Console.WriteLine($"Integers are the same so triple of their sum = {first * 3}");
}
else
    Console.WriteLine($"Sum of the integers = {first + second}");

// problem #20 - Write a C# program to get the absolute value of the difference between two given numbers.
// Return double the absolute value of the difference if the first number is greater than the second number.

Console.Write("Input first integer: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Input second integer: ");
int second = int.Parse(Console.ReadLine());

if(first > second)
{
    Console.WriteLine($"{Math.Abs(first - second)*2}");
}
else
{
    Console.WriteLine(Math.Abs(first - second));
}

// problem #21 - Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.

Console.Write("Input first integer: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Input second integer: ");
int second = int.Parse(Console.ReadLine());

if (first == 20 || second == 20 || first + second == 20)
{
    Console.WriteLine(true);
}
else { Console.WriteLine(false); }

// problem #22 - Write a C# program to check if the given integer is within 20 of 100 or 200.

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine((number == 200 || (number <= 100 && number >= 20)));

// problem #23 - Write a C# program to convert a given string into lowercase.

Console.Write("Enter a line string: ");
string line = Console.ReadLine();

Console.WriteLine(line.ToLower());

// problem #24 - Write a C# program to find the longest word in a string.

Console.Write("Enter a line string: ");
string line = Console.ReadLine();
string[] pieces = line.Split(" ");

string longest = pieces[0];
for (int i = 1; i < pieces.Length; i++)
{
    if(longest.Length < pieces[i].Length)
    {
        longest = pieces[i];
    }
}
Console.Write(longest);

// problem #25 - Write a C# program to print odd numbers from 1 to 99. Prints one number per line.

Console.WriteLine("Odd numbers from 1 to 99.Prints one number per line.");
for (int i = 0; i < 100; i++)
{
    if(i%2 != 0)
    {
        Console.WriteLine(i);
    }
}

// problem #26 - Write a C# program to compute the sum of the first 500 prime numbers.

Console.WriteLine("Sum of the first 500 prime numbers:");
int sum = 0;
int count = 0;
for (int i = 1; count <= 500; i++)
{
    int counter = 0;
    for (int j = 1; j <= i; j++)
    {
        if(i%j == 0)
        {
            counter++;
        }
    }
    if(counter == 2)
    {
        sum += i;
        count++;
    }
}
Console.WriteLine(sum);

// problem #27 - Write a C# program and compute the sum of an integer's digits.

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
while (number != 0)
{
    sum += number%10;
    number = number/10;
}
Console.WriteLine(sum);

// problem #28 - Write a C# program to reverse the words of a sentence.

Console.Write("Enter a line string: ");
string line = Console.ReadLine();
for (int i = 1; i <= line.Length; i++)
{
    Console.Write(line[line.Length-i]);
}

// problem #29 - Write a C# program to find the size of a specified file in bytes.

FileInfo f = new FileInfo("/home/students/abc.txt");

Console.WriteLine("\nSize of a file: " + f.Length.ToString());

// problem #30 - Write a C# program to convert a hexadecimal number to a decimal number.

Console.Write("Enter a hexadecimal number: ");
string line = Console.ReadLine();
int decValue = int.Parse(line, System.Globalization.NumberStyles.HexNumber);
Console.WriteLine($"Decimal number: {decValue}");

// problem #31 - Write a C# program to multiply the corresponding elements of two integer arrays. 

int[] array1 = {1, 3, -5, 4};
int[] array2 = { 1, 4, -5, -2};

for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"{array1[i] * array2[i]} ");
}

// problem #32 - Write a C# program to create a string of four copies, taking the last four characters from a given string.
// If the given string is less than 4, return the original one.

Console.Write("Enter a line string: ");
string line = Console.ReadLine();

if (line.Length > 4)
{
    Console.WriteLine(line.Substring(line.Length-4));
}
else Console.WriteLine(line);

// problem #33 - Write a C# program to check if a given positive number is a multiple of 3 or 7.

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number % 3 == 0 || number % 7 == 0);

// problem #34 - Write a C# program to check if a string starts with a specified word. Note: Suppose the sentence starts with "Hello"

Console.Write("Enter a line string: ");
string line = Console.ReadLine();
string[] pieces = line.Split(" ");

Console.WriteLine(pieces[0] == "hello");

// problem #35 - Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.

Console.Write("Input a first number(<100): ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Input a second number(>100): ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine(number1 < 100 && number2 > 100);

// problem #36 - Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.

Console.Write("Input a first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine(number1 < 10 && number1 > -10 || number2 > -10 && number2 < 10);

// problem #37 - Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP".

Console.Write("Enter a line string: ");
string line = Console.ReadLine();

if (line.Substring(1, 2) == "HP")
{
    Console.WriteLine(line.Remove(1,2));
}
else
    Console.WriteLine(false);

// problem #38 - Write a C# program to get a string of two characters from a given string.
// The first and second characters of the given string must be "P" and "H", so PHP will be "PH".

string str1 = "PHP Tutorial";

var result = "";

if (str1.Length >= 1 && str1[0] == 'P')
    result += str1[0];

if (str1.Length >= 2 && str1[1] == 'H')
    result += str1[1];

Console.WriteLine(result);

// problem #39 - Write a C# program to find the largest and lowest values from three integer values.

int[] number = new int[3];
Console.Write("Input a first number: ");
number[1] = int.Parse(Console.ReadLine());
Console.Write("Input a second number: ");
number[2] = int.Parse(Console.ReadLine());
Console.Write("Input a third number: ");
number[3] = int.Parse(Console.ReadLine());

int biggest = number[0];
int lowest = number[0];

for (int i = 1; i < 3; i++)
{
    if(biggest < number[i])
    {
        biggest = number[i];
    }
    if(lowest > number[i])
    {
        lowest = number[i];
    }
}
Console.WriteLine(biggest);

// problem #40 - Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.

Console.Write("Input a first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = int.Parse(Console.ReadLine());

int nearest = 20 - number1;
if(nearest > (20 - number2))
{
    nearest = number2;
}

if(number1 == number2)
{
    Console.WriteLine(0);
}
else Console.WriteLine($"Nearest value = {nearest}");

// problem #41 - Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.

Console.Write("Input a string (contains at least one 'w' char) :  ");
string line = Console.ReadLine();
int counter = 0;
for (int i = 0; i < line.Length; i++)
{
    if (line[i] == 'w')
    {
        counter++;
    }
}
Console.WriteLine($"Test the string contains 'w' character between 1 and 3 times: {(counter < 4 && counter > 0)}");

// problem #42 - Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters,
// make the whole string in upper case.

Console.Write("Input a string:  ");
string line = Console.ReadLine();

if(line.Length < 5)
{
    Console.WriteLine(line.ToUpper());
}
else Console.WriteLine(false);

// problem #43 - Write a C# program to check if a given string starts with "w" and is immediately followed by two "ww".

Console.Write("Input a string:  ");
string line = Console.ReadLine();

Console.WriteLine(line[0] == 'w' && line.Substring(1, 2) == "ww");

// problem #44 - Write a C# program to create a string of every other character (odd position) from the first position of a given string.

Console.Write("Input a string:  ");
string line = Console.ReadLine();

for (int i = 0; i < line.Length ; i+=2)
{
    Console.Write(line[i]);
}

// problem #45 - Write a C# program to count a specified number in a given array of integers.

Console.Write("Input a number: ");
int number1 = int.Parse(Console.ReadLine());
int counter = 0;
int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number1)
    {
        counter++;
    }
}

Console.WriteLine($"Number of {number1} present in the said array: {counter}");
*
// problem #46 - Write a C# program to check if a number appears as the first or last element of an array of integers. The array length is 1 or more.

Console.Write("Input a number: ");
int number1 = int.Parse(Console.ReadLine());
int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
Console.WriteLine(number1 == array[0] || number1 == array[array.Length-1]);

// problem #47 - Write a C# program to compute the sum of all the elements of an array of integers.

int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
Console.WriteLine(sum);

// problem #48 - Write a C# program that checks if the first element and the last element of an array of integers are equal. The array length is 1 or more.

int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
Console.WriteLine(array[0] == array[array.Length-1]);

// problem #49 - Write a C# program to check if the first or the last element of the two arrays (length 1 or more) are equal.

int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
int[] array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
Console.WriteLine(array2[0] == array1[0] || array2[array2.Length-1] == array1[array1.Length-1]);

// problem #50 - Write a C# program to rotate an array (length 3) of integers in the left direction.

int[] array = {1, 2, 8, 9 ,10 ,11};
int hold = array[0];
for (int i = 0; i < array.Length-1; i++)
{
    array[i] = array[i+1];
}
array[array.Length - 1] = hold;
Console.WriteLine("After Rotation: ");
for (int i = 0;i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

// problem #51 - Write a C# program to get the largest value between the first and last element of an array (length 3) of integers.

int[] array = {1, 2, 5, 7, 8 };
int biggest = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (biggest < array[i])
    {
        biggest = array[i];
    }
}
Console.WriteLine($"Highest value between first and last values of the said array: {biggest}");

// problem #52 - Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.

int[] array1 = { 1, 2, 5 }, array2 = {0, 3, 8 }, array3 = {-1, 0, 2 };
int[] newarray = { array1[1], array2[1], array3[1] };
Console.WriteLine("{0}",string.Join(", ", newarray));
/*
// problem #53 - Write a C# program to check if an array contains an odd number.

int[] array = { 2, 4, 7, 8, 6 };
bool odd = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        odd = true;
    }
}
Console.WriteLine(odd);

// problem #54 - Write a C# program to get the century of a year.

int centuryFromYear(int year)
{
    // Calculation of the century by dividing the year by 100 and adding 1 if there's a remainder
    return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
}

Console.WriteLine(centuryFromYear(1799) == 18);
Console.WriteLine(centuryFromYear(1900) == 19);
Console.WriteLine(centuryFromYear(1901) == 19);
Console.WriteLine(centuryFromYear(1901) == 20);
Console.WriteLine(centuryFromYear(1806) == 19);
Console.WriteLine(centuryFromYear(1568) == 20);
Console.WriteLine(centuryFromYear(2010) == 21); 

// problem #55 - Write a C# program to find the pair of adjacent elements that has the largest product of the given array.

int adjacentproduct(int[] array)
{
    int largest = array[0] * array[1];

    for (int i = 1; i < array.Length; i++)
    {
        int product = array[i]*array[i-1];
        if(product > largest)
        {
            largest = product;
        }
    }
        return largest;
}

int[] array = { 2, 4, 2, 6, 9, 9 };
Console.WriteLine(adjacentproduct(array) == 81);

// problem #56 - Write a C# program to check if a given string is a palindrome or not.

using System.Diagnostics.Metrics;

bool palindrome(string input)
{
    char[] a = input.ToCharArray();
    Array.Reverse(a);
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == a[i])
        {
            counter++;
        }
    }
    if(counter == input.Length)
    {
        return true;
    }
    return false;
}

Console.WriteLine(palindrome("aaa"));
Console.WriteLine(palindrome("abc"));
Console.WriteLine(palindrome("madam"));  
Console.WriteLine(palindrome("1234"));
Console.WriteLine(palindrome("soyyos"));

// problem #57 - Write a C# program to find the pair of adjacent elements that has the highest product of an array of integers.

int adjacentproduct(int[] array)
{
    int largest = array[0] * array[1];

    for (int i = 1; i < array.Length; i++)
    {
        int product = array[i] * array[i - 1];
        if (product > largest)
        {
            largest = product;
        }
    }
    return largest;
}

int[] array = { 2, 4, 2, 6, 9, 9 };
Console.WriteLine(adjacentproduct(array));

// problem #58 - Write a C# program that accepts a list of integers and checks how many integers are needed to complete the range.
// Sample Example[1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list. So output will be 4.

using System.Diagnostics.Metrics;

int checker(int[] array)
{
    int missing = 0;
    int min = array[0], max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
        if(max < array[i]) max = array[i];
    }
    for (int i = min; i <= max; i++)
    {
        int counted = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] == i)
            {
                counted++;
            }
        }
        if(counted == 0)
        {
            missing++;
        }
    }
    return missing;
}

int[] array = { 1, 3, 4, 7, 9 };
Console.WriteLine(checker(array));

// problem #59 - Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array.

    bool test_increasing(int[] int_seq)
{
    int x = 0;
    for (int i = 0; i < int_seq.Length - 1; i++)
    {
        if (int_seq[i] >= int_seq[i + 1])
            x++; 

        if (i + 2 < int_seq.Length && int_seq[i] >= int_seq[i + 2])
            x++; 
    }

    return x <= 2;
}

Console.WriteLine(test_increasing(new int[] { 1, 3, 5, 6, 9 }));
Console.WriteLine(test_increasing(new int[] { 0, 10 }));
Console.WriteLine(test_increasing(new int[] { 1, 3, 4, 34 }));

// problem #60 - Write a C# program to calculate the sum of all integers in a rectangular matrix. However, exclude those integers located below an integer of value 0.

int sum(int[,] matrix)
{
    int total = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) { 
            total += matrix[i, j];
        }
    }
    return total; 
}

int[,] matrix1 = { { 1, 2, 3, 3 }, { 4, 5, 6, 4 }, { 1, 1, 3, 4} };
int[,] matrix2 = { { 1, 2, 3 }, { 8, 9, 10 } };
int[,] matrix3 = { { 1, 1}, { 2, 2}, { 3, 3},{ 4, 4} };

Console.WriteLine(sum(matrix1));
Console.WriteLine(sum(matrix2));
Console.WriteLine(sum(matrix3));

// problem #61 - Write a C# program to sort the integers in ascending order without moving the number -5.

void sorter(int[] sorted)
{
    for (int i = 1; i < sorted.Length; i++)
    {
        for (int j = 0; j  < sorted.Length; j++)
        {
            if (sorted[i] < sorted[j] && sorted[j] != -5 && sorted[i] != -5)
            {
                int swap = sorted[j];
                sorted[j] = sorted[i];
                sorted[i] = swap;
            }
        }
    }
}

int[] x = { -5, 236, 120, 70, -5, -5, 698, 280 };
sorter(x);
for (int i = 0; i < x.Length; i++)
{
    Console.WriteLine(x[i]);
}

// problem #62 - Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string.
// It should also remove the parentheses from the given string.

string reverse(string str)
{
    int lid = str.LastIndexOf('(');

    // If no '(' is found, return the original string
    if (lid == -1)
    {
        return str;
    }
    else
    {
        // Find the corresponding closing parenthesis ')' for the found '('
        int rid = str.IndexOf(')', lid);

        // Recursively process the substring inside the parentheses and reverse it
        return reverse(
            str.Substring(0, lid) +
            new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) +
            str.Substring(rid + 1)
        );
    }
}
string str = "gf(la)f";
Console.WriteLine(reverse(str));

// problem #63 - Write a C# program to check if a given number is present in an array of numbers.

bool check_if_contain(int[] arr, int n)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n)
        {
            return true;
        }
    }
    return false;
}
int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(check_if_contain(arr, 3));
Console.WriteLine(check_if_contain(arr, 8));

// problem #64 - Write a C# Sharp program to get the file name (including extension) from a given path.

using System.Runtime.InteropServices;

string get_Name(string file_path)
{
    return file_path.Split('/').Last();
}

string file1 = "c:/csharp/ex/test.cpp", file2 = "c:/movies/abc.mp4";
Console.WriteLine(get_Name(file1));
Console.WriteLine(get_Name(file2));

// problem #65 - Write a C# Sharp program to multiply all elements of a given array of numbers by array length.

void multiply_by_length(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= arr.Length;
    }
}

int[] arr = { 1, 2, 3, 4, 5 };
multiply_by_length(arr);

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

// problem #66 - Write a C# Sharp program to find the minimum value from two numbers given to you, represented as a string.

string min(string str1, string str2)
{
    if (int.Parse(str1) < int.Parse(str2))
    {
        return str1;
    }
    else return str2;
}

Console.WriteLine(min("23","32"));
Console.WriteLine(min("12","21"));

// problem #67 - Write a C# Sharp program to create a coded string from a given string, using a specified formula.
// Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'. 

string replace(string str1)
{
    return str1.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8");
}

Console.WriteLine(replace("PHP"));
Console.WriteLine(replace("JAVASCRIPT"));

// problem #68 - Write a C# Sharp program to count a specified character (both cases) in a given string.

int count(string str, char c)
{
    int counter = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == char.ToUpper(c) || str[i] == char.ToLower(c)) {  counter++; }
    }
    return counter;
}
Console.WriteLine(count("Helloh", 'h'));

// problem #69 - Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters.

bool check(string str)
{
    return (str == str.ToLower() || str == str.ToUpper());
}

Console.WriteLine(check("Hello World"));
Console.WriteLine(check("hello world"));

// problem #70 - Write a C# Sharp program to remove the first and last elements from a given string.

string remove(string str)
{
    return str = str.Substring(1, str.Length - 2);
}

Console.WriteLine(remove("Hello World"));

// problem #71 - Write a C# Sharp program to check if a given string contains two similar consecutive letters.

bool check(string str)
{
    for (int i = 1; i < str.Length; i++)
    {
        if (str[i] == str[i - 1])
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine(check("Hello World"));
Console.WriteLine(check("Potato"));

// problem #72 - Write a C# Sharp program to check whether the average value of the elements of a given array of numbers is a whole number or not.

bool check_whole(int[] arr)
{
    double average = 0;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = (sum + arr[i]);
    }
    average = (double)sum / arr.Length;
    if (average % 1 != 0.0)
    {
        return false;
    }
    return true;
}

int[] arr1 = { 1, 2, 3, 5, 4, 2, 3, 4 }, arr2 = { 2, 4, 2, 6, 4, 8 };
Console.WriteLine(check_whole(arr1));
Console.WriteLine(check_whole(arr2));

// problem #73 - Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order.

string alphabetical_order(string str)
{
    return new string(str.OrderBy(x => x).ToArray());

}
Console.WriteLine(alphabetical_order("Heyoyoo"));
Console.WriteLine(alphabetical_order("Hello World"));

// problem #74 - Write a C# Sharp program to check the length of a given string is odd or even. Return 'Odd length' if the string length is odd otherwise 'Even length'.

string check(string str)
{
    if(str.Length % 2 == 0)
    {
        return "Even Length";
    }

    return "Odd Length";
}

Console.WriteLine(check("Hello World"));
Console.WriteLine(check("heyo"));

// problem #75 - Write a C# Sharp program that takes a positive number and returns the nth odd number.

int odd_number(int number)
{
    return (number * 2 -2) + 1;
}

Console.WriteLine(odd_number(100));

// problem #76 - Write a C# Sharp program to get the ASCII value of a given character.

int ascii_number(char c)
{
    return (int)c;
}

Console.WriteLine(ascii_number('1'));
Console.WriteLine(ascii_number('A'));
Console.WriteLine(ascii_number('a'));
Console.WriteLine(ascii_number('#'));

// problem #77 - Write a C# Sharp program to check whether a word is plural or not.

bool check(string str)
{
    return str[str.Length - 1] == 's';
}

Console.WriteLine("Is 'Exercise' plural? " + check("Exercise"));

Console.WriteLine("Is 'Exercises' plural? " + check("Exercises"));

Console.WriteLine("Is 'Books' plural? " + check("Books"));

Console.WriteLine("Is 'Book' plural? " + check("Book"));

// problem #78 - Write a C# Sharp program to find the sum of squares of elements in a given array of integers.

int sum_squares(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i]*arr[i];
    }
    return sum;
}

int[] nums = { 1, 2, 3 }, nums1 = { -2, 0, 3, 4 };
Console.WriteLine("Sum of squares of elements of the said array: " + sum_squares(nums));
Console.WriteLine("Sum of squares of elements of the said array: " + sum_squares(nums1));

// problem #79 - Write a C# Sharp program to convert an integer to a string and a string to an integer.

string n_str = "50";
Console.WriteLine("Original value and type: " + n_str + ",  " + n_str.GetType());
int result = test_str_to_int(n_str);
Console.WriteLine("Convert string to integer:");
Console.WriteLine("Return value and type: " + result + ",  " + result.GetType());
int n = 122;
Console.WriteLine("\nOriginal value and type: " + n + ",  " + n.GetType());
string result1 = test_int_to_str(n);

Console.WriteLine("Convert integer to string:");
Console.WriteLine("Return value and type: " + result1 + ",  " + result1.GetType());
int test_str_to_int(string str)
{
    return int.Parse(str);
}
string test_int_to_str(int n)
{
    return n.ToString();
}

// problem #80 - Write a C# Sharp program to convert all the values of a given array of mixed values to string values.

object[] mixedArray = new object[5];
mixedArray[0] = 25;
mixedArray[1] = "Anna";
mixedArray[2] = false;
mixedArray[3] = System.DateTime.Now;
mixedArray[4] = 112.22;

Console.WriteLine("Printing original array elements and their types:");
for (int i = 0; i < mixedArray.Length; i++)
{
    Console.WriteLine("Value-> " + mixedArray[i] + " :: Type-> " + mixedArray[i].GetType());
}
string[] new_nums = test(mixedArray);

Console.WriteLine("\nPrinting array elements and their types after conversion:");
for (int i = 0; i < new_nums.Length; i++)
{
    Console.WriteLine("Value-> " + new_nums[i] + " :: Type-> " + new_nums[i].GetType());
}
string[] test(object[] nums)
{
    return Array.ConvertAll(nums, x => x.ToString());
}

// problem #81 - Write a C# Sharp program to swap a two-digit number and check whether the given number is greater than its swap value.

bool check(int number)
{
    int first = number / 10;
    int second = number % 10;
    int swaped = second * 10 + first;
    if(swaped < number)
    {
        return true;
    }
    return false;
}

Console.WriteLine("Input an integer value:");
int read = int.Parse(Console.ReadLine());
Console.WriteLine("Check whether the said value is greater than its swap value: " + check(read));

// problem #82 - Write a C# Sharp program to remove all non-letter characters from a given string.

using System;
using System.Text;

string remove_non_letter(string str)
{
    StringBuilder result = new StringBuilder();

    foreach (char c in str)
    {
        if (char.IsLetter(c))
        {
            result.Append(c);
        }
    }

    return result.ToString();
}

Console.WriteLine(remove_non_letter("2^sdfds*^*^jlljdslfnoswje34u230sdfds984"));

// problem #83 - Write a C# Sharp program to remove all vowels from a given string.

using System.Text;

string remove_vowels(string str)
{
    StringBuilder result = new StringBuilder();
    string vowels = "AEIOUaeiou";

    foreach (char c in str)
    {
        if (!vowels.Contains(c))
        {
            result.Append(c);
        }
    }
    return result.ToString();
}

Console.WriteLine(remove_vowels("Hello World"));

// problem #84 - Write a C# Sharp program to get the index number of all lower case letters in a given string.

void index_lower_case(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsLower(str[i])) {
            Console.Write($"{i} ");
        }
    }
}

index_lower_case("Hello World");

// problem #85 - Write a C# Sharp program to find the cumulative sum of an array of numbers.
// A cumulative sum is a sequence of partial sums of a given sequence. For example, the cumulative sums of the sequence {x, y, z,...}, are x, x+y , x+y+z

void cumulative_sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
        arr[i] = sum;
    }
}

int[] arr = { 1, 3, 4, 5, 6, 7 };
cumulative_sum(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}

// problem #86 - Write a C# Sharp program to get the number of letters and digits in a given string.

void give_numbers(string str)
{
    int lettercount = 0, numbercount = 0;
    foreach (var item in str)
    {
        if (char.IsLetter(item))
        {
            lettercount++;
        }
        if (char.IsDigit(item))
        {
            numbercount++;
        }
    }
    Console.WriteLine($"Original String: {str}");
    Console.WriteLine($"Number of Letters: {lettercount}, Number of Digits: {numbercount}");
}

give_numbers("Python 3.0");
give_numbers("dsfkaso230samdm2423sa");

// problem #87 - Write a C# Sharp program to reverse a Boolean value.

bool reverse(bool b)
{
    return !b;
}

bool cat = false;
bool dog = true;

// Displaying the original value of the 'cat' variable
Console.WriteLine("Original value: " + cat);

// Displaying the reversed value of 'cat' using the 'test' method
Console.WriteLine("Reverse value: " + reverse(cat));

// Displaying the original value of the 'dog' variable
Console.WriteLine("Original value: " + dog);

// Displaying the reversed value of 'dog' using the 'test' method
Console.WriteLine("Reverse value: " + reverse(dog));

// problem #88 - Write a C# Sharp program to find the sum of the interior angles (in degrees) of a given polygon. Input the number of straight lines.

Console.WriteLine("Input number of straight lines of the polygon:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Sum of the interior angles (in degrees) of the said polygon: " + degree(n));

int degree(int num)
{
    return 180 * (num - 2);
}

// problem #89 - Write a C# Sharp program to count positive and negative numbers in a given array of integers.

void give_numbers(int[] arr)
{
    int positivecount = 0, negativecount = 0;
    foreach (var item in arr)
    {
        if (item < 0)
        {
            negativecount++;
        }
        if (item > 0)
        {
            positivecount++;
        }
    }
    Console.Write("Original String: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine($"Number of Positive Numbers: {positivecount}, Number of Negative Numbers: {negativecount}");
}

int[] arr = { 10, -11, 12, -13, 14, -18, 19, -20 }, arr2 = { -4, -3, -2, 0, 3, 5, 6, 2, 6 };

give_numbers(arr);
give_numbers(arr2);

// problem #90 - Write a C# Sharp program to count the number of ones and zeros in the binary representation of a given integer.

void give_numbers(int number)
{
    int onescount= 0, zeroscount = 0;
    int sum = 0;
    string str = Convert.ToString(number, 2);

    for (int i = 0; i < str.Length; i++)
    {
        sum += (int)char.GetNumericValue(str[i]);;
    }
    onescount = sum;
    zeroscount = str.Length - sum;

    Console.WriteLine($"Original Number: {number}, Binary Number: {str}");
    Console.WriteLine($"Number of Ones: {onescount}, Number of Zeros: {zeroscount}");
}

give_numbers(12);
give_numbers(1234);

// problem #91 - Write a C# Sharp program to remove all values except integer values from a given array of mixed values.

object[] mixedArray = new object[6];
mixedArray[0] = 25;
mixedArray[1] = "Anna";
mixedArray[2] = false;
mixedArray[3] = System.DateTime.Now;
mixedArray[4] = -112;
mixedArray[5] = -34.67;

Console.WriteLine("Original array elements:");
for (int i = 0; i < mixedArray.Length; i++)
{
    Console.Write(mixedArray[i] + " ");
}

int[] new_nums = test(mixedArray);
Console.WriteLine("\n\nAfter removing all the values except integer values from the said array of mixed values:");
for (int i = 0; i < new_nums.Length; i++)
{
    Console.Write(new_nums[i] + " ");
}
int[] test(object[] nums)
{
    return nums.OfType<int>().ToArray();
}

// problem #92 - Write a C# Sharp program to find the next prime number of a given number. If the given number is a prime number, return the number.

int next_prime(int number)
{
    if (is_prime(number))
    {
        return number;
    }

    while (!is_prime(number))
    {
        number++;
    }

    return number;
}

bool is_prime(int number)
{
    int counter = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            counter++;
        }
    }
    if (counter == 2)
    {
        return true;
    }
    return false;
}
Console.WriteLine(next_prime(120));
Console.WriteLine(next_prime(321));
Console.WriteLine(next_prime(43));
Console.WriteLine(next_prime(4433));

// problem #93 - Write a C# Sharp program to calculate the square root of a given number. Return the integer part of the result instead of using
// any built-in functions.

int square_root(int number)
{
    int sq = 1;
    while (sq < number / sq)
    {
        sq++;
    }

    if (sq > number / sq)
        return sq - 1;
    return sq;
}

int n = 120;
Console.WriteLine("Original number: " + n);

Console.WriteLine("Square root of the said number: " + square_root(n));

n = 225;
Console.WriteLine("\nOriginal number: " + n);
Console.WriteLine("Square root of the said number: " + square_root(n));

n = 335;
Console.WriteLine("\nOriginal number: " + n);
Console.WriteLine("Square root of the said number: " + square_root(n));

// problem #94 - Write a C# program that finds the longest common prefix from an array of strings.

string[] arr_strings1 = { "Padas", "Packed", "Pace", "Pacha" };
Console.WriteLine("Original strings: " + $"{string.Join(", ", arr_strings1)}");
Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings1));

string[] arr_strings2 = { "Jacket", "Joint", "Junky", "Jet" };
Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings2)}");
Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings2));

string[] arr_strings3 = { "Bort", "Whang", "Yarder", "Zoonic" };
Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings3)}");
Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings3));
string test(string[] arr_strings)
{
    if (arr_strings.Length == 0 || Array.IndexOf(arr_strings, "") != -1)
        return "";
    string result = arr_strings[0];
    int i = result.Length;
    foreach (string word in arr_strings)
    {
        int j = 0;
        foreach (char c in word)
        {
            if (j >= i || result[j] != c)
                break;
            j += 1;
        }
        i = Math.Min(i, j);
    }

    return result.Substring(0, i);
}

// problem #95 - Write a C# programme to check the said string is valid or not. The input string will be valid when open brackets and closed brackets are same type of brackets.
// Or open brackets will be closed in proper order.

string text = "<>";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

text = "<>()[]{}";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

text = "(<>";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

text = "[<>()[]{}]";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
bool test(string s)
{

    Stack<char> ch = new Stack<char>();

    foreach (var item in s.ToCharArray())
    {
        if (item == '(')
            ch.Push(')');
        else if (item == '<')
            ch.Push('>');
        else if (item == '[')
            ch.Push(']');
        else if (item == '{')
            ch.Push('}');
        else if (ch.Count == 0 || ch.Pop() != item)
            return false;
    }
    return ch.Count == 0;
}

// problem #96 - Write a C# Sharp program to check whether all characters in a string are the same. Return true if all the characters in the string are the same, otherwise false.

bool are_all_same(string str)
{
    char same = str[0];
    for (int i = 1; i < str.Length; i++)
    {
        if(same != str[i])
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine(are_all_same("aaa"));
Console.WriteLine(are_all_same("abcd"));
Console.WriteLine(are_all_same("333"));
Console.WriteLine(are_all_same("2342342"));

// problem #97 - Write a C# Sharp program to check if a given string (floating point and negative numbers included) is numeric or not. Return True if the string is numeric, otherwise false.

bool is_numeric(string str)
{
    bool hasDecimalPoint = false;

    for (int i = 0; i < str.Length; i++)
    {
        if (!char.IsDigit(str[i]))
        {
            if (str[i] == '.' && !hasDecimalPoint)
            {
                hasDecimalPoint = true;
            }
            else
            {
                return false;
            }
        }
    }

    return true;
}

Console.WriteLine(is_numeric("123"));
Console.WriteLine(is_numeric("123.33"));
Console.WriteLine(is_numeric("33/33"));
Console.WriteLine(is_numeric("234234d2"));

// problem #98 - Write a C# Sharp program to create and display all prime numbers in strictly descending decimal digit order.

bool is_prime(int number)
{
    int counter = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            counter++;
        }
    }
    if (counter == 2)
    {
        return true;
    }
    return false;
}
int counter = 0;

int digit_num(int number)
{
    int counter = 0;
    while (true)
    {
        if (number / 10 == 0) {
            break;
        }
        else {
            number /= 10;
            counter++;
        }
    }
    counter++;
    return counter;
}

bool is_ascending(int number)
{
    string a = number.ToString();
    for (int i = 1; i < a.Length; i++) {
        if (a[i-1] <= a[i])
        {
            return false;
        }
    }
    return true;
}


for (int i = 0; counter <= 64; i++)
{
    if (is_prime(i))
    {
        if (is_ascending(i))
        {
            //Console.Write($"{i} ");
            Console.Write("{0,8}{1}", i, ++counter % 5 == 0 ? "\n" : " ");
            //counter++;
        }
    }
}

// problem #99 - Write a C# Sharp program to create and display all prime numbers in strict ascending decimal digit order.

bool is_prime(int number)
{
    int counter = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            counter++;
        }
    }
    if (counter == 2)
    {
        return true;
    }
    return false;
}
int counter = 0;

int digit_num(int number)
{
    int counter = 0;
    while (true)
    {
        if (number / 10 == 0)
        {
            break;
        }
        else
        {
            number /= 10;
            counter++;
        }
    }
    counter++;
    return counter;
}

bool is_ascending(int number)
{
    string a = number.ToString();
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i - 1] >= a[i])
        {
            return false;
        }
    }
    return true;
}


for (int i = 0; counter <= 64; i++)
{
    if (is_prime(i))
    {
        if (is_ascending(i))
        {
            //Console.Write($"{i} ");
            Console.Write("{0,8}{1}", i, ++counter % 5 == 0 ? "\n" : " ");
            //counter++;
        }
    }
}

// problem #100 - Write a C# Sharp program to check the equality comparison (value and type) of two parameters. Return true if they are equal otherwise false.

bool equal(object a, object b)
{
    if (!a.Equals(b))
    {
        return false;
    }
    if (!a.GetType().Equals(b.GetType()))
    {
        return false;
    }
    return true;
}

string a1 = "AAA", b1 = "BBB", b4 = "true";
bool a2 = true, b2 = false;
int a3 = 10, b3 = 10;

Console.WriteLine(a1 + " and " + b1 + " // Equality Check => " + equal(a1,b1));
Console.WriteLine(a2 + " and " + b2 + " // Equality Check => " + equal(a2, b2));
Console.WriteLine(a2 + " and " + b4 + " // Equality Check => " + equal(a2, b4));
Console.WriteLine(a3 + " and " + b3 + " // Equality Check => " + equal(a3, b3));


// problem #101 - Write a C# Sharp program to calculate the value of e.
// Note: e is also known as Euler's number and Napier's constant

double EPSILON = 1.0e-15;
ulong fact = 1;
double e = 2.0;
double e0;
uint n = 2;

do
{
    e0 = e;
    fact *= n++;
    e += 1.0 / fact;
} while (Math.Abs(e - e0) >= EPSILON);

Console.WriteLine("e = {0:F15}", e);

// problem #102 - Write a C# Sharp program to create an identity matrix. 

int[,] create_matrix(int number)
{
    int[,] identity = new int[number,number];
    int counter = 0;
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j < number; j++) {
            identity[i,j] = 0;  
        }
        identity[i, counter] = 1;
        counter++;
    }
    return identity;
}

Console.Write("Input a number: ");
int number = int.Parse(Console.ReadLine());
int[,] identity = create_matrix(number);
for (int i = 0; i < identity.GetLength(0); i++)
{
    for (int j = 0;j < identity.GetLength(1); j++) {
        Console.Write(identity[i, j] + " ");
    }
    Console.WriteLine();
}

// problem #103 - Write a C# Sharp program to sort characters in a given string (uppercase/lowercase letters and numbers). Return the newly sorted string.

string text = "AAAbfed231";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Sorted string: " + test(text));

text = " ";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Sorted string: " + test(text));

text = "Python";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Sorted string: " + test(text));

text = "W3resource";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Sorted string: " + test(text));


static string test(string text)
{
    bool flag = string.IsNullOrWhiteSpace(text);

    if (flag)
        return "Blank string!";

    var text_nums = text.Where(char.IsDigit).OrderBy(el => el).ToList();

    var text_chars = text.Where(char.IsLetter)
        .Select(el => new { l_char = char.ToLower(el), _char = el })
        .OrderBy(el => el.l_char)
        .ThenByDescending(el => el._char)
        .ToList();

    return new string(text_chars.Select(el => el._char).Concat(text_nums).ToArray());
}
*/
// problem #104 - Write a C# Sharp program to compare the equality of three integers and calculate how many integers have the same value.

int x = 1, y = 2, z = 3;
Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);
Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));

x = 1; y = 3; z = 3;
Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);
Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));

x = 3; y = 3; z = 3;
Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);
Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));
    
static int test(int x, int y, int z)
{
    return (x == y && y == z) ? 3 : (x != y && y != z && x != z) ? 0 : 2;
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_5___c_
{
    public class Calculator
    {
        public int[] arr1 { get; set; }
        public int[] arr2 { get; set; }
        public int length { get; set; }
        public Calculator(int l)
        {
            length = l;
            arr1 = new int[l];
            arr2 = new int[l];
        }

        public int[] Calculate(char c)
        {
            int[] a = new int[length];
            switch (c)
            {
                case '+':
                    for (int i = 0; i < length; i++)
                    {
                        a[i] = arr1[i] + arr2[i];
                    }
                    break;
                case '-':
                    for (int i = 0; i < length; i++)
                    {
                        a[i] = arr1[i] - arr2[i];
                    }
                    break;
                case '/':
                    try
                    {
                        for (int i = 0; i < length; i++)
                        {
                            a[i] = arr1[i] / arr2[i];
                        }
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Division by zero not allowed");
                    }
                    break;
                case '*':
                    for(int i = 0; i < length; i++)
                    {
                        a[i] = arr1[i] * arr2[i];
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Value Entered");
                    break;
            }
            return a;
        }
    }
}

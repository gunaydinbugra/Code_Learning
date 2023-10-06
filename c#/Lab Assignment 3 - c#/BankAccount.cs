using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_3___c_
{
    public class BankAccount
    {
        public int balance = 0;
        public void setbalance(int a)
        {
            balance = a;
        }
        public int getbalance()
        {
            return balance;
        }
        public void deposit(int a)
        {
            balance += a;
        }
        public void withdraw(int a)
        {
            balance -= a;
        }
        
      
    }
}

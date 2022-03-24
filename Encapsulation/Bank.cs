using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Encapsulation
{
    internal class Bank
    {
        private double balance = 100000;//Private Variable
       
        public void Withdraw(double bal)
        {
            balance = balance - bal;
        }

        public void Credit(double b)
        {
            balance = balance + b;
        }

        public double getBalance()
        {
            return balance;
        }
    }
}

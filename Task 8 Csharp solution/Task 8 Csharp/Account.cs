using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    internal struct Account
    {
        private int accountid;
        private string accountholder;
        private double balance;
        
        public int AccountId {
            get { return accountid; }
            set { accountid = value; }
        }
        public string AccountHolder {
            get { return accountholder; }
            set { accountholder = value; }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Salary can't be negative");
                }
            }
        }

        public Account(int _accountid, string _accountholder, double _balance)
        {
            accountholder = _accountholder;
            balance = _balance >= 0 ? _balance : 0;
            accountid = _accountid;
        }

        public override string ToString()
        {
            return $"Account ID: {AccountId}, Holder: {AccountHolder}, Balance: {Balance}"; 
        }
        }
    }


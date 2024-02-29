using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

        public class BankAccount
        {
            private decimal balance;

            public BankAccount(decimal initialBalance)
            {
                if (initialBalance < 0)
                {
                    throw new ArgumentException("Initial balance cannot be negative.");
                }

                balance = initialBalance;
            }

            public decimal Balance
            {
                get { return balance; }
            }

            public void Deposit(decimal amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentException("Deposit amount cannot be negative.");
                }

                balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentException("Withdrawal amount cannot be negative.");
                }

                if (amount > balance)
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }

                balance -= amount;
            }
        }

    }


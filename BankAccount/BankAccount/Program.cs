using System;

namespace BankAccount
{
    class Bank
    {
        private string FullName, AccountNumber;
        public int Balance, ATMPin;

        public Bank(string fullName, string accountNumber)
        {
            FullName = fullName;
            AccountNumber = accountNumber;
        }

        public string GetFullName()
        {
            return FullName;
        }
        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        public string Deposit(int amount)
        {
            Balance += amount;
            return "Deposit Successful.\nTotal Balance Rs. " + Balance;
        }
        public string Withdrawal(int amount)
        {
            if (amount > Balance)
                return "You don't have sufficient Balance.";
            else
            {
                Balance -= amount;
                return "Withdrawal Successful.\nTotal Balance Rs. " + Balance;
            }
        }
        public string IssueATM()
        {
            if (ATMPin == 0)
            {
                Random random = new Random();
                string number = null;
                for (int i = 0; i < 4; i++)
                    number += random.Next(0, 9).ToString();
                ATMPin = int.Parse(number);
                return "ATM is Issued Successfully\nYou Pin :: " + ATMPin;
            }
            else
                return "You have already ATM Card.";
        }
        public virtual string SimpleInterest(int amount, int peroride)
        {
            return "";
        }
    }
    class Saving : Bank
    {
        public Saving(string fullName, string accountNumber) : base(fullName, accountNumber) { }
        public override string SimpleInterest(int amount, int periode)
        {
            float rate = 10f;
            string message = "Saving Account : Simple Interset(rate : " + rate + "%)\n";
            double simpleInterst = (amount * periode * rate) / 100;
            message += "Simple Interest : " + simpleInterst;
            return message;
        }
    }
    class Current : Bank
    {
        public Current(string fullName, string accountNumber) : base(fullName, accountNumber) { }
        public override string SimpleInterest(int amount, int periode)
        {
            float rate = 20f;
            string message = "Current Account : Simple Interset(rate : " + rate + "%)\n";
            double simpleInterst = (amount * periode * rate) / 100;
            message += "Simple Interest : " + simpleInterst;
            return message;
        }
    }
    class Account
    {
        private Bank NewAccount;
        public Account(Bank newAccount)
        {
            NewAccount = newAccount;
        }
        public string Deposit(int amount)
        {
            return NewAccount.Deposit(amount);
        }
        public string Withdrawal(int amount)
        {
            return NewAccount.Withdrawal(amount);
        }
        public string IssueATM()
        {
            return NewAccount.IssueATM();
        }
        public string SimpleInterest(int amount, int period)
        {
            return NewAccount.SimpleInterest(amount, period);
        }
        public string ShowInformation()
        {
            string info = null;

            info = "Account Type : " + NewAccount.GetType().Name + "\n";
            info += "Name : " + NewAccount.GetFullName() + "\n";
            info += "Account No. : " + NewAccount.GetAccountNumber() + "\n";
            info += "Total Balance : " + NewAccount.Balance + "\n";
            info += (NewAccount.ATMPin == 0) ? ("You Don't have ATM Card\n") : ("ATM Pin : " + NewAccount.ATMPin + "\n");

            return info;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome To Online Bank ***");
            Console.WriteLine();

            string fullName, accountNo, accountType;

            Console.Write("Please enter the Full name : ");
            fullName = Console.ReadLine();
            Console.Write("Please enter the Account No. : ");
            accountNo = Console.ReadLine();
            Console.Write("Please enter the Account Type (Saving/Current) :");
            accountType = Console.ReadLine();

            Account account;

            if (accountType.Equals("Saving"))
                account = new Account(new Saving(fullName, accountNo));
            else
                account = new Account(new Current(fullName, accountNo));

            int choice, amount, period;

            Console.WriteLine();
            Console.WriteLine("Bank Transaction");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawal");
                Console.WriteLine("3. Issue ATM");
                Console.WriteLine("4. Simple Interest");
                Console.WriteLine("5. Show Account Information");
                Console.WriteLine("6. Complete Transaction");
                Console.Write("Please enter the choice : ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Deposit");
                        Console.Write("Please enter the amount : ");
                        amount = int.Parse(Console.ReadLine());
                        Console.WriteLine(account.Deposit(amount));
                        break;

                    case 2:
                        Console.WriteLine("Withdrawal");
                        Console.Write("Please enter the amount : ");
                        amount = int.Parse(Console.ReadLine());
                        Console.WriteLine(account.Withdrawal(amount));
                        break;

                    case 3:
                        Console.WriteLine("Issue ATM");
                        Console.WriteLine(account.IssueATM());
                        break;

                    case 4:
                        Console.WriteLine("Simple Interest");
                        Console.Write("Please enter the amount : ");
                        amount = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the period : ");
                        period = int.Parse(Console.ReadLine());
                        Console.WriteLine(account.SimpleInterest(amount, period));
                        break;

                    case 5:
                        Console.WriteLine("Show Account Infromations");
                        Console.WriteLine(account.ShowInformation());
                        break;

                    case 6:
                        Console.WriteLine("Complete Transactions");
                        Console.WriteLine("Thanking for Online Banking.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;

                }
            }
        }
    }
}

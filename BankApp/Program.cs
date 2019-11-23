using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            string firstname;
            string lastname;
            string gender;
            Console.WriteLine("Enter your firstname");
            firstname = Console.ReadLine();
            cust.setFirstName(firstname);
            Console.WriteLine("Enter your lastname");
            lastname = Console.ReadLine();
            cust.setLastName(lastname);
            Console.WriteLine("Enter your gender");
            gender = Console.ReadLine();
            cust.setGender(gender);

            int account_number;
            string account_type;
            string currency;

            Console.WriteLine("Enter account number");
            account_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type either local or foreigner");
            account_type = Console.ReadLine();
            Console.WriteLine("Enter currency");
            currency = Console.ReadLine();
            if (!currency.ToLower().Equals("frw") && !currency.ToLower().Equals("usd") && !currency.ToLower().Equals("euro"))
            {
                Console.WriteLine("Invalid currency");
                return;
            }
            else
            {
                Account acc = new Account(account_number, account_type, currency);
                Console.WriteLine("Please enter 1 for deposit ");
                Console.WriteLine("2 for withdraw");
                int numberChoose;
                numberChoose = Convert.ToInt32(Console.ReadLine());
                if (numberChoose == 1)
                {
                    Console.WriteLine("Enter amount to deposit");
                    double depositAmount;
                    depositAmount = Convert.ToDouble(Console.ReadLine());
                    acc.deposit(depositAmount);
                }
                else if (numberChoose == 2)
                {
                    Console.WriteLine("Enter amount to withdraw");
                    double withdrawAmount;
                    withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    acc.withdraw(withdrawAmount);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}
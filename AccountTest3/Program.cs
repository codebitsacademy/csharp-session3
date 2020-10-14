using System;

namespace AccountTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.Write("Please enter the account name: ");
            account.Name = Console.ReadLine();

            Console.Write("Please enter initial balance: ");
            account.Balance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Account name - {account.Name}");
            Console.WriteLine($"Account balance - {account.Balance:C}");



        }
    }
}

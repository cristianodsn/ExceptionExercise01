using System;
using System.Globalization;
using ExercícioFixacaoExceptions.Entities;
using ExercícioFixacaoExceptions.Entities.Exceptions;

namespace ExercícioFixacaoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account;
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                account = new Account(number, holder, balance, limit);

                Console.Write("Enter amount for withdraw: ");
                double amount = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}

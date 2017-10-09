using System;
using BankApp.Model;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank();
            BankHandler bankHandler = new BankHandler();

            bank.Name = "SP";
            bank.Bic = "ITELFIHH";
            bankHandler.InsertBank(bank);

            bank.Name = "Säästöpankki";
            bankHandler.UpdateBank(bank);

            Console.ReadLine();
        }
    }
}

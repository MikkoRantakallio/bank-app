using System;
using BankApp.Model;
using Ekoodi.Utilities.Bank;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            CustomerHandler custHandler = new CustomerHandler();

            BankAcc account = new BankAcc();
            BankAccountHandler accountHandler = new BankAccountHandler();

            Bank bank = new Bank();
            BankHandler bankHandler = new BankHandler();


            // Insert bank - OK
            bank.Name = "Santander";
            bank.Bic = "ITELFIHH";
            //bankHandler.InsertBank(bank);

            // Update bank name by id -OK
            bank = bankHandler.GetBank(14);
            bank.Name = "STS";
            //bankHandler.UpdateBank(bank);

            // Delete bank by id - OK
            //bankHandler.DeleteBank(12);

            // Insert customer - OK
            cust.BankId = 14;
            cust.FirstName = "Pate";
            cust.LastName = "Postimies";
//            custHandler.InsertCustomer(cust);

            // Insert account - OK
            account.Name = "Sukanvarsi";
            account.CustomerId = cust.Id;
            account.BankId = cust.BankId;
            account.Iban = "345678100204077";
            account.Balance = 955;
  //          accountHandler.InsertBankAccount(account);

            //======================================================

            // Get customer list
            var custList = custHandler.GetCustomers();

            //Update customer
            cust = custHandler.GetCustomer(5);
            cust.LastName = "Meikäläinen";
            custHandler.UpdateCustomer(cust);

            // Delete customer
            //            custHandler.DeleteCustomer(cust.Id);

            // Delete customer account
            accountHandler.DeleteCustomerBankAccount(cust.Id);

            // Get account list
            var accountList = accountHandler.GetAccountList();

            // Delete bank account
            //            accountHandler.DeleteBankAccount(2);

            Console.ReadLine();
        }
    }
}

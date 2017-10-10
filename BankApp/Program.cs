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
            BankAccountHandler accountHandler = new BankAccountHandler();

            Bank bank = new Bank();
            BankHandler bankHandler = new BankHandler();
            /*
                        // Insert bank
                        bank.Name = "SP";
                        bank.Bic = "ITELFIHH";
                        bankHandler.InsertBank(bank);

                        // Update bank name by id
                        bankHandler.UpdateBank(8, "Sampo");

                        // Delete bank by id
                        bankHandler.DeleteBank(10);
                        */

            // Insert customer
            cust.BankId = 2;
            cust.FirstName = "Paavo";
            cust.LastName = "Pesusieni";
            //            custHandler.InsertCustomer(cust);

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

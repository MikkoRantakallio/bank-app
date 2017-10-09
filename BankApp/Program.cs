using System;
using BankApp.Model;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer cust = new Customer();
            CustomerHandler custHandler = new CustomerHandler();

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

            Console.ReadLine();
        }
    }
}

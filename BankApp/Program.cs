using System;
using BankApp.Model;
using Ekoodi.Utilities.Bank;
using System.Collections.Generic;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            CustomerHandler custHandler = new CustomerHandler();

            BankApp.Model.BankAccount account = new BankApp.Model.BankAccount();
            BankAccountHandler accountHandler = new BankAccountHandler();

            Bank bank = new Bank();
            BankHandler bankHandler = new BankHandler();

            BankAccountTransaction transAction = new BankAccountTransaction();
            BankAccountTransactionHandler transHandler = new BankAccountTransactionHandler();

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
            //custHandler.InsertCustomer(cust);

            // Insert account - OK
            account.Name = "Sukanvarsi";
            account.CustomerId = cust.Id;
            account.BankId = cust.BankId;
            account.Iban = "345678100204077";
            account.Balance = 955;
            //accountHandler.InsertBankAccount(account);

            // Get account list - OK
            var accountList = accountHandler.GetAccountList();

            // Get customer list - OK
            var custList = custHandler.GetCustomers();

            //Update customer -OK
            cust = custHandler.GetCustomer(3);
            cust.FirstName = "Jarmo";
            cust.LastName = "Pulukkiin";
            //custHandler.UpdateCustomer(cust);

            //======================================================

            // Delete customer 
            // TODO: SQL Cascade delete
            // custHandler.DeleteCustomer(7);

            // Get customer account list and balances - OK
            cust = custHandler.GetCustomer(3);
            accountList = accountHandler.GetCustomerAccountList(cust.Id);

            Console.WriteLine("Tilin omistaja:\t {0} {1}", cust.FirstName.Trim(), cust.LastName.Trim());

            foreach (BankApp.Model.BankAccount acc in accountList)
            {
                Console.WriteLine("Tilin nimi:\t {0}", acc.Name);
                Console.WriteLine("Tilin saldo:\t {0}", acc.Balance);
            }

            // Insert transactions - OK
            transAction.Iban = "405405393272";
            transAction.Amount = 35.00m;
            transAction.TimeStamp = DateTime.Now;

//            transHandler.InsertTransAction(transAction);

            transAction.Id = 0;
            transAction.Iban = "4540039282";
            transAction.Amount = -135.00m;
            transAction.TimeStamp = DateTime.Now;

//            transHandler.InsertTransAction(transAction);

            transAction.Id = 0;
            transAction.Iban = "405405393272";
            transAction.Amount = -52.00m;
            transAction.TimeStamp = DateTime.Now;

//            transHandler.InsertTransAction(transAction);

            transAction.Id = 0;
            transAction.Iban = "4540039282";
            transAction.Amount = 15.00m;
            transAction.TimeStamp = DateTime.Now;

            //            transHandler.InsertTransAction(transAction);

            // Get customer transactions - OK (?)
            List<BankAccountTransaction> transList = transHandler.GetCustomerTransActions(3);

            foreach(BankAccountTransaction trans in transList)
            {
                Console.WriteLine("Account: {0}\tAmount: {1}\t Time: {2}", trans.Iban.Trim(), trans.Amount, trans.TimeStamp);
            }

            //======================================================

            Console.ReadLine();
        }
    }
}

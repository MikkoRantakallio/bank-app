using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Model
{
    public class CustomerHandler
    {
        public CustomerHandler()
        {
        }

        public void UpdateCustomer(Customer cust)
        {
            using (var context = new BankdbContext())
            {
                var newCust = context.Customer.Find(cust.Id);
                newCust.LastName = cust.LastName;
                context.SaveChanges();
            }
        }

        public void DeleteCustomer(int id)
        {
            using (var context = new BankdbContext())
            {
                var cust = context.Customer.Find(id);
                context.Customer.Remove(cust);
                context.SaveChanges();
            }
        }

        public void InsertCustomer(Customer cust)
        {
            using (var context = new BankdbContext())
            {
                context.Add(cust);
                context.SaveChanges();
            }
        }

        public List<Customer> GetCustomers()
        {
            using (var context = new BankdbContext())
            {
                var custs = context.Customer.ToList();
                return custs;
            }
        }

        public Customer GetCustomer(int id)
        {
            using (var context = new BankdbContext())
            {
                var cust = context.Customer.Find(id);
                return cust;
            }
        }

        public void DeleteCustomerBankAccount(int id)
        {
            using (var context = new BankdbContext())
            {
                var custAcc = context.Customer.Include();
                var acc = custAcc.BankAccount.First();

            }
        }


        /*
        public List<BankAccount> GetCustomerBankAccounts(int id)
        {
            using (var context = new BankdbContext())
            {
                var custAccList = context.Customer.Find(id)
                    .Include()

                return custAccList;
            }
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp.Model
{
    public class CustomerHandler
    {
        public CustomerHandler()
        {
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
    }
}

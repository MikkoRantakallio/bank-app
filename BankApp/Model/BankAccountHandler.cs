using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp.Model
{
    public class BankAccountHandler
    {
        public BankAccountHandler()
        {
        }

        public void DeleteBankAccount(int id)
        {
            using (var context = new BankdbContext())
            {
                var bankAccount = context.BankAccount.Find(id);
                context.BankAccount.Remove(bankAccount);
                context.SaveChanges();
            }
        }

        public void DeleteCustomerBankAccount(int custId)
        {
            using (var context = new BankdbContext())
            {
                var bankAcc = context.BankAccount.Where(bankAccount => bankAccount.CustomerId == custId).FirstOrDefault();
//                context.BankAccount.Remove(bankAcc);
                context.SaveChanges();
            }
        }

        public List<BankAccount> GetAccountList()
        {
            using (var context = new BankdbContext())
            {
                var accounts = context.BankAccount.ToList();
                return accounts;
            }
        }
    }
}

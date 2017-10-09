using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Model
{
    public class BankHandler
    {

        public BankHandler()
        {

        }

        public void InsertBank (Bank bank)
        {
            using (var context = new BankdbContext())
            {
                context.Add(bank);
                context.SaveChanges();
            }
        }

        public void UpdateBank (Bank bank)
        {
            using (var context = new BankdbContext())
            {
                var bank1 = context.Bank.Find(bank.Id);
                bank1.Name = bank.Name;
                context.SaveChanges();
            }
        }

        public void DeleteBank (Bank bank)
        {

        }
    }
}

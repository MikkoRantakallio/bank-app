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

        public void UpdateBank( int id, string name)
        {
            using (var context = new BankdbContext())
            {
                var bank = context.Bank.Find(id);
                bank.Name = name;
                context.SaveChanges();
            }
        }

        public void DeleteBank (int id)
        {
            using (var context = new BankdbContext())
            {
                var bank = context.Bank.Find(id);
                context.Bank.Remove(bank);
                context.SaveChanges();
            }
        }

        public Bank GetBank(int id)
        {
            using (var context = new BankdbContext())
            {
                var bank = context.Bank.Find(id);
                return bank;
            }
        }
    }
}

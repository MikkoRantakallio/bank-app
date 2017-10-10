using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp.Model
{
    public class BankAccountTransactionHandler
    {
        public BankAccountTransactionHandler()
        {
        }

        public void InsertTransAction(BankAccountTransaction trans)
        {
            using (var context = new BankdbContext())
            {
                context.Add(trans);
                context.SaveChanges();
            }
        }

        public List<BankAccountTransaction> GetCustomerTransActions(int custId)
        {
            using (var context = new BankdbContext())
            {
                BankAccountHandler accHandler = new BankAccountHandler();
                var custBankAccList = accHandler.GetCustomerAccountList(custId);

                List<BankAccountTransaction> transActionList = new List<BankAccountTransaction>();

                foreach (BankAccount acc in custBankAccList)
                {
                    var transActions = context.BankAccountTransaction.Where(bankAccountTransaction => bankAccountTransaction.Iban == acc.Iban).ToList();
                    transActionList.AddRange(transActions);
                }
                return transActionList;
            }
        }
    }
}

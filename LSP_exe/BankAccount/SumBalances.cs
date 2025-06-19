using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe.BankAccount
{
    internal class SumBalances
    {
        public static int Sum(List<IAccount> accounts)
        {
            int sum = 0;
            foreach (IAccount account in accounts)
            {
                sum += account.Balance;
            }

            return sum;
        }
        
    }
}

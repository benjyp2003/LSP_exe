using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe.BankAccount
{
    internal class BamkAccount : IAccount, ICashAccount
    {
        public int Balance {  get; set; }
        public int GetAvailableBalance()
        {
            return Balance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe.BankAccount
{
    internal interface ICashAccount : IAccount
    {
        int GetAvailableBalance();
    }
}

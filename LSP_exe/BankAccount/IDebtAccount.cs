﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe.BankAccount
{
    internal interface IDebtAccount : IAccount
    {

        void RegistorDebt();
        void GetDebtAnount();
    }
}

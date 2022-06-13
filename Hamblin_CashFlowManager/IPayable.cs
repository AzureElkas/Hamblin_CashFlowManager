using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    interface IPayable
    {
        decimal GetPayableAmount();
        public LedgerType Type { get; }
    }
}

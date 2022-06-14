using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class Employee : IPayable
    {
        public Employee(string firstName, string lastName, string SSNF, LedgerType type)
        {
            NameFirst = firstName;
            NameLast = lastName;
            SSN = SSNF;
            Type = type;
        }
        public LedgerType Type { get; }

        public decimal GetPayableAmount()
        {
            return 1M;
        }
        public virtual decimal Earnings()
        {
            //Example to prevent exceptions, remove later
            return 1M;
        }
        public string NameFirst { get; }
        public string NameLast { get; }
        public string SSN { get; }
    }
}

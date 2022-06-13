using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class Employee : IPayable
    {
        public Employee(string firstName, string lastName, string SSNF)
        {
            NameFirst = firstName;
            NameLast = lastName;
            SSN = SSNF;
        }
        public LedgerType Type { get; }

        public decimal GetPayableAmount()
        {
            throw new NotImplementedException();
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

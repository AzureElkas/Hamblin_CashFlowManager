using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class Employee : IPayable
    {
        private decimal _finalTotal;
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
            return _finalTotal;
        }
        protected void SetFinal(decimal final)
        {
            _finalTotal = final;
        }
        public string NameFirst { get; }
        public string NameLast { get; }
        public string SSN { get; }
    }
}

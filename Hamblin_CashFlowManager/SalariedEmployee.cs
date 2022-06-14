using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class SalariedEmployee : Employee
    {
        decimal _weeklySalary;
        public SalariedEmployee(string firstName, string lastName, string SSN, LedgerType type, decimal weeklySalary) : base( firstName,  lastName,  SSN, type)
        {
            _weeklySalary = weeklySalary;
        }
        public override decimal Earnings()
        {
            return 1M;
        }
        public override string ToString()
        {
            return Type + " employee: " + NameFirst + " " + NameLast + "\n" +
                "SSN: " + SSN;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class HourlyEmployee : Employee
    {
        public HourlyEmployee(string firstName, string lastName, string SSN, LedgerType type, decimal hourlyWage, int hoursWorked) : base( firstName,  lastName,  SSN, type)
        {
            
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

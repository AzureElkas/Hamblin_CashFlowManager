using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class HourlyEmployee : Employee
    {
        decimal _finalPay;
        public HourlyEmployee(string firstName, string lastName, string SSN, LedgerType type, decimal hourlyWage, int hoursWorked) : base( firstName,  lastName,  SSN, type)
        {
            SetFinal(_finalPay);
        }
        public override string ToString()
        {
            return Type + " employee: " + NameFirst + " " + NameLast + "\n" +
                "SSN: " + SSN;
        }
        
    }
}

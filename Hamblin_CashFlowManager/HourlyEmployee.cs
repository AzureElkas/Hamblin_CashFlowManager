using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class HourlyEmployee : Employee
    {
        public HourlyEmployee(string firstName, string lastName, string SSN) : base( firstName,  lastName,  SSN)
        {
            
        }
        public override decimal Earnings()
        {
            return 1M;
        }
        public override string ToString()
        {
            return "Hourly employee: " + NameFirst + " " + NameLast + "\n" +
                "SSN: " + SSN;
        }
    }
}

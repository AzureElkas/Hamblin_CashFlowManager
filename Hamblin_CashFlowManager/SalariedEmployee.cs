using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class SalariedEmployee : Employee
    {
        private decimal _weeklySalary;
        private decimal _finalPay;
        public SalariedEmployee(string firstName, string lastName, string SSN, LedgerType type, decimal weeklySalary) : base( firstName,  lastName,  SSN, type)
        {
            _weeklySalary = weeklySalary;
            _finalPay = _weeklySalary;
            //For after calculation
            SetFinal(_finalPay);
        }
        public override string ToString()
        {
            return Type + " employee: " + NameFirst + " " + NameLast + "\n" +
                "SSN: " + SSN + "\n" +
                "Weekly Salary: " + _weeklySalary.ToString("C2") + "\n" +
                "Earned: " + _finalPay.ToString("C2") + "\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class HourlyEmployee : Employee
    {
        private decimal _finalPay;
        private decimal _hourlyWage;
        private int _hoursWorked;
        public HourlyEmployee(string firstName, string lastName, string SSN, LedgerType type, decimal hourlyWage, int hoursWorked) : base( firstName,  lastName,  SSN, type)
        {
            _hourlyWage = hourlyWage;
            _hoursWorked = hoursWorked;
            switch(_hoursWorked)
            {
                case <= 40:
                    _finalPay = _hourlyWage * _hoursWorked;
                    break;
                case > 40:
                    int overHours = _hoursWorked - 40;
                    _finalPay = _hourlyWage * 40;
                    _finalPay += overHours * (_hourlyWage * 1.5M);
                    break;
            }
            SetFinal(_finalPay);
        }
        public override string ToString()
        {
            return Type + " employee: " + NameFirst + " " + NameLast + "\n" +
                "SSN: " + SSN + "\n" +
                "Hourly wage Salary: " + _hourlyWage.ToString("C2") + "\n" +
                "Hours Worked: " + _hoursWorked + "\n" +
                "Earned: " + _finalPay.ToString("C2") + "\n";
        }
        
    }
}

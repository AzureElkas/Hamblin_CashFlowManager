using System;

namespace Hamblin_CashFlowManager
{
    public enum Ledger
    {
        Hourly,
        Salaried,
        Invoice
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPayable tester = new HourlyEmployee("Test Name", "eeee", "daeaed");
        }
    }
}

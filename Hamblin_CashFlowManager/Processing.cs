using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_CashFlowManager
{
    class Processing
    {
        public string FinalCalculation(IPayable[] payableArray, int arrayPlace)
        {
                LedgerType type;
                decimal finalIn = 0;
                decimal finalSal = 0;
                decimal finalHour = 0;
                decimal finalOutput = 0;
                for (int i = 0; i < arrayPlace; i++)
                {
                    Console.WriteLine(payableArray[i].ToString());
                    type = payableArray[i].Type;
                    switch (type)
                    {
                        case LedgerType.Invoice:
                            finalIn += payableArray[i].GetPayableAmount();
                            break;
                        case LedgerType.Salaried:
                            finalSal += payableArray[i].GetPayableAmount();
                            break;
                        case LedgerType.Hourly:
                            finalHour += payableArray[i].GetPayableAmount();
                            break;
                    }
                }
                finalOutput = finalIn + finalSal + finalHour;
                return "Total Weekly Payout: " + finalOutput.ToString("C2") + "\n\n" +
                    "Category Breakdown: \n" +
                    "   Invoices: " + finalIn.ToString("C2") + "\n" +
                    "   Salaried Payroll: " + finalSal.ToString("C2") + "\n" +
                    "   Hourly Payroll: " + finalHour.ToString("C2");
        }
    }
}

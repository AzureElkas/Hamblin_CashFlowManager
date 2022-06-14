using System;


/*
 * 
 * 
 * 
 * 
*/
namespace Hamblin_CashFlowManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO, implement better try parse on salary and other
            //Implement Seed later
            Random rand = new Random();
            string inNumberFull;
            int inNumberFirst;
            int inNumberSecond;
            string response;
            bool keepLoop = true;
            string nameFirst;
            string nameLast;
            string SSN;
            string salInput;
            bool parseTry;
            IPayable[] payments = new IPayable[20];
            payments[0] = new SalariedEmployee("John", "Smith", "111-11-1111", LedgerType.Salaried, 800.50M);
            payments[1] = new SalariedEmployee("Susan", "Mathews", "222-22-222", LedgerType.Salaried, 1110M);
            payments[2] = new HourlyEmployee("Karen", "Williams", "4444-44-4444", LedgerType.Hourly, 16.75M, 40);
            payments[3] = new HourlyEmployee("Carol", "Walsh", "333-33-3333", LedgerType.Hourly, 19.50M, 42);
            inNumberFirst = rand.Next(6);
            inNumberSecond = rand.Next(4);
            inNumberFull = inNumberFirst.ToString() + "_" + inNumberSecond.ToString();
            payments[4] = new Invoice(inNumberFull, "Flux Capacitor", 2, 3655.66M, LedgerType.Invoice);
            inNumberFirst = rand.Next(6);
            inNumberSecond = rand.Next(4);
            inNumberFull = inNumberFirst.ToString() + "_" + inNumberSecond.ToString();
            payments[5] = new Invoice(inNumberFull, "Flux Capacitor", 3, 14.50M, LedgerType.Invoice);
            int arrayPlacement = 6;

            while (keepLoop && arrayPlacement < 20)
            {
                Console.WriteLine("Welcome to the cashflow manager application, please select what you would like to do: \n" +
            "(1)Add a salaried employee\n" +
            "(2)Add an hourly employee\n" +
            "(3)Add an invoice\n" +
            "(4)End program and display total");
                Console.WriteLine(payments[0].ToString());
                response = Console.ReadLine();
                switch (response.ToString())
                {
                    case "1":
                        Console.WriteLine("Please input the first name of the employee:");
                        nameFirst = Console.ReadLine();
                        Console.WriteLine("Please input the last name of the employee:");
                        nameLast = Console.ReadLine();
                        Console.WriteLine("Please input the SSN number of the employee:");
                        SSN = Console.ReadLine();
                        Console.WriteLine("Please input the weekly salary of the employee");
                        salInput = Console.ReadLine();
                        decimal weeklySal = 0;
                        parseTry = decimal.TryParse(salInput, out weeklySal);
                        if (parseTry == false)
                            break;
                        payments[arrayPlacement] = new SalariedEmployee(nameFirst, nameLast, SSN, LedgerType.Salaried, weeklySal);
                        arrayPlacement++;
                        break;
                    case "2":
                        Console.WriteLine("Please input the first name of the employee:");
                         nameFirst = Console.ReadLine();
                        Console.WriteLine("Please input the last name of the employee:");
                         nameLast = Console.ReadLine();
                        Console.WriteLine("Please input the SSN number of the employee:");
                         SSN = Console.ReadLine();
                        Console.WriteLine("Please input the hourly salary of the employee");
                         salInput = Console.ReadLine();
                        decimal hourlySal = 0;
                         parseTry = decimal.TryParse(salInput, out weeklySal);
                        if (parseTry == false)
                            break;
                        Console.WriteLine("Please input the number of hours worked");
                        string hourInput = Console.ReadLine();
                        int hours = 0;
                        parseTry = int.TryParse(hourInput, out hours);
                        if (parseTry == false)
                            break;
                        payments[arrayPlacement] = new HourlyEmployee(nameFirst, nameLast, SSN, LedgerType.Hourly, hourlySal, hours);
                        arrayPlacement++;
                        break;
                    case "3":
                        Console.WriteLine("Please enter the description of your part:");
                        string partDescrip = Console.ReadLine();
                        Console.WriteLine("Please enter the quantity of parts:");
                        int partQuantity = 0;
                        parseTry = int.TryParse(Console.ReadLine(), out partQuantity);
                        if (parseTry == false)
                            break;
                        Console.WriteLine("Please enter the price of this part:");
                        decimal partCost = 0;
                        parseTry = decimal.TryParse(Console.ReadLine(), out partCost);
                        if (parseTry == false)
                            break;
                        inNumberFirst = rand.Next(6);
                        inNumberSecond = rand.Next(4);
                        inNumberFull = inNumberFirst.ToString() + "_" + inNumberSecond.ToString();
                        payments[arrayPlacement] = new Invoice(inNumberFull, partDescrip, partQuantity, partCost, LedgerType.Invoice);
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
            }
            if (arrayPlacement >= 20)
            {
                Console.WriteLine("List space exceeded, displaying output");
                FinalCalculation(payments);
            }
        }
        //Not sure why it needs to be static, look into it
        public static void FinalCalculation(IPayable[] payableArray)
        {

        }
    }
}

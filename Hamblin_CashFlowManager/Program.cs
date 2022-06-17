using System;


/* Jace Hamblin
 * IT112
 * NOTES: I know I say this for the majority of my projects, but I'm really not happy with this one. \n
 * I could've done better, no doubt in my mind, could've made it cleaner, more advanced, etc, there's a number of little details \n
 * that could be improved if I had more time, but frankly I'm frustrated and exhausted and I have other work for other classes that needs doing, \n
 * so time isn't something I have the luxury of. I hope at the very least it's functional enough to meet the criteria, it seems to be from my testing but cant be sure
 * 
 * Addendum, I realized absolutely last minute that the rubric said no calculations in main, so I had to very shoddily move my logic into another class. \n
 * If I had more time it would've been made to feel more natural or placed under an existing class, maybe making use of the ledger file
 * 
 * BEHAVIORS NOT IMPLEMENTED AND WHY: None to my knowledge, save some things listed on the UML diagram that werent mandatory such as Earnings();
*/
namespace Hamblin_CashFlowManager
{
    class Program
    {

        static void Main(string[] args)
        {
            Processing processor = new Processing();
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
            payments[4] = new Invoice(RandomNumGen(), "Flux Capacitor", 2, 3655.66M, LedgerType.Invoice);
            payments[5] = new Invoice(RandomNumGen(), "Flux Capacitor", 3, 14.50M, LedgerType.Invoice);
            //If these werent automatically added I would increment the counter, but it seems redundant since they are
            int arrayPlacement = 6;

            while (keepLoop && arrayPlacement < 20)
            {
                Console.WriteLine("Welcome to the cashflow manager application, please select what you would like to do: \n" +
            "(1)Add a salaried employee\n" +
            "(2)Add an hourly employee\n" +
            "(3)Add an invoice\n" +
            "(4)End program and display total");
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
                         parseTry = decimal.TryParse(salInput, out hourlySal);
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
                        payments[arrayPlacement] = new Invoice(RandomNumGen(), partDescrip, partQuantity, partCost, LedgerType.Invoice);
                        arrayPlacement++;
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(processor.FinalCalculation(payments, arrayPlacement));
                        Console.WriteLine("Thank you for using this Cashflow Manager");
                        keepLoop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
                if (arrayPlacement >= 20)
                {
                    Console.Clear();
                    Console.WriteLine("List space exceeded, displaying output");
                    Console.WriteLine(processor.FinalCalculation(payments, arrayPlacement));
                    Console.WriteLine("Thank you for using this Cashflow Manager");
                    keepLoop = false;
                }
            }
        }
        public static string RandomNumGen()
        {
            string result = "";
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 6; i++)
            {
                result = result + rand.Next(9).ToString();
            }
            result = result + "_";
            for (int i = 0; i < 4; i++)
            {
                result = result + rand.Next(9).ToString();
            }
            return result;
        }
    }
}

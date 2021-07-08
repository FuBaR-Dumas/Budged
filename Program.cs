using System;
using System.Threading.Tasks;

namespace Budged
{
    class Program
    {
        static void Main(string[] args)
        {
            float budgedMoney = 0f, hotelDays = 0f;
            float foodMoney = 0f, dailyMoney = 0f, emgMoney = 0f, tripMoney = 0f;
            int p = 0;
            try
            {
            bugdedStart:
                {

                    while (p == 0)
                    {
                        Console.Write("Money from the budged: ");
                        string moneyStr = Console.ReadLine();

                        if (!float.TryParse(moneyStr, out budgedMoney))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter an actual number");
                            Console.ResetColor();
                            Console.WriteLine("");
                            continue;
                        }
                        budgedMoney = Int32.Parse(moneyStr);
                        p = 1;
                    }

                    p = 0;

                    while (p == 0)
                    {
                        Console.Write("\nWhat is the daily expense: ");
                        string dailyStr = Console.ReadLine();

                        if (!float.TryParse(dailyStr, out dailyMoney))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter an actual number");
                            Console.ResetColor();
                            continue;
                        }
                        dailyMoney = Int32.Parse(dailyStr);
                        p = 1;
                    }

                    p = 0;

                    while (p == 0)
                    {
                        Console.Write("\nWhat is the food expense: ");
                        string foodStr = Console.ReadLine();

                        if (!float.TryParse(foodStr, out foodMoney))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter an actual number");
                            Console.ResetColor();
                            continue;
                        }
                        foodMoney = Int32.Parse(foodStr);
                        p = 1;
                    }

                    p = 0;

                    while (p == 0)
                    {
                        Console.Write("\nCost of the trips: ");
                        string tripStr = Console.ReadLine();

                        if (!float.TryParse(tripStr, out tripMoney))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter an actual number");
                            Console.ResetColor();
                            continue;
                        }
                        tripMoney = Int32.Parse(tripStr);
                        p = 1;
                    }

                    p = 0;

                    while (p == 0)
                    {
                        Console.Write("\nHow many days you staying: ");
                        string hotelStr = Console.ReadLine();

                        if (!float.TryParse(hotelStr, out hotelDays))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter an actual number");
                            Console.ResetColor();
                            continue;
                        }
                        hotelDays = Int32.Parse(hotelStr);
                        p = 1;
                    }

                    p = 0;

                    while (p == 0)
                    {
                        Console.Write("\nWhat is your emergency money: ");
                        string emgStr = Console.ReadLine();

                        if (!float.TryParse(emgStr, out emgMoney))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter an actual number");
                            Console.ResetColor();
                            continue;
                        }
                        emgMoney = Int32.Parse(emgStr);
                        p = 1;
                    }

                    float totalCost = foodMoney + (dailyMoney * hotelDays) + tripMoney;
                    if (totalCost == 0)
                    {
                        Console.WriteLine("Cost are entered NULL, please, re-do the budged.");
                        goto bugdedStart;
                    }
                    else
                        Console.WriteLine("\nYour total cost: R${0}", totalCost);

                    if (totalCost == budgedMoney)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nYou reached exactly your limit of R${0}. Have a nice trip", budgedMoney);
                    }

                    if (totalCost > budgedMoney)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou exceeded your limit of R${0}. Please, recalculate the budged!", budgedMoney);
                        Console.ResetColor();
                        goto bugdedStart;
                    }

                    if (totalCost < budgedMoney)
                    {
                        float remain = budgedMoney + emgMoney - totalCost;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nYou still have R${0} from the budged and emergency! Everything in order, have a nice trip!", remain);
                        Console.ResetColor();
                    }
                }
            }

            finally
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Thank you for the preference!");
                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;


namespace Lotto_Csharp_kurs
{
    class Program
    {
        static int cumulation;
        static int START = 30;
        static Random rnd = new Random();

        static void Main(string[] args)
        {

            int money = START;
            int day = 0;

            do
            {
                money = START;
                day = 0;
                ConsoleKey choice;
                do
                {

                    cumulation = rnd.Next(2, 37) * 1000000;
                    day++;
                    int ticket = 0;
                    List<int[]> coupon = new List<int[]>();
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Dzień: {0}", day);
                        Console.WriteLine("Witaj w grze LOTTO, dziś do wygrania jest aż {0} PLN.", cumulation);
                        Console.WriteLine("\nStan konta: {0} PLN\n", money);
                        DisplayCoupon(coupon);
                        #region Menu
                        if (money >= 3 && ticket < 8)
                        {
                            Console.WriteLine("\n1 - Postaw los -3 PLN [{0}/8]", ticket);

                        }
                        Console.WriteLine("2 - Sprawdź kupon i rozpocznij losowanie");
                        Console.WriteLine("3 - Zakończ grę");


                        #endregion
                        choice = Console.ReadKey().Key;
                        if (choice == ConsoleKey.D1 && money >= 3 && ticket < 8)
                        {

                            coupon.Add(BetCoupon());
                            money -= 3;
                            ticket++;

                        }

                    } while (choice == ConsoleKey.D1);
                    Console.Clear();
                    if (coupon.Count > 0)
                    {

                        int win = Check(coupon);
                        if (win > 0)
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nBrawo!!! Wygrałeś {0} PLN", win);
                            Console.ResetColor();
                            money += win;
                        }
                        else
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nNiestety nic nie wygrałeś");
                            Console.ResetColor();


                        }

                    }
                    else
                    {
                        Console.WriteLine("W tym losowaniu nie postawiłeś żadnych losów.");
                    }
                    Console.WriteLine("Naciśnij Enter aby kontynuować");
                    Console.ReadKey();

                } while (money >= 3 && choice != ConsoleKey.D3);

                Console.Clear();
                Console.WriteLine("Dzień {0}. \nKoniec gry, twój wynik to: {1} PLN."
                , day, money - START);
                Console.WriteLine("Enter - rozpocznij nową grę.\nEscape - zamknij program");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);





        }

        private static int Check(List<int[]> coupon)
        {
            int win = 0;
            int[] rndNumbers = new int[6];
            for (int i = 0; i < rndNumbers.Length; i++)
            {

                int ticket = rnd.Next(1, 8);
                if (!rndNumbers.Contains(ticket))
                {
                    rndNumbers[i] = ticket;
                }
                else
                {
                    i--;
                }
            }
            Array.Sort(rndNumbers);
            Console.WriteLine("Wylosowane liczby to:");
            foreach (var number in rndNumbers)
            {
                Console.Write(number + ", ");
            }
            int[] WinNumbers = Check(coupon, rndNumbers);
            int winRate = 0;

            Console.WriteLine();
            if (WinNumbers[0] > 0)
            {

                winRate = WinNumbers[0] * 24;
                Console.WriteLine("3 Trafienia: + {1} PLN", WinNumbers[0], winRate);
                win += winRate;

            }
            if (WinNumbers[1] > 0)
            {

                winRate = WinNumbers[1] * rnd.Next(100, 301);
                Console.WriteLine( "4 Trafienia:  + {1} PLN", WinNumbers[1], winRate);
                win += winRate;
                 
            }
            if (WinNumbers[2] > 0)
            {

                winRate = WinNumbers[2] * rnd.Next(4000, 8001);
                Console.WriteLine("5 Trafień:  + {1} PLN", WinNumbers[2], winRate);
                win += winRate;

            }
            if (WinNumbers[3] > 0)
            {

                winRate = (WinNumbers[3] * cumulation) / (WinNumbers[3] + rnd.Next(0, 5));
                Console.WriteLine("6 Trafień:  + {1} PLN", WinNumbers[3], winRate);
                win += winRate;

            }


            return win;

        }

        private static int[] Check(List<int[]> coupon, int[] rndNumbers)
        {
            int[] winer = new int[4];
            int i = 0;
            Console.WriteLine("\n\nTWOJE KUPONY\n ");
            foreach (int[] ticket in coupon)
            {
                i++;
                Console.Write("Kupon " + i + ": ");
                int GoodNumbers = 0;
                foreach (int number in ticket)
                {

                    if (rndNumbers.Contains(number))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(number + ", ");
                        Console.ResetColor();
                        GoodNumbers++;
                    }
                    else
                    {

                        Console.Write(number + ", ");

                    }

                }
                switch (GoodNumbers)
                {
                    case 3:
                        winer[0]++;
                        break;
                    case 4:
                        winer[1]++;
                        break;
                    case 5:
                        winer[2]++;
                        break;
                    case 6:
                        winer[3]++;
                        break;
                }
                Console.WriteLine(" - Trafiono {0}/6 liczb", GoodNumbers);

            }
            return winer;
        }

        private static void DisplayCoupon(List<int[]> coupon)
        {
            if (coupon.Count == 0)
            {
                Console.WriteLine("Nie postawiłeś jeszcze żadnych losów.");
            }
            else
            {
                int i = 0;
                Console.WriteLine("\nTWOJE KUPONY:");
                foreach (int[] bet in coupon)
                {

                    i++;
                    Console.Write("Kupon " + i + ": ");
                    foreach (int number in bet)
                    {

                        Console.Write(number + ", ");

                    }
                    Console.WriteLine();
                }
            }
        }

        private static int[] BetCoupon()
        {
            int[] numbers = new int[6];
            int number = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                number = -1;
                Console.Clear();
                Console.Write("Postawione liczby: ");
                foreach (int n in numbers)
                {

                    if (n > 0)
                    {

                        Console.Write(n + ", ");
                    }

                }
                Console.WriteLine("\n\nWybierz liczbę od 1 do 49:");
                Console.Write("{0}/6: ", i + 1);
                bool good = int.TryParse(Console.ReadLine(), out number);
                if (good
                    && number >= 1
                    && number <= 49
                    && !numbers.Contains(number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Podałeś błędną liczbę!");
                    i--;
                    Console.WriteLine("Wciśnij ENTER");
                    Console.ReadKey();
                }

            }
            Array.Sort(numbers);
            return numbers;
        }

    }
}

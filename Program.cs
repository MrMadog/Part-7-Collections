using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Part_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string program;
            bool done = false;

            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine("     MAIN MENU     ");
                Console.WriteLine();
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1 - List of Integers");
                Console.WriteLine("2 - List of Strings");
                Console.WriteLine("q - Quit");
                Console.Write("Choice: ");

                program = Console.ReadLine().ToUpper();

                switch (program)
                {
                    case "1": Program1(); break;
                    case "2": Program2(); break;
                    case "Q": done = true; break;
                    default: Console.WriteLine(); Console.WriteLine("Invalid Input. "); Console.WriteLine(); break;
                }

            }

            // PROGRAM ONE --------------------------------------------------------------------------------------------------------------------------------------

            static void Program1()
            {
                bool done, done1, done2, done3;
                int choice, number, intSum, intMin, intMax;
                double intAvg;
                done = false;
                done1 = false;
                done2 = false;
                done3 = false;
                Random generator = new Random();

                Console.WriteLine();
                Console.WriteLine("Running: List of Integers... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("Here is your list of integers: ");

                List<int> integers = new List<int>();
                for (int i = 0; i < 25; i++)
                {
                    integers.Add(generator.Next(10, 21));
                    Console.Write(integers[i]);
                    if (i < 24)
                    {
                        Console.Write(", ");
                    }
                }
                Thread.Sleep(1500);

                Console.WriteLine();
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Choose one of the following options: ");
                    Console.WriteLine("  1 - Sort the list ");
                    Console.WriteLine("  2 - Generate a new list of random numbers ");
                    Console.WriteLine("  3 - Remove a number(by value) ");
                    Console.WriteLine("  4 - Add a value to the list ");
                    Console.WriteLine("  5 - Count the number of occurrences of a certain number ");
                    Console.WriteLine("  6 - Print the largest number ");
                    Console.WriteLine("  7 - Print the smallest number ");
                    Console.WriteLine("  8 - Print the sum and average ");
                    Console.WriteLine("  9 - Print most frequently occuring values "); //(top 3 maybe)
                    Console.WriteLine("  10 - Print number of occurrences from number choice of user ");
                    Console.WriteLine("  11 - Quit Program ");
                    Thread.Sleep(500);

                    Console.Write("Choice:  ");

                    while (!Int32.TryParse(Console.ReadLine(), out choice) || choice > 11 || choice <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. ");
                        Console.WriteLine();
                        Console.Write("Choice:  ");
                    }

                    Console.WriteLine();

                    switch (choice)
                    // ONE ------------------------------------------------------------------------------------------------------------------------------------------
                    {
                        case 1:
                            Console.WriteLine("Sorting Numbers... ");
                            Thread.Sleep(1000);
                            integers.Sort();
                            for (int i = 0; i < integers.Count; i++)
                            {
                                Console.Write(integers[i]);
                                if (i < integers.Count - 1)
                                {
                                    Console.Write(", ");
                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to options");
                            Console.ReadLine();
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            break;

                        // TWO ------------------------------------------------------------------------------------------------------------------------------------------

                        case 2:
                            Console.WriteLine("Making New List... ");
                            Thread.Sleep(1000);
                            integers.Clear();
                            for (int i = 0; i < 25; i++)
                            {
                                integers.Add(generator.Next(10, 21));
                                Console.Write(integers[i]);
                                if (i < 24)
                                {
                                    Console.Write(", ");
                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to options");
                            Console.ReadLine();
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            break;

                        // THREE ----------------------------------------------------------------------------------------------------------------------------------------

                        case 3:
                            do
                            {
                                Console.WriteLine("Enter a number from the list that you would like to remove");
                                Console.Write("Number:  ");
                                if (!Int32.TryParse(Console.ReadLine(), out number))
                                {
                                    Console.WriteLine("Invalid Input. ");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                }
                                else if (!integers.Contains(number))
                                {
                                    Console.WriteLine("That Number does not exist in this list!");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                }
                                else
                                {
                                    integers.RemoveAll(item => item == number);
                                    done1 = true;
                                }
                            } while (!done1);

                            Console.WriteLine();
                            Console.WriteLine("Processing... ");
                            Thread.Sleep(1000);

                            for (int i = 0; i < integers.Count; i++)
                            {
                                Console.Write(integers[i]);
                                if (i < integers.Count - 1)
                                    Console.Write(", ");
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to options");
                            Console.ReadLine();
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            break;

                        // FOUR -----------------------------------------------------------------------------------------------------------------------------------------

                        case 4:
                            do
                            {
                                Console.WriteLine("Enter a number you would like to add to the list");
                                Console.Write("Number:  ");
                                if (!Int32.TryParse(Console.ReadLine(), out number))
                                {
                                    Console.WriteLine("Invalid Input. ");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                }
                                else if (number < 0)
                                {
                                    Console.WriteLine("Invalid Input. ");
                                    Console.WriteLine("Enter a positive integer. ");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                }
                                else
                                {
                                    integers.Add(number);
                                    done2 = true;
                                }
                            } while (!done2);

                            Console.WriteLine();
                            Console.WriteLine("Processing... ");
                            Thread.Sleep(1000);

                            for (int i = 0; i < integers.Count; i++)
                            {
                                Console.Write(integers[i]);
                                if (i < integers.Count - 1)
                                    Console.Write(", ");
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to options");
                            Console.ReadLine();
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            break;

                        // FIVE -----------------------------------------------------------------------------------------------------------------------------------------

                        case 5:
                            do
                            {
                                Console.WriteLine("Enter a number to count how many times it is listed");
                                Console.Write("Number:  ");
                                if (!Int32.TryParse(Console.ReadLine(), out number))
                                {
                                    Console.WriteLine("Invalid Input. ");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                }
                                else if (!integers.Contains(number))
                                {
                                    Console.WriteLine("Invalid Input. ");
                                    Console.WriteLine("That number is not in the list. ");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                }
                                else
                                {
                                    List<int> IntOccur = integers.FindAll(item => item == number);
                                    Console.WriteLine();
                                    Console.WriteLine($"The number {number} occurred {IntOccur.Count} times in the list. ");
                                    done3 = true;
                                }
                            } while (!done3);


                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to options");
                            Console.ReadLine();
                            Console.WriteLine();
                            Thread.Sleep(1000);

                            break;

                        // SIX ------------------------------------------------------------------------------------------------------------------------------------------

                        case 6:
                            Console.WriteLine("Finding largest value... ");
                            Thread.Sleep(1000);

                            intMax = integers.Max();
                            Console.WriteLine($"The largest value is {intMax}. ");

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to options");
                            Console.ReadLine();
                            Console.WriteLine();
                            Thread.Sleep(1000);

                            break;

                        // SEVEN ----------------------------------------------------------------------------------------------------------------------------------------

                        case 7:
                            Console.WriteLine("Finding smallest value... ");
                            Thread.Sleep(1000);

                            intMin = integers.Min();
                            Console.WriteLine($"The smallest valuse is {intMin}. ");

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to options");
                            Console.ReadLine();
                            Console.WriteLine();
                            Thread.Sleep(1000);

                            break;

                        // EIGHT ----------------------------------------------------------------------------------------------------------------------------------------

                        case 8:
                            Console.WriteLine("Finding the sum and average of list... ");
                            Thread.Sleep(1000);

                            intSum = integers.Sum();
                            intAvg = integers.Average();

                            intAvg = Math.Round(intAvg, 2);

                            Console.WriteLine($"The sum of the list is {intSum} and the average is {intAvg}. ");

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to options");
                            Console.ReadLine();
                            Console.WriteLine();
                            Thread.Sleep(1000);

                            break;

                        // NINE -----------------------------------------------------------------------------------------------------------------------------------------

                        case 9:
                            Console.WriteLine("Finding the most commonly occurring numbers... ");
                            Thread.Sleep(1000);

                            // Thinking
                            break;

                        // TEN ------------------------------------------------------------------------------------------------------------------------------------------

                        case 10:
                            // same as 5???
                            break;

                        // ELEVEN ---------------------------------------------------------------------------------------------------------------------------------------

                        case 11:
                            Console.WriteLine("Quitting Program... ");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            done = true;
                            break;
                    }

                } while (!done);

                Console.WriteLine();
            }

            // PROGRAM TWO --------------------------------------------------------------------------------------------------------------------------------------

            static void Program2()
            {
                // vvv Create Variables vvv \\
                bool done = false;
                int choice;
                choice = 0;

                Console.WriteLine();
                Console.WriteLine("Running: List of Strings... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();

                // vvv Continue Here vvv \\
                Console.WriteLine("Here is your list of vegetables: ");

                List<string> vegetables = new List<string>() {"CARROT", "BEET", "CELERY", "RADISH", "CABBAGE"};

                for (int i = 0; i < vegetables.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {vegetables[i]}");
                }

                Console.WriteLine();

                do
                {
                    Console.WriteLine("Choose one of the following options: ");
                    Console.WriteLine("1 - Remove a vegetable(by index) ");
                    Console.WriteLine("2 - Remove a vegetable(by value) ");
                    Console.WriteLine("3 - Search for a vegetable ");
                    Console.WriteLine("4 - Add a vegetable ");
                    Console.WriteLine("5 - Sort list ");
                    Console.WriteLine("6 - Clear the lsit ");
                    Console.WriteLine("7 - Quit program ");
                    Thread.Sleep(500);

                    Console.Write("Choice:  ");

                    while (!Int32.TryParse(Console.ReadLine(), out choice) || choice > 7 || choice <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. ");
                        Console.WriteLine();
                        Console.Write("Choice:  ");
                    }

                    Console.WriteLine();

                    switch(choice)
                    {
                        case 1:

                            break;

                        case 2:

                            break;

                        case 3:

                            break;

                        case 4:

                            break;

                        case 5:

                            break;

                        case 6:

                            break;

                        case 7:

                            break;

                    }
                }while (!done);

                Console.WriteLine();
            }
        }
    }
}
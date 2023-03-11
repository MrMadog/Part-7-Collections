using System.Security.Cryptography.X509Certificates;

namespace Part_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             List<int> numbers = new List<int>();
             List<string> names = new List<string>() { "Arthur Dent", "Marvin" };
             List<double> prices = new List<double>();

             names.Add("Trillian");
             names.Add("Ford Prefect");

             if (names.Contains("Ford Prefect"))
             {
                 Console.WriteLine("Hello");
             }

             names.Sort();

             Console.WriteLine(names.Count);

             for (int i = 0; i < names.Count; i++)
                 Console.WriteLine(names[i]);

             foreach (string name in names)
                 Console.WriteLine(name);


             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("-------------------");

             for (int i = 0; i < names.Count; i++)
                 names[i] = names[i].ToUpper();

             names.Sort();

             for (int i = 0; i < names.Count; i++)
                 Console.WriteLine(names[i]);

             for (int i = 1; i <= 3; i++)
             {
                 Console.Write("Enter a new name:  ");
                 names.Add(Console.ReadLine().ToUpper());
             }

             names.Sort();

             for (int i = 0; i < names.Count; i++)
                 Console.WriteLine(names[i]);


             string search;

             Console.WriteLine("Enter a name to remove:  ");
             search = (Console.ReadLine().ToUpper());
             if (names.Remove(search))
             {
                 Console.WriteLine($"{search} removed!");
             }
             else
             {
                 names.Add (search);
                 Console.WriteLine($"{search} added!");
             }

             Console.WriteLine(names.Count);
            */








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
                int choice, number, occurrences;
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

                    while (!Int32.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid Input. ");
                        Console.WriteLine();
                        Console.Write("Choice:  ");
                    }

                    Console.WriteLine();

                    switch (choice)
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

                            for (int i = 0 ; i < integers.Count; i++)
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
                                    integers.FindAll(item => item == number);
                                    done3 = true;
                                }
                            } while (!done3);

                            break;

                        case 6:

                            break;

                        case 7:

                            break;

                        case 8:


                        case 9:

                            break;

                        case 10:

                            break;

                        case 11:
                            Console.WriteLine("Quitting Program... ");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            done = true;
                            break;
                    }

                }while (!done);



                Console.WriteLine();
            }

// PROGRAM TWO --------------------------------------------------------------------------------------------------------------------------------------

            static void Program2()
            {
                // vvv Create Variables vvv \\


                Console.WriteLine();
                Console.WriteLine("Running: List of Integers... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();

                // vvv Continue Here vvv \\



                Console.WriteLine();
            }



        }
    }
}
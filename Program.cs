namespace Part_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[2];

            names[0] = "John Doe";
            names[1] = "Jane Doe";

            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Random generator = new Random();

            int[] numbers = new int[30];
            int evenNum;
            evenNum = 0;


            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = generator.Next(1, 101);

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");

                    

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 2 == 0)
                {
                    evenNum += 1;
                }

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 5 == 0)
                    Console.Write(numbers[i] + " ");

            for (int i = 0; i < numbers.Length; i++)
                if (i % 2 == 0)


            Array.Sort(numbers);

            Console.WriteLine();
            Console.WriteLine(numbers[29]);
            Console.WriteLine(evenNum);
        }
    }
}
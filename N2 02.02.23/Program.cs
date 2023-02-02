using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    static class Task
    {
        static readonly Random random = new Random(); // Рандом лучше не пересоздавать, так как в качестве семени используются милисекунды, которые не успевают пройти

        private static void RandArr(int[] arr, int min, int max)
        {
            for(int i = 0; i < arr.Length; i++) arr[i] = random.Next(min, max);
        }
        private static void PrintArr(int[] arr)
        {
            Console.Write("{");
            foreach (int a in arr) Console.Write($"{a} ");
            Console.Write("}\n");
        }
        public static void N1()
        {
            int[] numbers = new int[10];
            RandArr(numbers, 0, 10);
            PrintArr(numbers);
            int evenCount = 0;
            int oddCount = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("Number of even elements: " + evenCount);
            Console.WriteLine("Number of odd elements: " + oddCount);
        }
        public static void N2()
        {
            int[] numbers = new int[10];
            RandArr(numbers, 0, 10);
            PrintArr(numbers);

            Console.Write("Enter a number: ");
            int enteredNumber = int.Parse(Console.ReadLine());

            int count = 0;
            foreach (int a in numbers)
            {
                if (a < enteredNumber)
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of elements less than {enteredNumber}: {count}");
        }
        public static void N3()
        {
            int[] numbers = new int[10];
            RandArr(numbers, 0, 10);
            PrintArr(numbers);

            int[] userNumbers = new int[3];
            for (short i = 0; i < userNumbers.Length; i++)
            {
                Console.WriteLine($"Enter number #{i + 1}:");
                string str = Console.ReadLine();
                Int32.TryParse(str, out userNumbers[i]);
            }

            int count = 0;
            for (int i = 0; i < numbers.Length - userNumbers.Length - 1; i++)
            {
                if (numbers[i] == userNumbers[0] && numbers[i + 1] == userNumbers[1] && numbers[i + 2] == userNumbers[2])
                {
                    count++;
                }
            }
            Console.WriteLine($"Count: {count}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N1:");
            Task.N1();
            Console.WriteLine("\n\nN2:");
            Task.N2();
            Console.WriteLine("\n\nN3:");
            Task.N3();

            Console.WriteLine("\nPress eny key to exit");
            Console.ReadKey();
        }
    }
}

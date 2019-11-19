using System;

namespace IntegerFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating the array, Enter 0 to stop");
            InteractiveArray(out int[] dab);
            Console.WriteLine("Created array");
            DisplayArray(dab);
            Console.WriteLine();
            Console.WriteLine("Array information: ");
            ArrayMath(dab, out int high, out int low, out int sum, out int average);
            Console.WriteLine("Highest Number: {0}, Lowest Number: {1}, Sum: {2}, Average: {3}", high, low, sum, average);
        }

        static void InteractiveArray(out int[] array)
        {
            int[] arr = new int[20];
            for (int i = 0; i < 20; ++i)
            {
                Console.Write("Enter a value for the array: ");
                int.TryParse(Console.ReadLine(), out int tmp);
                if (tmp == 0)
                {
                    break;
                }
                arr[i] = tmp;
            }
            array = arr;
        }

        static void ArrayMath(int[] array, out int highest, out int lowest, out int sum, out int average)
        {
            int low = 0, high = 0, total = 0;
            foreach (int i in array)
            {
                if (i < low)
                {
                    low = i;
                } else if (i > high)
                {
                    high = i;
                }
                total += i;
            }
            highest = high;
            lowest = low;
            sum = total;
            average = total / array.Length;
        }

        static void DisplayArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write("{0, 6}", i);
            }
            Console.WriteLine();
        }
    }
}

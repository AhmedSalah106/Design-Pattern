using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern.Strategies
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(List<int> numbers)
        {
            int n = numbers.Count;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) =
                            (numbers[j + 1], numbers[j]);

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.Write('*');
            }
            Console.WriteLine();

            Console.WriteLine("Bubble Sort completed.");
        }
    }
}

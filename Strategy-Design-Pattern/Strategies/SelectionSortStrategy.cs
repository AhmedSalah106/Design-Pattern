using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern.Strategies
{
    public class SelectionSortStrategy : ISortStrategy
    {
        public void Sort(List<int> numbers)
        {
            int n = numbers.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    (numbers[i], numbers[minIndex]) =
                        (numbers[minIndex], numbers[i]);
                }

            }

            for(int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.Write('*');
            }
            Console.WriteLine();
            Console.WriteLine("Selection Sort completed.");
        }
    }
}

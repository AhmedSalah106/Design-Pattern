using Strategy_Design_Pattern.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern.Context
{
    public class SortContext
    {
        private ISortStrategy _sortStrategy;
        public SortContext(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort(List<int> numbers)
        {
            _sortStrategy.Sort(numbers);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

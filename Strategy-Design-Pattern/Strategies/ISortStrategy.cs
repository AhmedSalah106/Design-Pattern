using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern.Strategies
{
    public interface ISortStrategy
    {
        void Sort(List<int> numbers);
    }
}

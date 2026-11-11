
using Strategy_Design_Pattern.Context;
using Strategy_Design_Pattern.Strategies;

int[] numbers = { 5, 2, 8, 1, 9 };

SortContext context = new SortContext(new BubbleSortStrategy());
context.Sort(numbers.ToList());

context.SetSortStrategy(new SelectionSortStrategy());
context.Sort(numbers.ToList());
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern.Products
{
    public class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash payment of {amount} processed.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern.Products
{
    public class VisaPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Visa payment of {amount} processed.");
        }
    }
}

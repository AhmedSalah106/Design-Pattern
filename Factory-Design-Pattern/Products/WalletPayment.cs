using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern.Products
{
    public class WalletPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Wallet payment of {amount} processed.");
        }
    }
}

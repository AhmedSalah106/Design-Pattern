using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern.Products
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }
}


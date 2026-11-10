using Factory_Design_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern.Creators
{
    public abstract class PaymentProcessor
    {
        protected abstract IPayment CreatePaymentMethod();

        public void ProcessPayment(decimal amount)
        {
            IPayment paymentMethod = CreatePaymentMethod();
            paymentMethod.Pay(amount);
        }
    }
}

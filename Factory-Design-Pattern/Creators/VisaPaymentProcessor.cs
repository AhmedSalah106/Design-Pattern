using Factory_Design_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern.Creators
{
    public class VisaPaymentProcessor: PaymentProcessor
    {
        protected override IPayment CreatePaymentMethod()
        {
            return new VisaPayment();
        }
    }
}

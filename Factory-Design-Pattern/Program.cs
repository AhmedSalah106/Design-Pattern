
using Factory_Design_Pattern.Creators;

Console.WriteLine("===== EduFlow Payment System =====");

Console.WriteLine("Choose your payment method:");
Console.WriteLine("1. Visa");
Console.WriteLine("2. Wallet");
Console.WriteLine("3. Cash");

Console.Write("\nYour choice: ");

string? choice = Console.ReadLine();


PaymentProcessor paymentProcessor = choice switch
{
    "1" => new VisaPaymentProcessor(),
    "2" => new WalletPaymentProcessor(),
    "3" => new CashPaymentProcessor(),
    _ => throw new InvalidOperationException("Invalid payment method selected.")
};


//PaymentProcessor paymentProcessor1 = new VisaPaymentProcessor();
//paymentProcessor1.ProcessPayment(100.00m);


paymentProcessor.ProcessPayment(100.00m);
using System;

public class CreditCardPayment : PaymentStrategy
{
    public override void Pay()
    {
        Console.WriteLine("Credit card payment completed.");
    }
}
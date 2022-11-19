public class CashPayment : PaymentStrategy
{
    public override void Pay()
    {
        Console.WriteLine("Cash payment completed.");
    }
}
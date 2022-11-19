public class PaymentClient{
    public static void Run(){
        IPaymentContext context = new PaymentContext(new CashPayment());
        context.Pay();
        context.SetPaymentStrategey(new CreditCardPayment());
        context.Pay();
    }
}
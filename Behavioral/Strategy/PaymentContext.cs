using System;

public interface IPaymentContext{
    void SetPaymentStrategey(PaymentStrategy strategy);
    void Pay();
}

public class PaymentContext : IPaymentContext
{
    private PaymentStrategy strategy;
    public PaymentContext(PaymentStrategy strategy){
        this.strategy = strategy;
    }
    public void Pay()
    {
        this.strategy.Pay();
    }

    public void SetPaymentStrategey(PaymentStrategy strategy)
    {
        this.strategy = strategy;
    }
}
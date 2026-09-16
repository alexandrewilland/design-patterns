var cart = new ShoppingCart(new PixPayment());
cart.Checkout(100);

cart.SetPaymentStrategy(new CreditCardPayment());
cart.Checkout(100);

interface IPaymentStrategy
{
    void Pay(decimal amount);
}

sealed class PixPayment : IPaymentStrategy
{
    public void Pay(decimal amount) => Console.WriteLine($"Pagamento de {amount:C} via Pix.");
}

sealed class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount) => Console.WriteLine($"Pagamento de {amount:C} via cartão.");
}

sealed class ShoppingCart
{
    private IPaymentStrategy paymentStrategy;

    public ShoppingCart(IPaymentStrategy paymentStrategy) => this.paymentStrategy = paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy) => this.paymentStrategy = paymentStrategy;

    public void Checkout(decimal amount) => paymentStrategy.Pay(amount);
}

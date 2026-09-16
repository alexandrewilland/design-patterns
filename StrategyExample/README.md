# Strategy

## Propósito

O Strategy define uma família de algoritmos, encapsula cada um deles e permite trocá-los em tempo de execução. O código cliente usa uma interface comum e não precisa conhecer os detalhes de cada algoritmo.

## Exemplo

`ShoppingCart` recebe uma `IPaymentStrategy`. O pagamento pode ser feito por `PixPayment` ou `CreditCardPayment`, e a estratégia é trocada com `SetPaymentStrategy` sem modificar o carrinho.

## Executar

```bash
dotnet run --project StrategyExample
```
# Observer

## Propósito

O Observer define uma relação de um-para-muitos: quando o objeto observado muda, todos os observadores inscritos recebem uma notificação. Isso reduz o acoplamento entre quem produz o evento e quem reage a ele.

## Exemplo

`WeatherStation` é o sujeito observado e mantém uma lista de `IObserver`. Quando a temperatura muda, ele chama `Update` em cada `PhoneDisplay`. Novos displays podem ser adicionados sem alterar a estação.

## Executar

```bash
dotnet run --project ObserverExample
```
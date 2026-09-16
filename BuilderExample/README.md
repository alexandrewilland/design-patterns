# Builder

## Propósito

O Builder separa a construção de um objeto complexo da sua representação final. Ele é útil quando um objeto possui várias opções e queremos montá-lo de forma legível, sem um construtor com muitos parâmetros.

## Exemplo

`SandwichBuilder` permite configurar pão, recheio e molho em chamadas encadeadas. `Build` retorna o `Sandwich` pronto. A mesma ideia pode criar várias combinações sem alterar a classe do produto.

## Executar

```bash
dotnet run --project BuilderExample
```
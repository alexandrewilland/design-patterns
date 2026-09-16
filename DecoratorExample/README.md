# Decorator

## Propósito

O Decorator adiciona responsabilidades a um objeto dinamicamente, por meio de composição, sem alterar a classe original. Ele é uma alternativa flexível à criação de muitas subclasses.

## Exemplo

`BasicMessage` fornece a mensagem. `TimestampDecorator` implementa a mesma interface, mantém uma mensagem interna e acrescenta o horário antes de delegar o conteúdo original. Outros decorators poderiam ser empilhados da mesma forma.

## Executar

```bash
dotnet run --project DecoratorExample
```
# Facade

## Propósito

O Facade fornece uma interface simples para um conjunto de classes mais complexo. Ele reduz o conhecimento que o cliente precisa ter sobre os subsistemas e organiza uma operação comum.

## Exemplo

Para assistir a um filme, seria necessário ligar projetor, ligar som, configurar volume e iniciar a exibição. `HomeTheaterFacade` reúne essa sequência em `WatchMovie`, deixando o código cliente simples.

## Executar

```bash
dotnet run --project FacadeExample
```
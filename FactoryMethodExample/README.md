# Factory Method

## Propósito

O Factory Method define um método para criar objetos, mas deixa que as subclasses decidam qual tipo concreto será criado. Assim, o código cliente depende de uma abstração, e não de `new` espalhado pelo sistema.

## Exemplo

`NotificationCreator` declara `CreateNotification`. `EmailNotificationCreator` implementa esse método e decide criar um `EmailNotification`. O programa usa o criador concreto, mas recebe uma notificação pela interface `INotification`.

## Executar

```bash
dotnet run --project FactoryMethodExample
```
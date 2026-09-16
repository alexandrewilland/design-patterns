# Adapter

## Propósito

O Adapter converte a interface de uma classe existente para outra interface esperada pelo cliente. Ele permite reutilizar uma classe incompatível sem modificar seu código.

## Exemplo

O sistema espera `ICharger`, que sabe carregar um dispositivo USB. `OldCharger` só conhece seu método antigo, `ChargeWithRoundPlug`. `UsbChargerAdapter` implementa a interface nova e traduz a chamada para o método antigo.

## Executar

```bash
dotnet run --project AdapterExample
```
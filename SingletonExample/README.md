# Singleton

## Propósito

O Singleton garante que exista apenas uma instância de uma classe e oferece um ponto global de acesso a ela. É útil quando vários pontos da aplicação precisam compartilhar o mesmo recurso, como uma configuração ou um logger.

## Exemplo

`Logger` possui um construtor privado e expõe a instância por meio da propriedade `Instance`. O `Lazy<Logger>` cria o objeto apenas quando ele é usado pela primeira vez.

O programa obtém a instância duas vezes e verifica que as referências são iguais.

## Executar

```bash
dotnet run --project SingletonExample
```

## Observação

O Singleton facilita o acesso compartilhado, mas deve ser usado com cuidado: um estado global pode dificultar testes e aumentar o acoplamento.
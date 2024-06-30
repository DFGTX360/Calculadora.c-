M# Calculadora Simples em C#

Este é um projeto de uma calculadora simples desenvolvida em C#. Ela permite realizar operações básicas como soma, subtração, multiplicação e divisão. O usuário pode selecionar a operação desejada através de um menu interativo no console.

## Funcionalidades

- Soma de dois números
- Subtração de dois números
- Multiplicação de dois números
- Divisão de dois números (com verificação de divisão por zero)

## Como usar

1. Clone este repositório:
    ```bash
    git clone https://github.com/seuusuario/nome-do-repositorio.git
    ```
2. Abra o projeto em seu IDE de C# preferido (como Visual Studio ou Visual Studio Code).
3. Compile e execute o projeto.
4. Siga as instruções no console para realizar as operações desejadas.

## Estrutura do Código

A lógica principal do programa está contida em métodos separados para cada operação (soma, subtração, multiplicação e divisão), além de um método `Menu` que exibe as opções e controla o fluxo do programa.

### Método `Menu`

O método `Menu` exibe as opções disponíveis e lê a escolha do usuário. Dependendo da escolha, ele chama o método correspondente para realizar a operação ou encerra o programa.

### Métodos de Operações

Cada método de operação (`Soma`, `Subtracao`, `Divisao`, `Multiplicacao`) realiza a operação matemática correspondente e exibe o resultado no console.

### Função `LerValor`

A função `LerValor` é usada para ler e validar os valores inseridos pelo usuário, garantindo que sejam números válidos.

## Exemplo de Uso

Ao executar o programa, o usuário verá um menu com as seguintes opções:


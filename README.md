# Calculadora Simples em C#

Este é um projeto de uma calculadora simples desenvolvido em C#. Ela permite realizar operações básicas como soma, subtração, multiplicação e divisão. O usuário pode selecionar a operação desejada através de um menu interativo no console.

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

O código está dividido em métodos separados para cada operação (soma, subtração, multiplicação e divisão) e um método `Menu` que exibe as opções e controla o fluxo do programa.

### Método `Menu`

O método `Menu` exibe as opções disponíveis e lê a escolha do usuário. Dependendo da escolha, ele chama o método correspondente para realizar a operação ou encerra o programa.

### Métodos de Operações

- `Soma`: Realiza a soma de dois números e exibe o resultado.
- `Subtracao`: Realiza a subtração de dois números e exibe o resultado.
- `Divisao`: Realiza a divisão de dois números, garantindo que o divisor não seja zero, e exibe o resultado.
- `Multiplicacao`: Realiza a multiplicação de dois números e exibe o resultado.

### Função `LerValor`

A função `LerValor` é usada para ler e validar os valores inseridos pelo usuário, garantindo que sejam números válidos.

## Exemplo de Uso

Ao executar o programa, o usuário verá um menu com as seguintes opções:


Após selecionar uma opção (1, 2, 3, 4 ou 5), o programa solicitará os valores necessários para a operação e exibirá o resultado.

## Código

```csharp
internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("--------");
        Console.WriteLine("Selecione uma opção:");

        if (short.TryParse(Console.ReadLine(), out short res))
        {
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        else
        {
            Console.WriteLine("Opção inválida! Tente novamente.");
            Console.ReadKey();
            Menu();
        }
    }

    static void Soma()
    {
        Console.Clear();

        float v1 = LerValor("Primeiro valor: ");
        float v2 = LerValor("Segundo valor: ");

        float resultado = v1 + v2;

        Console.WriteLine($"O Resultado da soma é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        float v1 = LerValor("Primeiro valor: ");
        float v2 = LerValor("Segundo valor: ");

        float resultado = v1 - v2;

        Console.WriteLine($"O Resultado da subtração é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        float v1 = LerValor("Primeiro valor: ");
        float v2;

        do
        {
            v2 = LerValor("Segundo valor (diferente de zero): ");
            if (v2 == 0)
                Console.WriteLine("Divisão por zero não é permitida.");
        } while (v2 == 0);

        float resultado = v1 / v2;

        Console.WriteLine($"O Resultado da divisão é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        float v1 = LerValor("Primeiro valor: ");
        float v2 = LerValor("Segundo valor: ");

        float resultado = v1 * v2;

        Console.WriteLine($"O Resultado da multiplicação é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static float LerValor(string mensagem)
    {
        float valor;
        while (true)
        {
            Console.Write(mensagem);
            if (float.TryParse(Console.ReadLine(), out valor))
                break;
            else
                Console.WriteLine("Valor inválido! Tente novamente.");
        }
        return valor;
    }
}

Salve este conteúdo em um arquivo chamado `README.md` no diretório raiz do seu projeto. Isso fornecerá uma documentação clara e detalhada para qualquer pessoa que visitar seu repositório no GitHub.


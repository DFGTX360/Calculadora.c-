internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer? ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("--------");
        Console.WriteLine("Selecione uma opção:");

        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma();
            break;

            case 2: Subtracao();
            break;

            case 3: Divisao();
            break;

            case 4: Multiplicacao();
            break;

            case 5: System.Environment.Exit(0);
            break;

            default: Menu();
            break;
        }


    }
    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float Resultado = v1 + v2;

        Console.WriteLine($"O Resultado da soma é {Resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Subtracao()
    {
       Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v4 = float.Parse(Console.ReadLine());

        float Resultado = v3 - v4;

        Console.WriteLine($"O Resultado da subtração é {Resultado}");
        Console.ReadKey();
        Menu();
    }   
     static void Divisao()
     {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v5 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v6 = float.Parse(Console.ReadLine());

        float Resultado = v5 / v6;

        Console.WriteLine($"O Resultado da divisão é {Resultado}");
        Console.ReadKey();
        Menu();
     }
     static void Multiplicacao()
     {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v7 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v8 = float.Parse(Console.ReadLine());

        float Resultado = v7 * v8;

        Console.WriteLine($"O Resultado da multiplicação é {Resultado}");
        Console.ReadKey();
        Menu();
     }

}
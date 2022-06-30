using System;
class Calculadora
{
    static void Main()
    {
        float num1, num2, resultado;
        int alternativa, opcao;

        Console.WriteLine("##### CALCULADORA #####");
        Console.WriteLine("\nEscolha qual cálculo deseja realizar");
        Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
        Console.Write(">>> ");
        
        alternativa =int.Parse(Console.ReadLine());

        Console.Write("Informe o primeiro valor: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        num2 = int.Parse(Console.ReadLine());

        if(alternativa == 1)
        {
            resultado = num1 + num2;
            Console.WriteLine(resultado);
        }else if(alternativa == 2)
        {
            resultado = num1 - num2;
            Console.WriteLine(resultado);
        }else if(alternativa == 3)
        {
            resultado = num1 * num2;
            Console.WriteLine(resultado);
        }else if (alternativa == 4)
        {
            resultado = num1 / num2;
            Console.WriteLine(resultado);
        }else
        {
            Console.WriteLine("Valor digitado inválido!");
        }

        Console.WriteLine("Deseja iniciar novamente?");
        opcao = int.Parse(Console.ReadLine());

        
            


     }
}
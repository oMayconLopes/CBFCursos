using System;
class sw_itch
{
    static void Main()
    {
        inicio:

        int tempo = 0;
        char escolha;

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o meio de transporte");
        Console.WriteLine("[a] Avião | [c] Carro | [o] Ônibus\n");
        
        escolha = Char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A':
                    tempo = 50;
                    break;
            case 'c':
            case 'C':
                    tempo = 60 * 8;
                    break;
            case 'o':
            case 'O':
                    tempo = 60 * 11;
                    break;
            default:
                Console.WriteLine("Escolha INVALIDA!");
                break;
                
        }

        Console.WriteLine("O tempo médio da viagem será de {0} minutos\n", tempo);

        Console.WriteLine("Calcular novamente? [s/n]");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == 's' || escolha == 'S')
        {
            goto inicio;
        }else
        {
            Console.Clear();
            Console.WriteLine("Fim do programa.");
        }





    }
}
using System;
class sw_itch
{
    static void Main()
    {
        int tempo = 0;
        char escolha;


        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o meio de transporte");
        Console.WriteLine("[a] Avião | [c] Carro | [o] Ônibus\n");
        
        escolha = Char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
                    tempo = 50;
                    break;
            case 'c':
                    tempo = 60 * 8;
                    break;
            case 'o':
                    tempo = 60 * 11;
                    break;
            default:
                Console.WriteLine("Escolha INVALIDA!");
                break;
                
        }


        Console.WriteLine("O tempo médio da viagemserá de {0} minutos", horas);



    }
}
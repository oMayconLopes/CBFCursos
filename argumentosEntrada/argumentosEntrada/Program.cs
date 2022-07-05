using System;
class main
{
    static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            Console.WriteLine("Qtd de argumentos {0}", args.Length);
        }else
        {
            Console.WriteLine("Não foram passados argumentos");
        }
    }
}
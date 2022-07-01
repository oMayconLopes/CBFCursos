using System;
class metodParams
{
    static void Main()
    {
        soma(10, 4, 11, 28, 90);
    }

    static void soma(params int[]n)
    {
        int res = 0;
        
        if (n.Length < 1)
        {
            Console.WriteLine("Não tem valores a serem somados");
        }else if (n.Length < 2)
        {
            Console.WriteLine("Valores insuficientes para somar {0}", n[0]);
        }else
        {
            for(int i = 0; i < n.Length; i++)
            {
                res+= n[i];
            }
        }

        if(res > 0)
        {
            Console.WriteLine("A soma dos valores é: {0}", res);
        }
        
    }
}
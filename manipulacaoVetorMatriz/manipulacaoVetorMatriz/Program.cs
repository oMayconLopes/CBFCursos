using System;
class manipulacaoVetorMatriz
{
    static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };
        
        Random random = new Random();  
        for(int i=0; i<vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50); //Next(unlimited); Next(limite); Next(min, max)
        }

        Console.WriteLine("Imprimindo os valore do Vetor1");
        foreach(int v in vetor1)
        {
            Console.WriteLine(v);
        }

        //Public static int BinarySearch(array,vetor)
        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
        Console.WriteLine("------------------------------------------");

        //public static void Copy(array_origem, array_destino, qtd_elementos)
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach(int n in vetor2)
            Console.WriteLine(n);
        Console.WriteLine("------------------------------------------");

        //public coid CopyTo(array_destino, Array_partir_desta_pos)
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3)
            Console.WriteLine(n);
        Console.WriteLine("------------------------------------------");

        //public long GetLongLength (dimensão)
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("------------------------------------------");

        //public int GetLowerBound (dimensão)
        Console.WriteLine("GetLowerBound");
        int menorIndiceVetor = vetor1.GetLowerBound(0);
        int menorIndiceMatriz_D1 = matriz.GetLowerBound(1); // (1) indice da matriz
        Console.WriteLine("Menor índice do vetor1 {0}", menorIndiceVetor);
        Console.WriteLine("Menor índice da Matriz {0}", menorIndiceMatriz_D1);
        Console.WriteLine("------------------------------------------");

        //public int GetUpperBound (dimensão)
        Console.WriteLine("GetUpperBound");
        int maiorIndiceVetor = vetor1.GetUpperBound(0);
        int maiorIndiceMatriz_D1 = matriz.GetUpperBound(1); // (1) indice da matriz
        Console.WriteLine("Maior índice do vetor1 {0}", maiorIndiceVetor);
        Console.WriteLine("Maior índice da Matriz {0}", maiorIndiceMatriz_D1);
        Console.WriteLine("------------------------------------------");

        //public oject GetValue(long índice)
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("Valor da posição 3 da dimensão 1 da matriz: {0}", valor1);
        Console.WriteLine("------------------------------------------");

        //public static int IndexOf(array,valor)
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3:{0}", indice1);
        Console.WriteLine("------------------------------------------");

        //public static int lastIndexOf(array, valor)
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 33:{0}", indice2);
        Console.WriteLine("------------------------------------------");

        //public static void Reverse(array)
        Console.WriteLine("Reverse");
        Array.Reverse(vetor1);
        foreach (int i in vetor1)
            Console.WriteLine(i);
        Console.WriteLine("------------------------------------------");

        //public void SetValue (object valor, long pos)
        vetor2.SetValue(99, 0);
        for(int i=0; i < vetor2.Length; i++)
            vetor2.SetValue(0,i);
        Console.WriteLine("Vetor 2");
            foreach(int n in vetor2)
                Console.WriteLine(n);
        Console.WriteLine("------------------------------------------");

        //public static void Sort(array) -> ordem crescente
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor1");
        foreach (int n in vetor1)
            Console.WriteLine(n);
        Console.WriteLine("Vetor2");
        foreach (int m in vetor3)
            Console.WriteLine(m);
        Console.WriteLine("Vetor3");
        foreach (int o in vetor3)
            Console.WriteLine(o);








    }
}
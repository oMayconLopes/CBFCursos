using System;
class arrayVetor
{
    static void Main()
    {
        float[] nota = new float [4];
        float resultado;

        int i = 0;

        for (i = 0; i < 4; i++)
        {
            Console.WriteLine("Informe a nota - {0}", i);
            nota[i]=float.Parse(Console.ReadLine());
        }

        i = 0;
        do
        {
            Console.WriteLine("A nota - {0} foi -> {1}", i, nota[i]);
            i++;
        } while (i <4);

        

    }
}
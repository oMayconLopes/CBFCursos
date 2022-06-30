using System;
class mediaAluno
{
    /*
    public void media(float nota1, float nota2, float nota3, float nota4);
    {
        media = (nota1 + nota2 + nota3 + nota4) / 4;
    }
    */

    static void Main()
    {
        {
            float nota1, nota2, nota3, nota4;
            float media = 0;

            Console.WriteLine("Media de Alunos");

            Console.WriteLine("Informe as notas do aluno");
            Console.Write("Nota 1 -> ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Nota 2 -> ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Nota 3 -> ");
            nota3 = float.Parse(Console.ReadLine());
            Console.Write("Nota 4 -> ");
            nota4 = float.Parse(Console.ReadLine());

            //Console.WriteLine("{0} {1} {2} {3}", nota1, nota2, nota3, nota4);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            //Console.WriteLine(media);  

            if(media >= 7)
            {
                Console.WriteLine("Parabéns, passou com media {0}", media);
            }
            else
            {
                Console.WriteLine("REPROVADO, com média {0}", media);
            }

        }
    }
}
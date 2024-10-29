using System;


class Program
{
    public static void Main(string[] args)
    {

        //Solicitando a nota que o aluno tirou
        Console.WriteLine("Insir sua nota (0 a 100)");
        int nota = int.Parse(Console.ReadLine());
        //Verificando se a nota é valida
        if (nota >= 0 && nota <= 100)
        {
            //Verificando se a nota é azul
            if (nota >= 60)
            {
                Console.WriteLine("Parabéns! Você ficou com nota azul");
            }
            else
            {
                Console.WriteLine("Você ficou com nota vermelha");
            }
        }
        else
        {
            Console.WriteLine("Nota Inválida. Digite outra nota");
        }

    }
}






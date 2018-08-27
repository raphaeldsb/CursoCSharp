using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine($"O valor de i é: {i}");
            //    i++;
            //}

            //for(int i = 1;i <= 10;i++)
            //{
            //    Console.WriteLine($"O valor de i é: {i}");
            //}

            double somatorio = 0;

            Console.Write("Informe o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out int tamanhoDaTurma);

            for(int i = 1; i <= tamanhoDaTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                double.TryParse(Console.ReadLine().Replace(".",","), out double notaAtual);
                somatorio += notaAtual;
            }

            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine($"A média da nota da turma é: {media.ToString("F2")} ");


        }
    }
}

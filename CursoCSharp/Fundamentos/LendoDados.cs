using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    { 
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual e´a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine().Replace(".",","));

            /*  double salario = double.Parse(Console.ReadLine(), 
                  CultureInfo.InvariantCulture); */    // Utilizando a Lib System.Globalization

            Console.WriteLine($"{nome} {idade} R$ {salario}");

        }
    }
}

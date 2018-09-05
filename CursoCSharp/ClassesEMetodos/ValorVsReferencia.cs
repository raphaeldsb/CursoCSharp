using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;     // String é class
        public int Idade;       // int é struct
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");
            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            dep.Nome = "Renato";
            dep.Idade = 21;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            string palavra1 = "Teste";
            string copiaPalavra1 = palavra1;

            Console.WriteLine($"{palavra1} {copiaPalavra1}");
            palavra1 = "Teste2";
            Console.WriteLine($"{palavra1} {copiaPalavra1}");


        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.Write("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida (Usando int.Parse()): {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Idade inserida (Usando Convert.ToInt32()): {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            String palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }

}


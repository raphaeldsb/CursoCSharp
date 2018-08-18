using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            raio = 5.5;
            double area = PI * raio * raio;

            Console.WriteLine("Area: " + (area+1000));

            //variaveis internas
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45; // 1 byte - apenas numero positivos
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // 1 byte - aceita numeros negativos -128 a 127
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue; // 2 bytes 
            Console.WriteLine("Salario: " + salario);

            int menorValorInt = int.MinValue; // 4 bytes
            Console.WriteLine("Menor valor inteiro: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // 4 bytes - numeros sem sinal
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue; // 8 bytes
            Console.WriteLine("Menor valor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // mais usado dos reais
            Console.WriteLine("Valor de Mercado da Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}

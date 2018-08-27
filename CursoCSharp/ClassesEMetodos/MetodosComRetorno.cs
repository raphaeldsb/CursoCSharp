using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar (int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            return a / b;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultadoSoma = calculadoraComum.Somar(5,5);
            Console.WriteLine(resultadoSoma);
            
            Console.WriteLine(calculadoraComum.Subtrair(5, 2));

            Console.WriteLine(calculadoraComum.Multiplicar(5, 2));

            Console.WriteLine(calculadoraComum.Dividir(5, 2));
        }
    }
}

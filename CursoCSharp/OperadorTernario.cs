using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            bool bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento 
                ? "Aprovado" : "Reprovado";
            // Se a expressão for true atribui o primeiro valor e se for false, o segundo valor

            Console.WriteLine(resultado);

             
        }
    }
}

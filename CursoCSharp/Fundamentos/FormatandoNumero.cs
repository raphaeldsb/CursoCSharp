using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));    //Formata com uma casa decimal arredondando
            Console.WriteLine(valor.ToString("C"));     //Formata em valor monetário. C = Currence
            Console.WriteLine(valor.ToString("P"));     //Multiplica por 100 e exibe como percentual
            Console.WriteLine(valor.ToString("#.##"));  //Informa a mascara. Ex. 2 casas decimais

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));   //Valor em monetário sem casa decimal, na cultura definida na linha acima

            CultureInfo cultura2 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura2));   //Valor em monetário com 3 casas decimais, na cultura definida na linha acima

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));     // Completa o número para ter 10 posições (zero à esquerda)

        }
    }
}

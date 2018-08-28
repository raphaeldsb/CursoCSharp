using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            //Acesse a variável 'a' dentro do método Executar()

            var desafioAtributo = new DesafioAtributo();
            Console.WriteLine("Valor da variável 'a': {0}", desafioAtributo.a);
            desafioAtributo.a = 20;
            Console.WriteLine("Valor da variável 'a': {0}", desafioAtributo.a);

        }
    }
}

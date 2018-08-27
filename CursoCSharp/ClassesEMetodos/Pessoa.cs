using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return !(Nome == "" && Idade <= 0) ? 
                string.Format($"Olá, me chamo {Nome} e tenho {Idade} anos.") : 
                "Os atributos não estão preenchidos.";
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Propriedade somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);   //Lambda
            //get
            //{
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional()
        {
        }
        
        public CarroOpcional(string nome, double preco)
        {
            //this.nome = nome;
            Nome = nome;
            Preco = preco;
        }
    }

    class Propriedades
    {
        public static void Executar()
        {
            var Op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(Op1.PrecoComDesconto);

            var Op2 = new CarroOpcional();
            Op2.Nome = "Direção Elétrica";
            Op2.Preco = 2349.9;

            Console.WriteLine(Op1.Nome);
            Console.WriteLine(Op1.Preco);

            Console.WriteLine(Op2.Nome);
            Console.WriteLine(Op2.Preco);
            Console.WriteLine(Op2.PrecoComDesconto);

        }
    }
}

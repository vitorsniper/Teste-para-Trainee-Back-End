using System;

namespace Teste_Back_End
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 2005;
            int anoAtual = 0;
            float salario = 1000f;
            float aumento = 0.015f;
            string s = string.Format("{0:C2}", salario);

            Console.WriteLine("O salário de Fulano em 2005 foi inicialmente de " + s);

            Console.WriteLine("Qual é o ano atual?");
            anoAtual = int.Parse(Console.ReadLine());

            for (int i = 2005; i < anoAtual; i++)
            {
                salario += (salario * aumento);
                aumento *= 2f;
                ano++;

                s = string.Format("{0:C2}", salario);

                Console.WriteLine("O salário de Fulano em " + ano + " é de " + s + ".");
            }

            Console.ReadKey();

        }
    }
}

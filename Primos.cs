using System;

namespace Back_End_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorInicial, valorFinal, verificador, i, j;

            Console.WriteLine("Digite o número inicial que seja maior que 0.");
            valorInicial = int.Parse(Console.ReadLine());

            while (valorInicial <= 0)
            {                 
                Console.WriteLine("O número digitado é menor ou igual a 0. Digite novamente.");
                valorInicial = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o número final que seja maior do que o inicial.");
            valorFinal = int.Parse(Console.ReadLine());

            while (valorFinal <= valorInicial)
            {
                Console.WriteLine("O número digitado é menor ou igual ao inicial. Digite novamente.");
                valorFinal = int.Parse(Console.ReadLine());
            }


            for(i = valorInicial; i <= valorFinal; i++)
            {
                verificador = 0;
                
                for (j = 2; j <= i/2; j++)
                {
                    if(i % j == 0f)
                    {
                        verificador++;
                        break;
                    }
                }

                if(verificador == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.ReadKey();
        }
    }
}

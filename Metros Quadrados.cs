using System;

namespace Back_End_Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int metrosQuad = 0;
            int metrosQuadPorLata = 54;
            int valorLata = 80;
            int valorFinal;
            int contador = 1;
            
            Console.WriteLine("Quantos metros quadrados serão pintados?");
            metrosQuad = int.Parse(Console.ReadLine());

            valorFinal = valorLata;

            for(int i = metrosQuadPorLata; i < metrosQuad; i += metrosQuadPorLata)
            {
                contador++;
            }

            valorFinal *= contador;

            string s = string.Format("{0:C2}", valorFinal);

            Console.WriteLine("Valor final = " + s);

            Console.ReadKey();
        }
    }
}

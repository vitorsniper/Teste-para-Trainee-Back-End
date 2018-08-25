using System;

namespace Back_End_Program_6
{
    class Program
    {

        public int valorDigitado = 0;
        public float ladoA, ladoB, area, perimetro;

        static void Main(string[] args)
        {
            ModeladorDeRetangulo modelar = new ModeladorDeRetangulo();

            Program p = new Program();

            Console.WriteLine("Boa tarde!" + "\n" + "Digite o comprimento:");
            p.ladoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura:" + "\n");
            p.ladoB = float.Parse(Console.ReadLine());

            Console.WriteLine("O que deseja fazer?" + "\n" + "Digite 1 para mudar os lados" + "\n" + "Digite 2 para calcular a área" + "\n" + "Digite 3 para calcular o perímetro" + "\n");
            p.valorDigitado = int.Parse(Console.ReadLine());

            if(p.valorDigitado == 1)
            {
                ladoA = modelar.mudarLadoA(ladoA);
                ladoB = modelar.mudarLadoB(ladoB);
            }

            if(p.valorDigitado == 2)
            {
                area = modelar.calcularArea(ladoA, ladoB);
            }

            if (p.valorDigitado == 3)
            {
                perimetro = modelar.calcularPerimetro(ladoA, ladoB);
            }

            Console.WriteLine(p.ladoA + " " + p.ladoB);

            Console.ReadKey();
        }
    }
}

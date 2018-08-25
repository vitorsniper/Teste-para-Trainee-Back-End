using System;
using System.Collections.Generic;
using System.Text;

namespace Back_End_Program_6
{
    class ModeladorDeRetangulo
    {        
        public float mudarLadoA(float ladoA)
        {
            Console.WriteLine("Digite a nova base:");
            ladoA = int.Parse(Console.ReadLine());
            
            return ladoA;
        }

        public float mudarLadoB(float ladoB)
        {
            Console.WriteLine("Digite a nova altura:");
            ladoB = int.Parse(Console.ReadLine());

            return ladoB;
        }

        public float calcularArea(float ladoA, float ladoB)
        {
            float area = ladoA * ladoB;
            return area;
        }

        public float calcularPerimetro(float ladoA, float ladoB)
        {
            float perimetro = 2 * (ladoA + ladoB);
            return perimetro;
        }

    }

    
}

using System;

namespace Back_End_Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float imposto = 0.03f;
            float horasTrab = 0f;
            float valorPorHora = 0f;
            float salarioMin = 0f;
            float salarioBruto = 0f;
            float salarioLiquido = 0f;

            Console.WriteLine("Digite as horas trabalhadas.");
            horasTrab = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário mínimo.");
            salarioMin = float.Parse(Console.ReadLine());

            valorPorHora = salarioMin * 0.10f;

            salarioBruto = horasTrab * valorPorHora;

            salarioLiquido = salarioBruto - (salarioBruto * imposto);

            Console.WriteLine(salarioLiquido);

            Console.ReadKey();
        }
    }
}

using System;

namespace Back_End_Program_5
{
    class Program
    {
        float saldo = 0f;

        static void Main(string[] args)
        {
            int numConta = 0;
            float deposito = 0f;
            float saque = 0f;
            string nomeCorrentista = " ";
            int valorDigitado = 0;
            bool acesso = false;

            Program back = new Program();

            Console.WriteLine("Digite o número da conta");
            numConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do correntista");
            nomeCorrentista = Console.ReadLine();

            acesso = true;

            Console.WriteLine("Nome do correntista é " + nomeCorrentista + "\n");
            Console.WriteLine("Bem-vindo!" + "\n");

            while (acesso)
            {
                Console.WriteLine("O que deseja fazer? \n" + "Digite 1 para alterar o nome \n" + "Digite 2 para depositar \n" + "Digite 3 para sacar \n" + "Digite 4 para sair \n");
                valorDigitado = int.Parse(Console.ReadLine());

                if (valorDigitado == 1)
                {
                    nomeCorrentista = back.alterarNome(nomeCorrentista);
                }

                if (valorDigitado == 2)
                {
                    back.saldo = back.depositar(deposito);
                }

                if (valorDigitado == 3)
                {
                    back.sacar(saque);
                }

                if (valorDigitado == 4)
                {
                    acesso = false;
                }

                Console.WriteLine("Saldo atual = " + back.saldo + "\n");
                Console.WriteLine("Até mais! :)");

            }
            Console.ReadKey();
        }

        public string alterarNome(string nome)
        {
            Console.WriteLine("Digite o novo nome do correntista" + "\n");
            nome = Console.ReadLine();
            Console.WriteLine("Novo nome do correntista é " + nome + "\n");
            return nome;
        }

        public float depositar(float deposito)
        {
            Console.WriteLine("Digite o valor a ser depositado: " + "\n");
            deposito = float.Parse(Console.ReadLine());
            return deposito;
        }

        public void sacar(float saque)
        {
            Console.WriteLine("Quanto deseja sacar?" + "\n");
            saque = float.Parse(Console.ReadLine());

            if(saque <= saldo)
                saldo -= saque;
            else
                Console.WriteLine("Não há saldo suficiente." + "\n");
        }
    }
}

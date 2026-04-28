using System;

namespace menuBasicoCsharp.funcoes
{
    class VerificaMaior
    {
        public static void verificaOMaiorEntre2Numeros()
        {

            {
                int n1, n2;

                Console.Clear();
                n1 = LerInteiro.lerInteiro("Insira um numero: ");
                n2 = LerInteiro.lerInteiro("Insira outro: ");

                if (n1 > n2)
                {
                    Console.WriteLine($"{n1} é maior que {n2}.");
                }
                else if (n2 == n1)
                {
                    Console.WriteLine("Os numeors são iguais.");
                }
                else
                {
                    Console.WriteLine($"{n2} é maior que {n1}.");
                }
                Console.ReadKey();
            }
        }
    }
}
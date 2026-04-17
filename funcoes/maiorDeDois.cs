using System;

namespace menuBasicoCsharp.funcoes
{
    class maiorDeDois
    {
        public void verificarMaiorEntreDoisNumeros()
        {
            int n1, n2;
            Console.Clear();
            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Insira ouro: ");
            int.TryParse(Console.ReadLine(), out n2);
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
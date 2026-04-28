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
while (true)
{
    Console.Write("Insira um numero: ");
    string input = "";

    while (true)
    {
        var key = Console.ReadKey(intercept: true);

        if (key.Key == ConsoleKey.Enter)
        {
            if (int.TryParse(input, out n1)) goto fim;
            
            // Limpa a linha E reescreve o prompt
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            Console.Write("Insira um numero: ");
            input = "";
        }
        else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
        {
            input = input[..^1];
            Console.Write("\b \b");
        }
        else if (!char.IsControl(key.KeyChar))
        {
            input += key.KeyChar;
            Console.Write(key.KeyChar);
        }
    }
}
fim:;

                while (true)
                {
                    Console.Write("\rInsira outro: ");
                    if (int.TryParse(Console.ReadLine(), out n2))
                    {
                        break;
                    }
                }

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
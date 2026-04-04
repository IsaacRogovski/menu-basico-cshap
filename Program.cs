using System;

namespace menuBasicoCsharp
{
    class Progam
    {
        public static void Main(string[] arg)
        {
            Funcoes funcoes = new Funcoes();

            bool sistema = true;
            int opcao;

            while (sistema)
            {
                Console.Clear();
                Console.WriteLine("+───Opções───+\n");
                Console.WriteLine("┌ 1 - Verificar o maior número entre DOIS.");
                Console.WriteLine("├ 2 - Verificar se pode votar com X idade.");
                Console.WriteLine("├ 3 - Verificar se um número é PAR");
                Console.WriteLine("├ 4 - Verificar se um número é multiplo de CINCO.");
                Console.WriteLine("├ 5 - Verificar se um número é maior que DEZ.");
                Console.WriteLine("├ 6 - Sistema basido de compras (Teclado, Mouse e PenDrive).");
                Console.WriteLine("├ 7 - Calcular média de DUAS notas.");
                Console.WriteLine("├ 8 - Ler 2 numeros, exibi-los e depois troca-los de lugar.");
                Console.WriteLine("├ 9 - Formula de Baskhara.");
                Console.WriteLine("└ 0 - SAIR.");
                Console.Write("\nInsira a opção que deseja: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            funcoes.verificarMaior();
                            break;
                        case 2:
                            funcoes.votar();
                            break;
                        case 3:
                            funcoes.ePar();
                            break;
                        case 4:
                            funcoes.multiploDe5();
                            break;
                        case 5:
                            funcoes.maiorOuIgual10();
                            break;
                        case 6:
                            funcoes.valorItens();
                            break;
                        case 7:
                            funcoes.mediaNota();
                            break;
                        case 8:
                            funcoes.trocarValores();
                            break;
                        case 9:
                            funcoes.baskara();
                            break;
                        case 0:
                            sistema = false;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
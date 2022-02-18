using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saida = "";
            do
            {
                Console.Write("Numero de comandos: ");
                int numeroDeComandos = int.Parse(Console.ReadLine());

                Console.Write("\nDigite os comandos E ou D: ");
                string comandoDados = Console.ReadLine();

                char[] comandoDadosConvertidos = comandoDados.ToCharArray();

                //    N
                //  O   L
                //    S
                char posicaoAtual = 'N';

                for (int i = 0; i < comandoDadosConvertidos.Length; i++)
                {
                    if (comandoDadosConvertidos[i] == 'D')
                    {
                        if (posicaoAtual == 'N')
                        {
                            posicaoAtual = 'L';
                        }
                        else if (posicaoAtual == 'S')
                        {
                            posicaoAtual = 'O';
                        }
                        else if (posicaoAtual == 'L')
                        {
                            posicaoAtual = 'S';
                        }
                        else if (posicaoAtual == 'O')
                        {
                            posicaoAtual = 'N';
                        }
                    }
                    else if (comandoDadosConvertidos[i] == 'E')
                    {
                        if (posicaoAtual == 'N')
                        {
                            posicaoAtual = 'O';
                        }
                        else if (posicaoAtual == 'S')
                        {
                            posicaoAtual = 'L';
                        }
                        else if (posicaoAtual == 'L')
                        {
                            posicaoAtual = 'N';
                        }
                        else if (posicaoAtual == 'O')
                        {
                            posicaoAtual = 'S';
                        }
                    }
                    
                }
                Console.WriteLine(posicaoAtual);
                Console.WriteLine("\nDigite 0 para sair: ");
                saida = Console.ReadLine();
            } while (saida != "0");
        }
    }
}

using System;
using System.Text;
using tabuleiro;
using xadrex;

namespace xadrez_console
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tabuleiro);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrex().toPosicao();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrex().toPosicao();

                    partida.executaMovimento(origem, destino);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}

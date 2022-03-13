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
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

                Tela.imprimirTabuleiro(partidaDeXadrez.tabuleiro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}

using System;
using tabuleiro;
using xadrez;



namespace Xadrez_Console {
    class Program {
        static void Main(string[] args) {
            try {

                PartidaDeXadrez partida = new PartidaDeXadrez();
                

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Digite a posição de Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Digite a posição de Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
               

                
            } catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}

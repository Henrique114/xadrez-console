using tabuleiro;
using xadez;
using xadrez_console.tabuleiro;

namespace xadrez_console;
class Program{
    static void Main(string[] args) 
    {
        try {

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(Cor.Pretas, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Pretas, tab), new Posicao(1, 3));
            tab.colocarPeca(new Torre(Cor.Pretas, tab), new Posicao(1, 9));
            tab.colocarPeca(new Rei(Cor.Pretas, tab), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
}

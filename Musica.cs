using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Musica
    {
        public string nome;
        public string artista;
        public int duracao;
        public bool disponivel;

    public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {nome}.");
            Console.WriteLine($"Artista: {artista}.");
            Console.WriteLine($"Duração: {duracao}.");
            if (disponivel) { Console.WriteLine($"A musica está disponivel no seu plano");
            }
            else { Console.WriteLine("Está musica está disponivel apenas por assinatura, adquira um plano Plus+");
            }
        }
    }
}

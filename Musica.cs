using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Musica
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }

        //Lambda =>
        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}.";
        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}.");
            Console.WriteLine($"Artista: {Artista}.");
            Console.WriteLine($"Duração: {Duracao}.");
            if (Disponivel) { Console.WriteLine($"A musica está disponivel no seu plano");
            }
            else { Console.WriteLine("Está musica está disponivel apenas por assinatura, adquira um plano Plus+");
            }
        }
    }
}

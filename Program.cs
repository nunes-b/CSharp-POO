using ScreenSound;

Musica musica1 = new Musica();
musica1.Nome = "Roxanne";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);


Musica musica2 = new Musica();
musica2.Nome = "False BoDY";
musica2.Artista = "The Body";
musica2.Duracao = 123;
musica2.Disponivel = false;



musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();




Album albumDoManowar = new Album();
albumDoManowar.Nome = "Louder than Hell";

Musica musica1 = new Musica();
musica1.Nome = "Brothers of Metal (Pt. 1)";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Number 1";
musica2.Duracao = 307;

albumDoManowar.AdicionarMusica(musica1);
albumDoManowar.AdicionarMusica(musica2);

albumDoManowar.ExibirMusicasDoAlbum();
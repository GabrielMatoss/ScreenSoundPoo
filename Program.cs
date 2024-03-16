Banda manowar = new Banda("Manowar");

Album albumDoManowar = new Album("Louder than Hell");

Musica musica1 = new Musica(manowar, "Brothers of Metal (Pt. 1)")
{
    Duracao = 213,
    Disponivel = true
};

Musica musica2 = new Musica(manowar, "Number 1")
{
    Duracao = 307,
    Disponivel = false
};

albumDoManowar.AdicionarMusica(musica1);
albumDoManowar.AdicionarMusica(musica2);
manowar.AdicionarAlbum(albumDoManowar);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoManowar.ExibirMusicasDoAlbum();

manowar.ExibirDiscografia();